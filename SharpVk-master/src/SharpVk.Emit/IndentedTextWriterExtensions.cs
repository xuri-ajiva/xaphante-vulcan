using System;

namespace SharpVk.Emit
{
    public static class IndentedTextWriterExtensions
    {
        public static void WriteCodeBlock(this IndentedTextWriter writer, Action<CodeBlockBuilder> codeBlockAction, bool hasBraces = true, bool singleStatement = false)
        {
            using (var builder = new CodeBlockBuilder(writer.GetSubWriter(!singleStatement), hasBraces, !singleStatement))
            {
                codeBlockAction(builder);
            }
        }
    }
}