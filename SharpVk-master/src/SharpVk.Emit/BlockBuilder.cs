using System;

namespace SharpVk.Emit
{
    public class BlockBuilder
        : IDisposable
    {
        private readonly bool hasBraces;
        protected readonly IndentedTextWriter Writer;

        public BlockBuilder(IndentedTextWriter writer, bool hasBraces = true)
        {
            this.hasBraces = hasBraces;

            this.Writer = writer;
            if (this.hasBraces) this.Writer.WriteLine("{");
            this.Writer.IncreaseIndent();
        }

        public void Dispose()
        {
            Writer.DecreaseIndent();
            if (hasBraces) Writer.WriteLine("}");
        }
    }
}
