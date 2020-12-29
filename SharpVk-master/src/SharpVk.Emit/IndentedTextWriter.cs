using System.IO;
using System.Linq;
using System.Text;

namespace SharpVk.Emit
{
    public class IndentedTextWriter
        : TextWriter
    {
        private readonly TextWriter baseWriter;
        private bool beginningOfLine;
        private int indent;

        public IndentedTextWriter(TextWriter baseWriter, bool beginningOfLine = true)
            : base(baseWriter.FormatProvider)
        {
            this.baseWriter = baseWriter;
            this.beginningOfLine = beginningOfLine;
            indent = 0;
        }

        public int IndentCharacters
        {
            get
            {
                var result = indent * 4;

                var baseIndentWriter = baseWriter as IndentedTextWriter;

                if (baseIndentWriter != null) result += baseIndentWriter.IndentCharacters;

                return result;
            }
        }

        public override Encoding Encoding => baseWriter.Encoding;

        public void IncreaseIndent()
        {
            indent++;
        }

        public void DecreaseIndent()
        {
            indent--;
        }

        public override void Write(char value)
        {
            if (beginningOfLine)
            {
                baseWriter.Write(Enumerable.Repeat(' ', indent * 4).ToArray());
                beginningOfLine = false;
            }

            baseWriter.Write(value);

            if (value == '\n') beginningOfLine = true;
        }

        public IndentedTextWriter GetSubWriter(bool beginningOfLine = true)
        {
            return new IndentedTextWriter(this, beginningOfLine);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                baseWriter.Flush();
                baseWriter.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}