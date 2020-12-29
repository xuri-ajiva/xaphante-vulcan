using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Pipeline;
using SharpVk.Generator.Specification.Elements;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Specification
{
    public class EnumElementReader
        : IWorker
    {
        private readonly IVkXmlCache xmlCache;
        private readonly NameParser nameParser;

        public EnumElementReader(IVkXmlCache xmlCache, NameParser nameParser)
        {
            this.xmlCache = xmlCache;
            this.nameParser = nameParser;
        }

        public void Execute(IServiceCollection target)
        {
            var enums = new Dictionary<string, EnumElement>();

            foreach (var vkEnum in this.xmlCache.GetVkXml().Element("registry").Elements("enums"))
            {
                string name = vkEnum.Attribute("name").Value;
                string type = vkEnum.Attribute("type")?.Value;

                string extension = null;
                string[] nameParts = name == "API Constants"
                                        ? new[] { name }
                                        : this.nameParser.GetNameParts(name, out extension);

                var newEnum = new EnumElement
                {
                    VkName = name,
                    Type = type,
                    NameParts = nameParts,
                    ExtensionNamespace = extension
                };

                foreach (var vkField in vkEnum.Elements("enum"))
                {
                    string fieldName = vkField.Attribute("name").Value;
                    bool isBitmask = true;
                    string value = vkField.Attribute("bitpos")?.Value;
                    string comment = SimpleParser.NormaliseComment(vkField.Attribute("comment")?.Value);

                    if (value == null)
                    {
                        isBitmask = false;
                        value = vkField.Attribute("value")?.Value;

                        // Special case for mapping C "unsigned long long"
                        // (64-bit unsigned integer) to C# UInt64
                        if (value == "(~0ULL)")
                        {
                            value = "(~0UL)";
                        }

                        value = value?.Trim('(', ')');
                    }

                    IEnumerable<string> fieldNameParts = this.nameParser.ParseEnumField(fieldName, nameParts);

                    newEnum.Fields.Add(fieldName, new EnumField
                    {
                        VkName = fieldName,
                        NameParts = fieldNameParts.ToArray(),
                        IsBitmask = isBitmask,
                        Value = value,
                        Comment = comment != null ? new List<string> { comment } : null
                    });
                }

                enums.Add(name, newEnum);
            }

            var requireSets = this.xmlCache.GetVkXml()
                                            .Element("registry")
                                            .Elements("feature")
                                            .Concat(this.xmlCache.GetVkXml()
                                                                    .Element("registry")
                                                                    .Element("extensions")
                                                                    .Elements("extension"));

            foreach (var vkExtension in requireSets)
            {
                string extensionSuffix = null;

                if (vkExtension.Attribute("name") != null)
                {
                    string extensionName = vkExtension.Attribute("name").Value;

                    var extensionNameParts = extensionName.Split('_');

                    extensionSuffix = extensionNameParts[1].ToLower().FirstToUpper();
                }

                foreach (var vkExtensionEnum in vkExtension.Elements("require")
                                                            .SelectMany(x => x.Elements("enum"))
                                                            .Where(x => x.Attribute("extends") != null))
                {
                    string vkName = vkExtensionEnum.Attribute("name").Value;
                    var extendedEnum = enums[vkExtensionEnum.Attribute("extends").Value];

                    int? value = null;
                    bool isBitmask = false;

                    if (vkExtensionEnum.Attribute("offset") != null)
                    {
                        int offset = int.Parse(vkExtensionEnum.Attribute("offset").Value);

                        int extensionNumber = vkExtensionEnum.Attribute("extnumber") != null
                                                ? int.Parse(vkExtensionEnum.Attribute("extnumber").Value)
                                                : int.Parse(vkExtension.Attribute("number").Value);

                        value = 1000000000 + 1000 * (extensionNumber - 1) + offset;
                    }
                    else if (vkExtensionEnum.Attribute("bitpos") != null)
                    {
                        value = int.Parse(vkExtensionEnum.Attribute("bitpos").Value);
                        isBitmask = true;
                    }
                    else if (vkExtensionEnum.Attribute("value") != null)
                    {
                        value = int.Parse(vkExtensionEnum.Attribute("value").Value);
                    }

                    if (vkExtensionEnum.Attribute("dir")?.Value == "-")
                    {
                        value = -value;
                    }

                    var nameParts = this.nameParser.ParseEnumField(vkName, extendedEnum.NameParts);

                    extendedEnum.Fields[vkName] = new EnumField
                    {
                        VkName = vkName,
                        Value = value?.ToString(),
                        NameParts = nameParts.ToArray(),
                        IsBitmask = isBitmask,
                        ExtensionNamespace = extensionSuffix
                    };
                }
            }

            foreach (var element in enums.Values)
            {
                target.AddSingleton(element);
            }
        }
    }
}
