using Sprache;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Specification
{
    public class NameParser
    {
        private static readonly Parser<string> firstPart = from head in Parse.Letter
                                                           from tail in Parse.Lower.Many()
                                                           select new string(new[] { head }.Concat(tail).ToArray()).ToLower();

        private static readonly Parser<string> namePart = from head in Parse.Upper
                                                          from tail in Parse.Lower.Many()
                                                          select new string(new[] { head }.Concat(tail).ToArray()).ToLower();

        private static readonly Parser<string> numberPart = Parse.Digit
                                                        .AtLeastOnce()
                                                        .Text();

        private static readonly Parser<string> keywordPart = Parse.String("2D")
                                                                    .Or(Parse.String("3D"))
                                                                    .Or(Parse.String("ETC2"))
                                                                    .Or(Parse.String("ASTC_LDR"))
                                                                    .Or(Parse.String("BC"))
                                                                    .Or(Parse.String("ID"))
                                                                    .Or(Parse.String("UUID"))
                                                                    .Or(Parse.String("RandR"))
                                                                    .Or(Parse.String("SMPTE2086"))
                                                                    .Text();

        private static readonly Parser<string> alphanumericPair = from head in Parse.Letter
                                                                  from tail in Parse.Digit.AtLeastOnce()
                                                                  select new string(new[] { head }.Concat(tail).ToArray()).ToLower();

        private static readonly Parser<IEnumerable<string>> alphanumericSequence = alphanumericPair.AtLeastOnce();

        private static readonly Parser<IEnumerable<string>> nameParts = from first in firstPart
                                                                        from parts in keywordPart
                                                                                        .Or(numberPart)
                                                                                        .Or(namePart)
                                                                                        .Many()
                                                                                        .End()
                                                                        select new[] { first }.Concat(parts);

        private readonly ExtensionSet extensions;

        public NameParser(ExtensionSet extensions)
        {
            this.extensions = extensions;
        }

        public string[] ParseFunctionPointer(string vkName, out string extension)
        {
            return GetNameParts(vkName.Substring(4), out extension);
        }

        public string[] ParseParamName(string vkName, PointerType pointerType, out string extension)
        {
            int pointerCount = pointerType.GetPointerCount();

            while (pointerCount > 0 && vkName.StartsWith("p"))
            {
                vkName = vkName.Substring(1);

                pointerCount--;
            }

            if (vkName.Contains("_"))
            {
                extension = null;

                return SplitSnakeCase(vkName);
            }
            else
            {
                return GetNameParts(vkName, out extension);
            }
        }

        public IEnumerable<string> ParseEnumField(string fieldName, string[] enumNameParts)
        {
            IEnumerable<string> fieldNameParts = SplitSnakeCase(fieldName);

            if (fieldNameParts.First() == "vk")
            {
                fieldNameParts = fieldNameParts.Skip(1);
            }

            int prefixSkipCount = 0;

            while (nameParts != null
                && prefixSkipCount < enumNameParts.Length
                && enumNameParts[prefixSkipCount] == fieldNameParts.ElementAt(prefixSkipCount))
            {
                prefixSkipCount++;
            }

            fieldNameParts = fieldNameParts.Skip(prefixSkipCount);

            if (this.extensions.KnownExtensions.Contains(fieldNameParts.Last()))
            {
                fieldNameParts = fieldNameParts.Take(fieldNameParts.Count() - 1);
            }

            var fieldNameSubParts = fieldNameParts.SelectMany(x =>
            {
                var parseResult = alphanumericSequence.TryParse(x);

                if (parseResult.WasSuccessful)
                {
                    return parseResult.Value;
                }
                else
                {
                    if (x.EndsWith("pack16") && x.Length > 6)
                    {
                        return new[] { x.Substring(0, x.Length - 6), "pack16" };
                    }
                    else
                    {
                        switch (x)
                        {
                            case "uint":
                                return new[] { "u", "int" };
                            case "unorm":
                                return new[] { "u", "norm" };
                            case "uscaled":
                                return new[] { "u", "scaled" };
                            case "sint":
                                return new[] { "s", "int" };
                            case "snorm":
                                return new[] { "s", "norm" };
                            case "sscaled":
                                return new[] { "s", "scaled" };
                            case "ufloat":
                                return new[] { "u", "float" };
                            case "sfloat":
                                return new[] { "s", "float" };
                            default:
                                return new[] { x };
                        }
                    }
                }
            });

            return fieldNameSubParts;
        }

        private static string[] SplitSnakeCase(string value)
        {
            return value.Split('_').Select(x => x.ToLower()).ToArray();
        }

        public string[] GetNameParts(string vkName, out string extension)
        {
            if (vkName.ToUpper().StartsWith("VK"))
            {
                vkName = vkName.Substring(2);
            }

            extension = this.extensions
                                .KnownExtensions
                                .FirstOrDefault(x => vkName.EndsWith(x.ToUpper()));

            if (extension != null)
            {
                vkName = vkName.Substring(0, vkName.Length - extension.Length);
            }

            return nameParts.Parse(vkName).ToArray();
        }
    }
}
