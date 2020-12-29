using System;

namespace SharpVk.Emit
{
    public class MemberInitBuilder
    {
        private bool hasFirstBinding;
        private readonly IndentedTextWriter writer;

        public MemberInitBuilder(IndentedTextWriter writer)
        {
            this.writer = writer;
        }

        public void EmitMember(string memberName, Action<ExpressionBuilder> expression)
        {
            if (hasFirstBinding)
            {
                writer.WriteLine(",");
            }
            else
            {
                writer.WriteLine();

                hasFirstBinding = true;
            }

            writer.Write($"{memberName} = ");
            expression(new ExpressionBuilder(writer.GetSubWriter()));
        }
    }
}