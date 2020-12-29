using System;

namespace SharpVk.Emit
{
    public class BlockBuilder
        : IDisposable
    {
        private readonly bool hasBraces;
        protected readonly IndentedTextWriter writer;

        public BlockBuilder(IndentedTextWriter writer, bool hasBraces = true)
        {
            this.hasBraces = hasBraces;

            this.writer = writer;
            if (this.hasBraces) this.writer.WriteLine("{");
            this.writer.IncreaseIndent();
        }

        public void Dispose()
        {
            writer.DecreaseIndent();
            if (hasBraces) writer.WriteLine("}");
        }
    }
}