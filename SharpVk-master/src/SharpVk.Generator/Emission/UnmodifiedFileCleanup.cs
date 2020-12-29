using SharpVk.Generator.Pipeline;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SharpVk.Generator.Emission
{
    public class UnmodifiedFileCleanup
        : ICleanupWorker
    {
        private readonly FileBuilderFactory fileBuilder;

        public UnmodifiedFileCleanup(FileBuilderFactory fileBuilder)
        {
            this.fileBuilder = fileBuilder;
        }

        public void Execute()
        {
            var folderPaths = new Stack<string>();

            folderPaths.Push("..\\..\\..\\..\\SharpVk");

            while (folderPaths.Any())
            {
                var folderPath = folderPaths.Pop();

                foreach (var subPath in Directory.EnumerateDirectories(folderPath))
                {
                    folderPaths.Push(subPath);
                }

                foreach (var file in Directory.EnumerateFiles(folderPath, "*.gen.cs"))
                {
                    if (!fileBuilder.ModifiedFiles.Contains(file))
                    {
                        File.Delete(file);
                    }
                }
            }
        }
    }
}
