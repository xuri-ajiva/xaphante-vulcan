using System;

namespace SharpVk.Emit
{
    public class SwitchCaseBuilder
        : BlockBuilder
    {
        public SwitchCaseBuilder(IndentedTextWriter writer)
            : base(writer)
        {
        }

        public void EmitCase(Action<ExpressionBuilder> value, Action<CodeBlockBuilder> caseBlock)
        {
            writer.Write("case ");
            value(new ExpressionBuilder(writer.GetSubWriter()));
            writer.WriteLine(":");
            using (var caseBuilder = new CodeBlockBuilder(writer.GetSubWriter(), false))
            {
                caseBlock(caseBuilder);
            }
        }
    }
}