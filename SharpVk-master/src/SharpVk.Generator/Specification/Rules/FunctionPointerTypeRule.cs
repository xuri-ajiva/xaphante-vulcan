using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Specification.Elements;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace SharpVk.Generator.Specification.Rules
{
    public class FunctionPointerTypeRule
        : ITypeExtensionRule
    {
        private readonly NameParser nameParser;

        public FunctionPointerTypeRule(NameParser nameParser)
        {
            this.nameParser = nameParser;
        }

        public bool Apply(XElement typeXml, TypeElement type, IServiceCollection target)
        {
            if (type.Category != TypeCategory.funcpointer)
            {
                return false;
            }

            string returnType = ((XText)typeXml.Nodes().First()).Value.Split(' ')[1];

            if (returnType.EndsWith("*"))
            {
                returnType = returnType.TrimEnd('*');

                type.IsTypePointer = true;
            }

            type.Type = returnType;
            
            type.NameParts = this.nameParser.ParseFunctionPointer(type.VkName, out type.ExtensionNamespace);

            var functionTail = typeXml.Element("name").NodesAfterSelf();

            foreach (var typeElement in functionTail.Where(x => x.NodeType == XmlNodeType.Element).Cast<XElement>())
            {
                string pre = ((XText)typeElement.PreviousNode).Value.Split(',').Last().Trim('(', ')', ';').TrimStart();
                string post = ((XText)typeElement.NextNode).Value.Split(',').First().Trim('(', ')', ';').TrimEnd();

                string paramName = new string(post.Reverse().TakeWhile(char.IsLetterOrDigit).Reverse().ToArray());
                string typeString = pre + "@" + (post.Substring(0, post.Length - paramName.Length).Trim());
                string paramType = typeElement.Value;
                PointerType pointerType = PointerTypeUtil.Map(typeString);
                
                var paramNameParts = this.nameParser.GetNameParts(paramName, out string paramExtension);

                type.Members.Add(new MemberElement
                {
                    VkName = paramName,
                    Type = paramType,
                    PointerType = pointerType,
                    NameParts = paramNameParts
                });
            }

            return true;
        }
    }
}
