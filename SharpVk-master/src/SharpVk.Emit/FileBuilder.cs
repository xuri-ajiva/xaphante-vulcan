using System;
using System.IO;

namespace SharpVk.Emit
{
    public class FileBuilder
        : IDisposable
    {
        private readonly IndentedTextWriter fileWriter;

        private bool hasFirstParagraph;
        private bool previousParagraphWasNamespace;

        public FileBuilder(string folderPath, string fileName)
        {
            if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);

            FilePath = Path.Combine(folderPath, fileName);

            if (File.Exists(FilePath))
                try
                {
                    File.Delete(FilePath);
                }
                catch
                {
                    //HACK Getting intermittent file-lock errors
                }

            fileWriter = new IndentedTextWriter(new StreamWriter(File.OpenWrite(FilePath)));
        }

        public string FilePath { get; }

        public void Dispose()
        {
            fileWriter.Flush();
            fileWriter.Dispose();
        }

        public void EmitComment(string comment)
        {
            EmitParagraphSpacing();

            foreach (var line in comment.Split('\n')) fileWriter.WriteLine("// " + line.Trim());
        }

        public void EmitUsing(string @namespace)
        {
            EmitParagraphSpacing(true);

            fileWriter.WriteLine($"using {@namespace};");
        }

        public void EmitNamespace(string name, Action<NamespaceBuilder> @namespace)
        {
            EmitParagraphSpacing();

            fileWriter.WriteLine($"namespace {name}");
            using (var builder = new NamespaceBuilder(fileWriter.GetSubWriter()))
            {
                @namespace(builder);
            }
        }

        private void EmitParagraphSpacing(bool isNamespace = false)
        {
            if (hasFirstParagraph && !(isNamespace && previousParagraphWasNamespace))
                fileWriter.WriteLine();
            else
                hasFirstParagraph = true;

            previousParagraphWasNamespace = isNamespace;
        }
    }
}