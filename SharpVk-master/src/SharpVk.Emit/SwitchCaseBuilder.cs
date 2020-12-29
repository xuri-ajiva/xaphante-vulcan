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
            Writer.Write("case ");
            value(new ExpressionBuilder(Writer.GetSubWriter()));
            Writer.WriteLine(":");
            using (var caseBuilder = new CodeBlockBuilder(Writer.GetSubWriter(), false))
            {
                caseBlock(caseBuilder);
            }
        }
    }
}
