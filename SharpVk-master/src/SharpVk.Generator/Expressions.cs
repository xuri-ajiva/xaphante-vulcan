namespace SharpVk.Generator
{
    public class MemberLen
    {
        public LenExpression Value;
        public LenType Type;
    }

    public abstract class LenExpression
    {
        public abstract void Visit<T>(ILenExpressionVisitor<T> visitor, T state);
    }

    public class LenExpressionLiteral
        : LenExpression
    {
        public string Value;

        public override void Visit<T>(ILenExpressionVisitor<T> visitor, T state)
        {
            visitor.Visit(this, state);
        }

        public override string ToString()
        {
            return $"Literal: {Value}";
        }
    }

    public class LenExpressionToken
        : LenExpression
    {
        public string Value;

        public override void Visit<T>(ILenExpressionVisitor<T> visitor, T state)
        {
            visitor.Visit(this, state);
        }

        public override string ToString()
        {
            return $"Token: '{this.Value}'";
        }
    }

    public class LenExpressionReference
        : LenExpression
    {
        public LenExpression LeftOperand;
        public LenExpressionToken RightOperand;

        public override void Visit<T>(ILenExpressionVisitor<T> visitor, T state)
        {
            visitor.Visit(this, state);
        }
    }

    public class LenExpressionOperator
        : LenExpression
    {
        public LenOperatorType Operator;
        public LenExpression LeftOperand;
        public LenExpression RightOperand;

        public override void Visit<T>(ILenExpressionVisitor<T> visitor, T state)
        {
            visitor.Visit(this, state);
        }

        public override string ToString()
        {
            return $"Operator: {LeftOperand} {Operator} {RightOperand}";
        }
    }

    public enum LenOperatorType
    {
        Divide,
        Ceiling,
        Remainder
    }

    public interface ILenExpressionVisitor<T>
    {
        void Visit(LenExpressionReference reference, T state);

        void Visit(LenExpressionToken token, T state);

        void Visit(LenExpressionLiteral literal, T state);

        void Visit(LenExpressionOperator @operator, T state);
    }

    public enum LenType
    {
        Expression,
        NullTerminated
    }
}
