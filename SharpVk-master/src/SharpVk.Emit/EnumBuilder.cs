using System;
using System.Collections.Generic;

namespace SharpVk.Emit
{
    public class EnumBuilder
        : BlockBuilder
    {
        private bool hasFirstMember;

        public EnumBuilder(IndentedTextWriter writer)
            : base(writer)
        {
        }

        public void EmitField(string name,
            Action<ExpressionBuilder> initialiser = null,
            IEnumerable<string> summary = null,
            Action<DocBuilder> docs = null,
            IEnumerable<string> attributes = null)
        {
            if (hasFirstMember)
                writer.WriteLine();
            else
                hasFirstMember = true;

            var docBuilder = new DocBuilder(writer.GetSubWriter(), summary);

            docs?.Invoke(docBuilder);

            writer.Write($"{name}");
            if (initialiser != null)
            {
                writer.Write(" = ");
                initialiser(new ExpressionBuilder(writer.GetSubWriter()));
            }
            writer.WriteLine(", ");
        }
    }
}