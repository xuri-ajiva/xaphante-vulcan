using System;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class ParsedExpressionTokenCheck
        : ILenExpressionVisitor<TokenCheckResult>
    {
        public void Visit(LenExpressionReference reference, TokenCheckResult state)
        {
            reference.LeftOperand.Visit(this, state);
            reference.RightOperand.Visit(this, state);
        }

        public void Visit(LenExpressionToken token, TokenCheckResult state)
        {
            if (token.Value == state.Token)
            {
                state.Found = true;
            }
        }

        public void Visit(LenExpressionLiteral literal, TokenCheckResult state)
        {
            return;
        }

        public void Visit(LenExpressionOperator @operator, TokenCheckResult state)
        {
            @operator.LeftOperand.Visit(this, state);
            @operator.RightOperand?.Visit(this, state);
        }

        public bool Check(LenExpression expression, string token)
        {
            var result = new TokenCheckResult
            {
                Token = token
            };

            expression.Visit(this, result);

            return result.Found;
        }
    }

    public class TokenCheckResult
    {
        public string Token;
        public bool Found;
    }
}
