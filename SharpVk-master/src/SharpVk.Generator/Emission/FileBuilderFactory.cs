using SharpVk.Emit;
using System;
using System.Collections.Generic;
using System.IO;

namespace SharpVk.Generator.Emission
{
    public class FileBuilderFactory
    {
        private readonly List<string> modifiedFiles = new List<string>();

        public void Generate(string fileName, Action<FileBuilder> build)
        {
            this.Generate(fileName, null, build);
        }

        public void Generate(string filename, string subFolder, Action<FileBuilder> build)
        {
            string folderPath = "..\\..\\..\\..\\SharpVk";
            string fullFilename = $"{filename}.gen.cs";

            if (subFolder != null)
            {
                folderPath = Path.Combine(folderPath, subFolder);
            }

            using (var builder = new FileBuilder(folderPath, fullFilename))
            {
                builder.EmitComment($@"The MIT License (MIT)

Copyright (c) Andrew Armstrong/FacticiusVir {DateTime.UtcNow.Year}

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the ""Software""), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED ""AS IS"", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.");

                builder.EmitComment("This file was automatically generated and should not be edited directly.");

                build(builder);

                this.modifiedFiles.Add(builder.FilePath);
            }
        }

        public IEnumerable<string> ModifiedFiles => this.modifiedFiles;
    }
}
