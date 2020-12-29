using SharpVk.Emit;
using SharpVk.Generator.Collation;
using System;
using System.Collections.Generic;
using System.Linq;

using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class ParsedExpressionBuilder
       : ILenExpressionVisitor<ParsedExpressionBuilder.ExpressionBuildState>
    {
        private readonly Dictionary<string, TypeDeclaration> typeData;

        public ParsedExpressionBuilder(Dictionary<string, TypeDeclaration> typeData)
        {
            this.typeData = typeData;
        }

        public void Visit(LenExpressionToken parsedExpressionToken, ExpressionBuildState state)
        {
            var member = state.Resolve(parsedExpressionToken.Value);

            //if (this.mapping != null && this.mapping.ContainsKey(name))
            //{
            //    name = this.mapping[name] + ".Length";
            //}

            state.Result = Variable(member.Name);
            state.ExpressionType = member.Type.VkName;
        }

        public void Visit(LenExpressionReference reference, ExpressionBuildState state)
        {
            var leftState = new ExpressionBuildState
            {
                Resolve = state.Resolve
            };

            reference.LeftOperand.Visit(this, leftState);

            var target = leftState.Result;

            var targetType = typeData[leftState.ExpressionType];

            var memberMappings = targetType.Members
                                        .Where(x => x.Dimensions != null)
                                        .ToDictionary(x => ((LenExpressionToken)x.Dimensions[0].Value).Value);

            var member = targetType.Members.Single(x => x.VkName == reference.RightOperand.Value);

            string memberName;

            bool takeLength = false;

            if (memberMappings.ContainsKey(member.VkName))
            {
                memberName = memberMappings[member.VkName].Name;

                takeLength = true;
            }
            else
            {
                memberName = member.Name;
            }

            bool isDecomposed = targetType.Name.EndsWith("Info");

            if (isDecomposed)
            {
                state.Result = Variable(memberName.FirstToLower());
            }
            else
            {
                state.Result = Member(target, memberName);
            }

            if (takeLength)
            {
                state.Result = StaticCall("Interop.HeapUtil", "GetLength", state.Result);
            }

            state.ExpressionType = member.Type.VkName;
        }

        public class ExpressionBuildState
        {
            public Action<ExpressionBuilder> Result;
            public string ExpressionType;
            public Func<string, ITypedDeclaration> Resolve;
        }

        public Action<ExpressionBuilder> Build(LenExpression value, Func<string, ITypedDeclaration> resolve)
        {
            var state = new ExpressionBuildState
            {
                Resolve = resolve
            };

            value.Visit(this, state);

            return state.Result;
        }

        public void Visit(LenExpressionLiteral literal, ExpressionBuildState state)
        {
            state.Result = Literal(int.Parse(literal.Value));
            state.ExpressionType = "int32";
        }

        public void Visit(LenExpressionOperator @operator, ExpressionBuildState state)
        {
            switch (@operator.Operator)
            {
                case LenOperatorType.Divide:
                    var left = Build(@operator.LeftOperand, state.Resolve);
                    var right = Build(@operator.RightOperand, state.Resolve);

                    state.Result = Divide(left, Cast("float", right));
                    break;
                case LenOperatorType.Ceiling:
                    var value = Build(@operator.LeftOperand, state.Resolve);

                    state.Result = StaticCall("Math", "Ceiling", Cast("float", value));
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}