namespace SharpVk.Generator.Generation.Marshalling
{
    public class ParsedExpressionEqualityCheck
        : ILenExpressionVisitor<EqualityCheckResult>
    {
        public void Visit(LenExpressionReference reference, EqualityCheckResult state)
        {
            state.AreEqual = state.Other is LenExpressionReference otherReference
                                && Check(reference.LeftOperand, otherReference.LeftOperand)
                                && Check(reference.RightOperand, otherReference.RightOperand);
        }

        public void Visit(LenExpressionToken token, EqualityCheckResult state)
        {
            state.AreEqual = state.Other is LenExpressionToken otherToken
                                && token.Value == otherToken.Value;
        }

        public void Visit(LenExpressionLiteral literal, EqualityCheckResult state)
        {
            state.AreEqual = state.Other is LenExpressionLiteral otherLiteral
                                && literal.Value == otherLiteral.Value;
        }

        public void Visit(LenExpressionOperator @operator, EqualityCheckResult state)
        {
            state.AreEqual = state.Other is LenExpressionOperator otherOperator
                                && @operator.Operator == otherOperator.Operator
                                && Check(@operator.LeftOperand, otherOperator.LeftOperand)
                                && Check(@operator.RightOperand, otherOperator.RightOperand);
        }

        public bool Check(LenExpression left, LenExpression right)
        {
            var result = new EqualityCheckResult
            {
                Other = right
            };

            left.Visit(this, result);

            return result.AreEqual;
        }
    }

    public class EqualityCheckResult
    {
        public LenExpression Other;
        public bool AreEqual;
    }
}
