using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Emit
{
    public class DocBuilder
    {
        private readonly IndentedTextWriter writer;

        public DocBuilder(IndentedTextWriter writer, IEnumerable<string> summary)
        {
            this.writer = writer;

            this.writer.WriteLine("/// <summary>");
            if (summary == null || !summary.Any())
                this.writer.WriteLine("/// ");
            else if (summary.Count() == 1)
                EmitParagraph(summary.Single());
            else
                foreach (var paragraph in summary)
                {
                    this.writer.WriteLine("/// <para>");
                    EmitParagraph(paragraph);
                    this.writer.WriteLine("/// </para>");
                }
            this.writer.WriteLine("/// </summary>");
        }

        private void EmitParagraph(string paragraph)
        {
            var previousChar = ' ';
            var charList = new List<char>();

            foreach (var character in paragraph)
            {
                if (!char.IsWhiteSpace(character) || !char.IsWhiteSpace(previousChar)) charList.Add(character);

                previousChar = character;
            }

            var charArray = charList.ToArray();

            var offset = 0;
            var count = 0;
            var lastSafeCount = 0;

            var availableCharacters = 80 - (4 + writer.IndentCharacters);

            while (offset + count < charArray.Length)
            {
                while (offset + count < charArray.Length && !char.IsWhiteSpace(charArray[offset + count])) count++;

                if (count < availableCharacters)
                {
                    lastSafeCount = count;

                    count++;
                }
                else
                {
                    var displayCount = count;

                    if (lastSafeCount > 0) displayCount = lastSafeCount;

                    writer.Write("/// ");
                    writer.WriteLine(charArray, offset, displayCount);

                    offset += displayCount + 1;
                    count -= displayCount;
                    lastSafeCount = 0;
                }

                if (offset + count >= charArray.Length && offset < charArray.Length)
                {
                    writer.Write("/// ");
                    writer.WriteLine(charArray, offset, charArray.Length - offset);
                }
            }
        }

        public void EmitParam(string paramName, string description)
        {
            writer.WriteLine($"/// <param name=\"{paramName}\">");
            EmitParagraph(description);
            writer.WriteLine("/// </param>");
        }
    }
}