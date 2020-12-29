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
                Writer.WriteLine();
            else
                hasFirstMember = true;

            var docBuilder = new DocBuilder(Writer.GetSubWriter(), summary);

            docs?.Invoke(docBuilder);

            Writer.Write($"{name}");
            if (initialiser != null)
            {
                Writer.Write(" = ");
                initialiser(new ExpressionBuilder(Writer.GetSubWriter()));
            }
            Writer.WriteLine(", ");
        }
    }
}
