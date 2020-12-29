using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Remotion.Linq.Clauses;
using Remotion.Linq.Clauses.Expressions;
using SharpVk.Spirv;

namespace SharpVk.Shanq
{
    internal class ShanqExpressionVisitor
    {
        private static readonly Dictionary<Type, (Op TypeOp, int[] Operands)> primitiveTypeMapping = new Dictionary<Type, (Op, int[])>
        {
            [typeof(long)] = (Op.OpTypeInt, new[]
            {
                64, 1
            }),
            [typeof(int)] = (Op.OpTypeInt, new[]
            {
                32, 1
            }),
            [typeof(short)] = (Op.OpTypeInt, new[]
            {
                16, 1
            }),
            [typeof(sbyte)] = (Op.OpTypeInt, new[]
            {
                8, 1
            }),
            [typeof(ulong)] = (Op.OpTypeInt, new[]
            {
                64, 0
            }),
            [typeof(uint)] = (Op.OpTypeInt, new[]
            {
                32, 0
            }),
            [typeof(ushort)] = (Op.OpTypeInt, new[]
            {
                16, 0
            }),
            [typeof(byte)] = (Op.OpTypeInt, new[]
            {
                8, 0
            }),
            [typeof(double)] = (Op.OpTypeFloat, new[]
            {
                64
            }),
            [typeof(float)] = (Op.OpTypeFloat, new[]
            {
                32
            }),
            [typeof(void)] = (Op.OpTypeVoid, new int[0])
        };
        private readonly Dictionary<FieldInfo, Tuple<ResultId, int>> bindingMappings = new Dictionary<FieldInfo, Tuple<ResultId, int>>();
        private readonly Dictionary<SpirvStatement, ResultId> expressionResults = new Dictionary<SpirvStatement, ResultId>();

        private readonly Dictionary<ExpressionType, Func<Expression, ResultId>> expressionVisitors = new Dictionary<ExpressionType, Func<Expression, ResultId>>();

        private readonly SpirvFile file;
        private readonly Dictionary<FieldInfo, ResultId> inputMappings = new Dictionary<FieldInfo, ResultId>();
        private readonly Dictionary<IFromClause, ResultId> samplerMappings = new Dictionary<IFromClause, ResultId>();
        private readonly IVectorTypeLibrary vectorLibrary;

        public ShanqExpressionVisitor(SpirvFile file, IVectorTypeLibrary vectorLibrary)
        {
            var visitMethods = GetType()
                .GetMethods(BindingFlags.NonPublic | BindingFlags.Instance)
                .Where(method => method.GetCustomAttribute<NodeTypeAttribute>() != null);

            foreach (var method in visitMethods)
            {
                var attribute = method.GetCustomAttribute<NodeTypeAttribute>();

                expressionVisitors.Add(attribute.NodeType, x => (ResultId)method.Invoke(this, new object[]
                {
                    x
                }));
            }

            this.file = file;
            this.vectorLibrary = vectorLibrary;
        }

        public void AddInputMapping(FieldInfo field, ResultId resultId)
        {
            inputMappings.Add(field, resultId);
        }

        public void AddBinding(FieldInfo field, Tuple<ResultId, int> binding)
        {
            bindingMappings.Add(field, binding);
        }

        public void AddSampler(IFromClause clause, ResultId resultId)
        {
            samplerMappings.Add(clause, resultId);
        }

        public ResultId Visit(Expression expression)
        {
            if (!expressionVisitors.TryGetValue(expression.NodeType, out var visit))
                throw new NotImplementedException($"{expression} not implemented.");
            return visit(expression);
        }

        [NodeType(ExpressionType.Convert)]
        private ResultId VisitConvert(UnaryExpression expression)
        {
            var mapping = new Dictionary<(Type, Type), Op>
            {
                [(typeof(float), typeof(int))] = Op.OpConvertFToS,
                [(typeof(float), typeof(uint))] = Op.OpConvertFToU,
                [(typeof(int), typeof(float))] = Op.OpConvertSToF,
                [(typeof(uint), typeof(float))] = Op.OpConvertUToF,
                [(typeof(int), typeof(uint))] = Op.OpSConvert,
                [(typeof(uint), typeof(int))] = Op.OpUConvert
            };

            if (mapping.TryGetValue((expression.Operand.Type, expression.Type), out var convertOp))
            {
                var result = file.GetNextResultId();

                var subExpressionId = Visit(expression.Operand);

                file.AddFunctionStatement(result, convertOp, Visit(Expression.Constant(expression.Type)), subExpressionId);

                return result;
            }
            throw new NotImplementedException($"Conversion from {expression.Operand.Type} to {expression.Type} not implemented.");
        }

        [NodeType(ExpressionType.Call)]
        private ResultId VisitCall(MethodCallExpression expression)
        {
            var methodDeclaringType = expression.Method.DeclaringType;

            if (IsSampler(methodDeclaringType))
            {
                var sourceReference = (QuerySourceReferenceExpression)expression.Object;
                var samplerTypeId = Visit(Expression.Constant(expression.Object.Type));
                var samplerId = samplerMappings[(IFromClause)sourceReference.ReferencedQuerySource];
                var loadedSamplerId = file.GetNextResultId();
                file.AddFunctionStatement(loadedSamplerId, Op.OpLoad, samplerTypeId, samplerId);

                if (expression.Method.Name == nameof(Sampler2d<float, float>.Sample))
                {
                    var resultTypeId = Visit(Expression.Constant(expression.Method.ReturnType));

                    var coordId = Visit(expression.Arguments[0]);

                    var sampleId = file.GetNextResultId();

                    file.AddFunctionStatement(sampleId, Op.OpImageSampleImplicitLod, resultTypeId, loadedSamplerId, coordId);

                    return sampleId;
                }
                throw new NotImplementedException();
            }
            throw new NotImplementedException();
        }

        [NodeType(ExpressionType.Negate)]
        private ResultId VisitNegate(UnaryExpression expression)
        {
            if (GetElementType(expression.Type) != typeof(float)) throw new NotSupportedException($"Expressions of type {expression.Type} are not supported.");

            return VisitUnary(expression, Op.OpFNegate);
        }

        [NodeType(ExpressionType.Add)]
        private ResultId VisitAdd(BinaryExpression expression)
        {
            var additionOp = SelectByType(expression.Type, Op.OpFAdd, Op.OpIAdd);

            return VisitBinary(expression, additionOp);
        }

        [NodeType(ExpressionType.Subtract)]
        private ResultId VisitSubtract(BinaryExpression expression)
        {
            var subtractionOp = SelectByType(expression.Type, Op.OpFSub, Op.OpISub);

            return VisitBinary(expression, subtractionOp);
        }

        [NodeType(ExpressionType.Multiply)]
        private ResultId VisitMultiply(BinaryExpression expression)
        {
            Op multiplicationOp;

            if (vectorLibrary.IsVectorType(expression.Left.Type) && !vectorLibrary.IsVectorType(expression.Right.Type))
            {
                if (!IsFloatingPoint(vectorLibrary.GetVectorElementType(expression.Left.Type))
                    || !IsFloatingPoint(GetElementType(expression.Right.Type)))
                    throw new NotSupportedException("Vector by scalar multiplication is only supported for floating point types.");

                if (vectorLibrary.IsMatrixType(expression.Right.Type))
                    multiplicationOp = Op.OpVectorTimesMatrix;
                else
                    multiplicationOp = Op.OpVectorTimesScalar;
            }
            else if (vectorLibrary.IsMatrixType(expression.Left.Type))
            {
                if (!IsFloatingPoint(GetElementType(expression.Right.Type))) throw new NotSupportedException("Matrix by scalar multiplication is only supported for floating point types.");

                if (vectorLibrary.IsVectorType(expression.Right.Type))
                    multiplicationOp = Op.OpMatrixTimesVector;
                else if (vectorLibrary.IsMatrixType(expression.Right.Type))
                    multiplicationOp = Op.OpMatrixTimesMatrix;
                else
                    multiplicationOp = Op.OpMatrixTimesScalar;
            }
            else
            {
                multiplicationOp = SelectByType(expression.Type, Op.OpFMul, Op.OpIMul);
            }

            return VisitBinary(expression, multiplicationOp);
        }

        [NodeType(ExpressionType.Modulo)]
        private ResultId VisitModulo(BinaryExpression expression)
        {
            var moduloOp = SelectByType(expression.Type, Op.OpFMod, Op.OpSMod, Op.OpUMod);

            return VisitBinary(expression, moduloOp);
        }

        [NodeType(ExpressionType.Divide)]
        private ResultId VisitDivide(BinaryExpression expression)
        {
            var divisionOp = SelectByType(expression.Type, Op.OpFDiv, Op.OpSDiv, Op.OpUDiv);

            return VisitBinary(expression, divisionOp);
        }

        private ResultId VisitUnary(UnaryExpression expression, Op unaryOp)
        {
            var resultTypeId = Visit(Expression.Constant(expression.Type));

            var operand = Visit(expression.Operand);
            var result = file.GetNextResultId();

            file.AddFunctionStatement(result, unaryOp, resultTypeId, operand);

            return result;
        }

        private ResultId VisitBinary(BinaryExpression expression, Op binaryOp)
        {
            var resultTypeId = Visit(Expression.Constant(expression.Type));

            var left = Visit(expression.Left);
            var right = Visit(expression.Right);

            if (vectorLibrary.IsVectorType(expression.Left.Type) && !vectorLibrary.IsVectorType(expression.Right.Type))
            {
                var length = vectorLibrary.GetVectorLength(expression.Left.Type);

                var resultType = Visit(Expression.Constant(expression.Left.Type));

                var statement = new SpirvStatement(Op.OpCompositeConstruct, new object[]
                {
                    resultType
                }.Concat(Enumerable.Repeat<object>(right, length)).ToArray());
                right = file.GetNextResultId();

                file.AddFunctionStatement(right, statement);
            }

            var result = file.GetNextResultId();

            file.AddFunctionStatement(result, binaryOp, resultTypeId, left, right);

            return result;
        }

        [NodeType(ExpressionType.MemberAccess)]
        private ResultId VisitMemberAccess(MemberExpression expression)
        {
            if (expression.Expression is QuerySourceReferenceExpression)
            {
                var fieldInfo = (FieldInfo)expression.Member;

                return GetInputId(fieldInfo);
            }
            var targetType = expression.Expression.Type;

            if (vectorLibrary.IsVectorType(targetType))
            {
                GetMemberData(expression, out var name, out var type);

                var fieldIndices = vectorLibrary.GetSwizzle(type, name);

                if (fieldIndices.Count() == 1)
                {
                    var targetId = Visit(expression.Expression);

                    var typeId = Visit(Expression.Constant(type));

                    var accessId = file.GetNextResultId();

                    file.AddFunctionStatement(accessId, Op.OpCompositeExtract, typeId, targetId, fieldIndices.Single());

                    return accessId;
                }
                else
                {
                    var targetId = Visit(expression.Expression);

                    var typeId = Visit(Expression.Constant(type));

                    var elementType = Visit(Expression.Constant(vectorLibrary.GetVectorElementType(type)));

                    var componentIds = fieldIndices.Select(index =>
                    {
                        var accessId = file.GetNextResultId();

                        file.AddFunctionStatement(accessId, Op.OpCompositeExtract, elementType, targetId, index);

                        return accessId;
                    }).ToArray();

                    var compositeId = file.GetNextResultId();

                    file.AddFunctionStatement(compositeId, Op.OpCompositeConstruct, new[]
                    {
                        typeId
                    }.Concat(componentIds).Cast<object>().ToArray());

                    return compositeId;
                }
            }
            throw new NotImplementedException("Member access is only implemented for vector types.");
        }

        private static void GetMemberData(MemberExpression expression, out string name, out Type type)
        {
            name = expression.Member.Name;

            switch (expression.Member.MemberType)
            {
                case MemberTypes.Field:
                    type = ((FieldInfo)expression.Member).FieldType;
                    break;
                case MemberTypes.Property:
                    type = ((PropertyInfo)expression.Member).PropertyType;
                    break;
                default:
                    throw new NotSupportedException();
            }
        }

        private ResultId GetInputId(FieldInfo fieldInfo)
        {
            var typeId = Visit(Expression.Constant(fieldInfo.FieldType));

            if (inputMappings.ContainsKey(fieldInfo))
            {
                var fieldId = inputMappings[fieldInfo];

                var resultId = file.GetNextResultId();

                file.AddFunctionStatement(resultId, Op.OpLoad, typeId, fieldId);

                return resultId;
            }
            else
            {
                var pointerTypeId = Visit(Expression.Constant(typeof(UniformPointer<>).MakeGenericType(fieldInfo.FieldType)));

                var binding = bindingMappings[fieldInfo];

                var accessId = file.GetNextResultId();

                file.AddFunctionStatement(accessId, Op.OpAccessChain, pointerTypeId, binding.Item1, Visit(Expression.Constant(binding.Item2)));

                var resultId = file.GetNextResultId();

                file.AddFunctionStatement(resultId, Op.OpLoad, typeId, accessId);

                return resultId;
            }
        }

        [NodeType(ExpressionType.New)]
        private ResultId VisitNew(NewExpression expression)
        {
            SpirvStatement statement;

            if (vectorLibrary.IsVectorType(expression.Type))
            {
                var operands = new[]
                    {
                        Visit(Expression.Constant(expression.Type))
                    }
                    .Concat(ExpandNewArguments(expression.Arguments));

                statement = new SpirvStatement(Op.OpCompositeConstruct, operands.Cast<object>().ToArray());
            }
            else
            {
                throw new NotImplementedException("New expressions are only implemented for vector types.");
            }

            var resultId = file.GetNextResultId();

            file.AddFunctionStatement(resultId, statement);

            return resultId;
        }

        private IEnumerable<ResultId> ExpandNewArguments(IEnumerable<Expression> arguments)
        {
            foreach (var argument in arguments)
            {
                var argumentId = Visit(argument);

                if (vectorLibrary.IsVectorType(argument.Type))
                {
                    var typeId = Visit(Expression.Constant(vectorLibrary.GetVectorElementType(argument.Type)));

                    for (var index = 0; index < vectorLibrary.GetVectorLength(argument.Type); index++)
                    {
                        var fieldId = file.GetNextResultId();

                        file.AddFunctionStatement(fieldId, Op.OpCompositeExtract, typeId, argumentId, index);

                        yield return fieldId;
                    }
                }
                else
                {
                    yield return argumentId;
                }
            }
        }

        [NodeType(ExpressionType.Constant)]
        private ResultId VisitConstant(ConstantExpression expression)
        {
            SpirvStatement statement;

            if (vectorLibrary.IsVectorType(expression.Type))
            {
                var operands = new object[]
                    {
                        expression.Type
                    }
                    .Concat(((IEnumerable)expression.Value).OfType<object>())
                    .Select(x => (object)Visit(Expression.Constant(x)));

                statement = new SpirvStatement(Op.OpConstantComposite, operands.ToArray());
            }
            else if (typeof(Type).IsAssignableFrom(expression.Type))
            {
                statement = VisitTypeConstant(expression);
            }
            else
            {
                var typeOperand = Visit(Expression.Constant(expression.Type));
                statement = new SpirvStatement(Op.OpConstant, typeOperand, expression.Value);
            }

            if (!expressionResults.TryGetValue(statement, out var resultId))
            {
                resultId = file.GetNextResultId();

                expressionResults.Add(statement, resultId);

                file.AddGlobalStatement(resultId, statement);
            }

            return resultId;
        }

        private SpirvStatement VisitTypeConstant(ConstantExpression expression)
        {
            var value = (Type)expression.Value;

            if (vectorLibrary.IsMatrixType(value))
            {
                var rowType = vectorLibrary.GetMatrixRowType(value);
                var dimensions = vectorLibrary.GetMatrixDimensions(value);

                var rowTypeId = Visit(Expression.Constant(rowType));

                return new SpirvStatement(Op.OpTypeMatrix, rowTypeId, dimensions[0]);
            }
            if (vectorLibrary.IsVectorType(value))
            {
                var elementType = vectorLibrary.GetVectorElementType(value);
                var length = vectorLibrary.GetVectorLength(value);

                var elementTypeId = Visit(Expression.Constant(elementType));

                return new SpirvStatement(Op.OpTypeVector, elementTypeId, length);
            }
            if (typeof(Delegate).IsAssignableFrom(value))
            {
                var returnType = value.GetMethod("Invoke").ReturnType;

                var returnTypeId = Visit(Expression.Constant(returnType));

                if (value.GetMethod("Invoke").GetParameters().Length > 0) throw new NotImplementedException();

                return new SpirvStatement(Op.OpTypeFunction, returnTypeId);
            }
            if (value.BaseType.IsGenericType && value.BaseType.GetGenericTypeDefinition() == typeof(Pointer<>))
            {
                var storage = (StorageClass)value.GetProperty("Storage").GetValue(null);
                var typeId = Visit(Expression.Constant(value.GetGenericArguments()[0]));

                return new SpirvStatement(Op.OpTypePointer, storage, typeId);
            }
            if (IsTupleType(value))
            {
                var fieldTypes = value.GetGenericArguments();

                var fieldTypeIds = fieldTypes.Select(x => (object)Visit(Expression.Constant(x))).ToArray();

                return new SpirvStatement(Op.OpTypeStruct, fieldTypeIds);
            }
            if (primitiveTypeMapping.TryGetValue(value, out var mapping)) return new SpirvStatement(mapping.TypeOp, mapping.Operands.Cast<object>().ToArray());
            if (value.IsValueType)
            {
                var fieldTypeIds = value.GetFieldsByOffset().Select(x => (object)Visit(Expression.Constant(x.FieldType))).ToArray();

                return new SpirvStatement(Op.OpTypeStruct, fieldTypeIds);
            }
            if (IsSampler(value))
            {
                var imageTypeId = Visit(Expression.Constant(typeof(ImageType2d<>).MakeGenericType(value.GetGenericArguments()[0])));

                return new SpirvStatement(Op.OpTypeSampledImage, imageTypeId);
            }
            if (IsImage(value))
            {
                var pixelTypeId = Visit(Expression.Constant(vectorLibrary.GetVectorElementType(value.GetGenericArguments()[0])));

                return new SpirvStatement(Op.OpTypeImage, pixelTypeId, Dim.Dim2D, 0, 0, 0, 1, ImageFormat.Unknown);
            }
            throw new NotImplementedException($"Constants of type {value} are not implemented.");
        }

        private static bool IsSampler(Type type)
        {
            return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Sampler2d<,>);
        }

        private static bool IsImage(Type type)
        {
            return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(ImageType2d<>);
        }

        private Op SelectByType(Type type, Op floatingPointOp, Op integerOp)
        {
            return SelectByType(type, floatingPointOp, integerOp, integerOp);
        }

        private Op SelectByType(Type type, Op floatingPointOp, Op signedIntegerOp, Op unsignedIntegerOp)
        {
            type = GetElementType(type);

            if (IsFloatingPoint(type))
                return floatingPointOp;
            if (IsSignedInteger(type))
                return signedIntegerOp;
            if (IsUnsignedInteger(type))
                return unsignedIntegerOp;
            throw new NotSupportedException($"Operations of type {type} are not supported.");
        }

        private static bool IsFloatingPoint(Type type)
        {
            return type == typeof(float) || type == typeof(double);
        }

        private static bool IsInteger(Type type)
        {
            return IsSignedInteger(type) || IsUnsignedInteger(type);
        }

        private static bool IsSignedInteger(Type type)
        {
            return type == typeof(sbyte)
                   || type == typeof(short)
                   || type == typeof(int)
                   || type == typeof(long);
        }

        private static bool IsUnsignedInteger(Type type)
        {
            return type == typeof(byte)
                   || type == typeof(ushort)
                   || type == typeof(uint)
                   || type == typeof(ulong);
        }

        private bool IsTupleType(Type value)
        {
            return value.GetInterfaces().Any(x => x.Name == "ITuple");
        }

        private Type GetElementType(Type type)
        {
            if (type.IsPrimitive)
                return type;
            if (vectorLibrary.IsVectorType(type))
                return vectorLibrary.GetVectorElementType(type);
            if (vectorLibrary.IsMatrixType(type))
                return typeof(float);
            throw new NotSupportedException($"Type {type} is not supported for this expression.");
        }

        private class NodeTypeAttribute
            : Attribute
        {
            public NodeTypeAttribute(ExpressionType nodeType)
            {
                NodeType = nodeType;
            }

            public ExpressionType NodeType
            {
                get;
            }
        }
    }
}