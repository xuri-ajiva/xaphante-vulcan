using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Specification.Elements;
using System.Linq;
using System.Xml.Linq;

namespace SharpVk.Generator.Specification.Rules
{
    public class MemberTypeRule
        : ITypeExtensionRule
    {
        private readonly NameParser nameParser;

        public MemberTypeRule(NameParser nameParser)
        {
            this.nameParser = nameParser;
        }

        public bool Apply(XElement typeXml, TypeElement type, IServiceCollection target)
        {
            if (type.Category == TypeCategory.include || type.Category == TypeCategory.None || type.Category == TypeCategory.define)
            {
                return false;
            }

            type.NameParts = this.nameParser.GetNameParts(type.VkName, out type.ExtensionNamespace);

            foreach (var vkMember in typeXml.Elements("member"))
            {
                var nameElement = vkMember.Element("name");
                string vkName = nameElement.Value;
                string memberType = vkMember.Element("type").Value;
                bool.TryParse(vkMember.Attribute("optional")?.Value, out bool isOptional);
                bool.TryParse(vkMember.Attribute("noautovalidity")?.Value, out bool noAutoValidity);

                PointerType pointerType = PointerTypeUtil.GetFrom(nameElement.NodesBeforeSelf());

                var fixedLength = new FixedLengthDeclaration();

                if (nameElement.NodesAfterSelf().Any())
                {
                    string enumName = vkMember.Element("enum")?.Value;

                    if (enumName != null)
                    {
                        fixedLength.Value = enumName;
                        fixedLength.Type = FixedLengthType.EnumReference;
                    }
                    else if(nameElement.NextNode.NodeType == System.Xml.XmlNodeType.Text)
                    {
                        fixedLength.Value = SimpleParser.ParseFixedLength(nameElement.NextNode.ToString());
                        fixedLength.Type = FixedLengthType.IntegerLiteral;
                    }
                }
                else
                {
                    int fixedLengthIndex = vkName.IndexOf('[');

                    if (fixedLengthIndex >= 0)
                    {
                        string fixedLengthString = vkName.Substring(fixedLengthIndex);
                        vkName = vkName.Substring(0, fixedLengthIndex);

                        fixedLength.Value = SimpleParser.ParseFixedLength(fixedLengthString);
                        fixedLength.Type = FixedLengthType.IntegerLiteral;
                    }
                }

                var lenField = vkMember.Attribute("len");
                var dimensions = lenField != null
                                    ? SimpleParser.ParsedLenField(lenField.Value)
                                    : null;

                string[] memberNameParts = this.nameParser.ParseParamName(vkName, pointerType, out string memberExtension);

                string values = vkMember.Attribute("values")?.Value;

                var newMember = new MemberElement
                {
                    VkName = vkName,
                    Type = memberType,
                    IsOptional = isOptional,
                    NoAutoValidity = noAutoValidity,
                    FixedLength = fixedLength,
                    PointerType = pointerType,
                    NameParts = memberNameParts,
                    ExtensionNamespace = memberExtension,
                    Dimensions = dimensions,
                    Values = values
                };

                type.Members.Add(newMember);
            }

            return true;
        }
    }
}
