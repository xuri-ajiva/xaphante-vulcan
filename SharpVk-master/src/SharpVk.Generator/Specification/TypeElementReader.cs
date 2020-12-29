using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Pipeline;
using SharpVk.Generator.Rules;
using SharpVk.Generator.Specification.Elements;
using SharpVk.Generator.Specification.Rules;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Specification
{
    public class TypeElementReader
        : IWorker
    {
        private readonly IVkXmlCache xmlCache;
        private readonly NameParser nameParser;
        private readonly IEnumerable<ITypeExtensionRule> typeExtensions;

        public TypeElementReader(IVkXmlCache xmlCache, NameParser nameParser, IEnumerable<ITypeExtensionRule> typeExtensions)
        {
            this.xmlCache = xmlCache;
            this.nameParser = nameParser;
            this.typeExtensions = typeExtensions;
        }

        public void Execute(IServiceCollection target)
        {
            foreach (var vkType in this.xmlCache.GetVkXml().Element("registry").Element("types").Elements("type"))
            {
                string name = vkType.Attribute("name")?.Value ?? vkType.Element("name").Value;
                Enum.TryParse(vkType.Attribute("category")?.Value, out TypeCategory category);
                string requires = vkType.Attribute("requires")?.Value;
                string parent = vkType.Attribute("parent")?.Value;
                var extends = vkType.Attribute("structextends")?.Value?.Split(',')?.Select(x => x.Trim())?.ToList();
                string alias = vkType.Attribute("alias")?.Value;
                bool.TryParse(vkType.Attribute("returnedonly")?.Value, out bool isReturnedOnly);
                bool isTypePointer = false;

                if (category == TypeCategory.define && !(vkType.DescendantNodes().First().ToString().Contains("#define")))
                {
                    category = TypeCategory.basetype;
                }

                string type = vkType.Element("type")?.Value;

                if (type == "VK_MAKE_VERSION")
                {
                    type += vkType.Element("type").NextNode.ToString();
                }

                if (parent != null)
                {
                    parent = parent.Split(',').First();

                    if (name == "VkSwapchainKHR")
                    {
                        parent = "VkDevice";
                    }
                }

                var newType = new TypeElement
                {
                    VkName = name,
                    Category = category,
                    Requires = requires,
                    Parent = parent,
                    IsReturnedOnly = isReturnedOnly,
                    Type = type,
                    IsTypePointer = isTypePointer,
                    Extends = extends,
                    Alias = alias
                };

                if (!this.typeExtensions.ApplyFirst(vkType, newType, target))
                {
                    newType.NameParts = new[] { name };
                    newType.ExtensionNamespace = null;
                }

                target.AddSingleton(newType);
            }
        }
    }
}
