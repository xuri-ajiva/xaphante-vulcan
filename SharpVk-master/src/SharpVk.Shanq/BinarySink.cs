using System;
using System.IO;
using System.Linq;
using System.Text;

namespace SharpVk.Spirv
{
    public class BinarySink
        : ISpirvSink
    {
        private readonly BinaryWriter file;

        public BinarySink(Stream outputStream, int bound)
        {
            file = new BinaryWriter(outputStream);

            file.Write(0x07230203);
            file.Write(0x00010000);
            file.Write(0x00000000);
            file.Write(bound);
            file.Write(0x00000000);
        }

        public void AddStatement(ResultId? resultId, SpirvStatement statement)
        {
            //string fileLocation = this.file.BaseStream.Position.ToString().PadLeft(4, '0');

            //if (resultId.HasValue)
            //{
            //    Console.Write($"{fileLocation} {resultId.Value}".PadRight(9));
            //    Console.Write(" = ");
            //}
            //else
            //{
            //    Console.Write(fileLocation.PadRight(12));
            //}

            //Console.WriteLine(statement);

            var opCode = OpCode.Lookup[statement.Op];

            var arguments = statement.Operands.ToList();

            if (resultId.HasValue)
            {
                var resultIdOperandIndex = opCode.Operands.TakeWhile(x => x.Kind != OperandKind.IdResult).Count();

                arguments.Insert(resultIdOperandIndex, resultId.Value);
            }

            var wordCount = arguments.Select(x =>
            {
                if (x.GetType() == typeof(string))
                {
                    var byteCount = Encoding.UTF8.GetByteCount(x.ToString()) + 1;
                    var stringWordCount = byteCount / 4;

                    if (byteCount % 4 > 0) stringWordCount++;

                    return stringWordCount;
                }
                return 1;
            }).Aggregate(1, (x, y) => x + y);

            file.Write((wordCount << 16) | (int)statement.Op);
            foreach (var argument in arguments)
            {
                var argumentType = argument.GetType();
                if (argumentType == typeof(ResultId))
                {
                    file.Write(((ResultId)argument).Id);
                }
                else if (argumentType == typeof(string))
                {
                    var byteCount = Encoding.UTF8.GetByteCount(argument.ToString()) + 1;
                    var stringBytes = Encoding.UTF8.GetBytes(argument.ToString());

                    file.Write(stringBytes);
                    file.Write((byte)0);

                    for (var paddingByteIndex = 0; paddingByteIndex < 4 - byteCount % 4; paddingByteIndex++) file.Write((byte)0);
                }
                else if (argumentType == typeof(float))
                {
                    file.Write((float)argument);
                }
                else
                {
                    file.Write(Convert.ToInt32(argument));
                }
            }

            file.Flush();
        }
    }
}