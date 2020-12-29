using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using Remotion.Linq;
using Remotion.Linq.Clauses;
using SharpVk.Spirv;

namespace SharpVk.Shanq
{
    public class ShanqQueryExecutor
        : IQueryExecutor
    {
        private readonly string entryPointName;
        private readonly ExecutionModel model;
        private readonly Stream outputStream;
        private readonly IVectorTypeLibrary vectorLibrary;

        public ShanqQueryExecutor(ExecutionModel model, Stream outputStream, IVectorTypeLibrary vectorLibrary, string entryPointName)
        {
            this.model = model;
            this.outputStream = outputStream;
            this.vectorLibrary = vectorLibrary;
            this.entryPointName = entryPointName;
        }

        public IEnumerable<T> ExecuteCollection<T>(QueryModel queryModel)
        {
            var file = new SpirvFile();

            file.AddHeaderStatement(Op.OpCapability, Capability.Shader);
            file.AddHeaderStatement(file.GetNextResultId(), Op.OpExtInstImport, "GLSL.std.450");
            file.AddHeaderStatement(Op.OpMemoryModel, AddressingModel.Logical, MemoryModel.GLSL450);

            var expressionVisitor = new ShanqExpressionVisitor(file, vectorLibrary);

            var voidId = expressionVisitor.Visit(Expression.Constant(typeof(void)));
            var actionId = expressionVisitor.Visit(Expression.Constant(typeof(Action)));

            var entryPointerFunctionId = file.GetNextResultId();
            var entryPointerLabelId = file.GetNextResultId();

            file.AddFunctionStatement(entryPointerFunctionId, Op.OpFunction, voidId, FunctionControl.None, actionId);
            file.AddFunctionStatement(entryPointerLabelId, Op.OpLabel);

            var fieldMapping = new Dictionary<FieldInfo, ResultId>();
            var bindingMapping = new Dictionary<FieldInfo, Tuple<ResultId, int>>();
            var builtinList = new Dictionary<FieldInfo, Tuple<ResultId, ResultId, int>>();

            var executionModes = new List<ExecutionMode>();

            var hasBuiltInOutput = false;

            var resultType = typeof(T);

            foreach (var field in resultType.GetFields())
            {
                if (field.GetCustomAttribute<LocationAttribute>() != null)
                {
                    var pointerType = typeof(OutputPointer<>).MakeGenericType(field.FieldType);
                    var outputPointerId = expressionVisitor.Visit(Expression.Constant(pointerType));
                    var outputVariableId = file.GetNextResultId();

                    file.AddGlobalStatement(outputVariableId, Op.OpVariable, outputPointerId, StorageClass.Output);

                    fieldMapping.Add(field, outputVariableId);
                }

                var builtInAttr = field.GetCustomAttribute<BuiltInAttribute>();

                hasBuiltInOutput |= builtInAttr != null;

                if (builtInAttr?.BuiltIn == BuiltIn.FragDepth) executionModes.Add(ExecutionMode.DepthReplacing);
            }

            var fromClauses = new FromClauseBase[]
                {
                    queryModel.MainFromClause
                }
                .Concat(queryModel.BodyClauses.OfType<AdditionalFromClause>());

            var inputTypes = new List<Type>();
            var bindingTypes = new List<(Type, int, int)>();
            var samplerTypes = new List<(IFromClause, int, int)>();

            foreach (var clause in fromClauses)
            {
                var queryable = (IShanqQueryable)((ConstantExpression)clause.FromExpression).Value;

                switch (queryable.Origin)
                {
                    case QueryableOrigin.Input:
                        inputTypes.Add(clause.ItemType);
                        break;
                    case QueryableOrigin.Binding:
                        bindingTypes.Add((clause.ItemType, queryable.Binding, queryable.DescriptorSet));
                        break;
                    case QueryableOrigin.Sampler:
                        samplerTypes.Add((clause, queryable.Binding, queryable.DescriptorSet));
                        break;
                }
            }

            foreach (var field in inputTypes.SelectMany(type => type.GetFields()))
                if (field.GetCustomAttribute<LocationAttribute>() != null || field.GetCustomAttribute<BuiltInAttribute>() != null)
                {
                    var pointerType = typeof(InputPointer<>).MakeGenericType(field.FieldType);
                    var inputPointerId = expressionVisitor.Visit(Expression.Constant(pointerType));
                    var inputVariableId = file.GetNextResultId();

                    file.AddGlobalStatement(inputVariableId, Op.OpVariable, inputPointerId, StorageClass.Input);

                    fieldMapping.Add(field, inputVariableId);

                    expressionVisitor.AddInputMapping(field, inputVariableId);
                }

            foreach (var (type, binding, descriptorSet) in bindingTypes)
            {
                var structureTypeId = expressionVisitor.Visit(Expression.Constant(type));
                var pointerType = typeof(UniformPointer<>).MakeGenericType(type);
                var uniformPointerId = expressionVisitor.Visit(Expression.Constant(pointerType));
                var uniformVariableId = file.GetNextResultId();

                file.AddGlobalStatement(uniformVariableId, Op.OpVariable, uniformPointerId, StorageClass.Uniform);
                file.AddAnnotationStatement(Op.OpDecorate, structureTypeId, Decoration.Block);
                file.AddAnnotationStatement(Op.OpDecorate, uniformVariableId, Decoration.DescriptorSet, descriptorSet);
                file.AddAnnotationStatement(Op.OpDecorate, uniformVariableId, Decoration.Binding, binding);

                var fieldIndex = 0;

                foreach (var field in type.GetFieldsByOffset())
                {
                    expressionVisitor.AddBinding(field, Tuple.Create(uniformVariableId, fieldIndex));

                    if (vectorLibrary.IsMatrixType(field.FieldType))
                    {
                        //HACK Should adapt to different matrix formats
                        file.AddAnnotationStatement(Op.OpMemberDecorate, structureTypeId, fieldIndex, Decoration.ColMajor);
                        file.AddAnnotationStatement(Op.OpMemberDecorate, structureTypeId, fieldIndex, Decoration.Offset, Marshal.OffsetOf(type, field.Name).ToInt32());
                        file.AddAnnotationStatement(Op.OpMemberDecorate, structureTypeId, fieldIndex, Decoration.MatrixStride, 16);
                    }

                    fieldIndex++;
                }
            }

            foreach (var (clause, binding, descriptorSet) in samplerTypes)
            {
                var type = clause.ItemType;

                var structureTypeId = expressionVisitor.Visit(Expression.Constant(type));
                var pointerType = typeof(UniformConstantPointer<>).MakeGenericType(type);
                var uniformPointerId = expressionVisitor.Visit(Expression.Constant(pointerType));
                var uniformVariableId = file.GetNextResultId();

                file.AddGlobalStatement(uniformVariableId, Op.OpVariable, uniformPointerId, StorageClass.UniformConstant);
                file.AddAnnotationStatement(Op.OpDecorate, uniformVariableId, Decoration.DescriptorSet, descriptorSet);
                file.AddAnnotationStatement(Op.OpDecorate, uniformVariableId, Decoration.Binding, binding);

                expressionVisitor.AddSampler(clause, uniformVariableId);
            }

            var entryPointParameters = fieldMapping.Select(x => x.Value).Distinct().ToList();

            if (hasBuiltInOutput)
            {
                var builtInFields = resultType.GetFieldsByOffset().Select(x => new
                    {
                        Field = x,
                        x.GetCustomAttribute<BuiltInAttribute>()?.BuiltIn
                    })
                    .Where(x => x.BuiltIn != null);

                var structureType = GetTupleType(builtInFields.Count()).MakeGenericType(builtInFields.Select(x => x.Field.FieldType).ToArray());
                var structureTypeId = expressionVisitor.Visit(Expression.Constant(structureType));

                var structurePointerType = typeof(OutputPointer<>).MakeGenericType(structureType);
                var structurePointerId = expressionVisitor.Visit(Expression.Constant(structurePointerType));
                var outputVariableId = file.GetNextResultId();

                file.AddGlobalStatement(outputVariableId, Op.OpVariable, structurePointerId, StorageClass.Output);

                file.AddAnnotationStatement(Op.OpDecorate, structureTypeId, Decoration.Block);

                foreach (var field in builtInFields.Select((x, y) => new
                {
                    Index = y,
                    x.Field,
                    x.BuiltIn.Value
                }))
                {
                    file.AddAnnotationStatement(Op.OpMemberDecorate, structureTypeId, field.Index, Decoration.BuiltIn, field.Value);
                    builtinList.Add(field.Field, Tuple.Create(structurePointerId, outputVariableId, field.Index));
                }

                entryPointParameters.Add(outputVariableId);
            }

            file.AddHeaderStatement(Op.OpEntryPoint, new object[]
            {
                model, entryPointerFunctionId, entryPointName
            }.Concat(entryPointParameters.Cast<object>()).ToArray());
            if (model == ExecutionModel.Fragment) executionModes.Add(ExecutionMode.OriginUpperLeft);
            foreach (var mode in executionModes) file.AddHeaderStatement(Op.OpExecutionMode, entryPointerFunctionId, mode);

            foreach (var mapping in fieldMapping)
                if (mapping.Key.GetCustomAttribute<LocationAttribute>() != null)
                {
                    var attribute = mapping.Key.GetCustomAttribute<LocationAttribute>();

                    file.AddAnnotationStatement(Op.OpDecorate, mapping.Value, Decoration.Location, attribute.LocationIndex);
                }
                else if (mapping.Key.GetCustomAttribute<BuiltInAttribute>() != null)
                {
                    var attribute = mapping.Key.GetCustomAttribute<BuiltInAttribute>();

                    file.AddAnnotationStatement(Op.OpDecorate, mapping.Value, Decoration.BuiltIn, attribute.BuiltIn);
                }

            var selector = queryModel.SelectClause.Selector;

            switch (selector.NodeType)
            {
                case ExpressionType.Constant:
                    foreach (var field in resultType.GetFields())
                    {
                        var fieldValue = field.GetValue(((ConstantExpression)queryModel.SelectClause.Selector).Value);

                        var valueId = expressionVisitor.Visit(Expression.Constant(fieldValue, field.FieldType));

                        file.AddFunctionStatement(Op.OpStore, fieldMapping[field], valueId);
                    }
                    break;
                case ExpressionType.MemberInit:
                    var initExpression = (MemberInitExpression)selector;

                    foreach (var binding in initExpression.Bindings)
                    {
                        var fieldValue = ((MemberAssignment)binding).Expression;

                        var valueId = expressionVisitor.Visit(fieldValue);

                        var field = (FieldInfo)binding.Member;

                        if (fieldMapping.ContainsKey(field))
                        {
                            file.AddFunctionStatement(Op.OpStore, fieldMapping[field], valueId);
                        }
                        else if (builtinList.ContainsKey(field))
                        {
                            var constantIndex = expressionVisitor.Visit(Expression.Constant(builtinList[field].Item3));
                            var fieldId = file.GetNextResultId();

                            var fieldPointerType = typeof(OutputPointer<>).MakeGenericType(field.FieldType);
                            var fieldPointerTypeId = expressionVisitor.Visit(Expression.Constant(fieldPointerType));

                            file.AddFunctionStatement(fieldId, Op.OpAccessChain, fieldPointerTypeId, builtinList[field].Item2, constantIndex);
                            file.AddFunctionStatement(Op.OpStore, fieldId, valueId);
                        }
                    }
                    break;
                default:
                    throw new NotImplementedException();
            }

            file.AddFunctionStatement(Op.OpReturn);
            file.AddFunctionStatement(Op.OpFunctionEnd);

            var bound = file.Entries.Select(x => x.ResultId)
                .Where(x => x.HasValue)
                .Max(x => x.Value.Id) + 1;

            var sink = new BinarySink(outputStream, bound);

            foreach (var entry in file.Entries) sink.AddStatement(entry.ResultId, entry.Statement);

            return Enumerable.Empty<T>();
        }

        public T ExecuteScalar<T>(QueryModel queryModel)
        {
            throw new NotImplementedException();
        }

        public T ExecuteSingle<T>(QueryModel queryModel, bool returnDefaultWhenEmpty)
        {
            throw new NotImplementedException();
        }

        private static Type GetTupleType(int count)
        {
            switch (count)
            {
                case 1:
                    return typeof(Tuple<>);
                case 2:
                    return typeof(Tuple<,>);
                case 3:
                    return typeof(Tuple<,,>);
                case 4:
                    return typeof(Tuple<,,,>);
                case 5:
                    return typeof(Tuple<,,,,>);
                case 6:
                    return typeof(Tuple<,,,,,>);
                case 7:
                    return typeof(Tuple<,,,,,,>);
                case 8:
                    return typeof(Tuple<,,,,,,,>);
                default:
                    throw new NotSupportedException();
            }
        }
    }
}