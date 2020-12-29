using SharpVk.Generator.Collation;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Generation
{
    public class NameLookup
    {
        private readonly Dictionary<string, string> nameMapping;
        private readonly Dictionary<string, TypeDeclaration> typeData;
        private readonly NamespaceMap namespaceMap;

        public NameLookup(IEnumerable<TypeNameMapping> nameMappings, Dictionary<string, TypeDeclaration> typeData, NamespaceMap namespaceMap)
        {
            this.nameMapping = nameMappings.GroupBy(x => x.VkName)
                                            .Select(x => x.OrderByDescending(y => y.Priority).First())
                                            .ToDictionary(x => x.VkName, x =>
                                            {
                                                var namespaces = namespaceMap.Map(x.Extension).Append(x.OutputName);

                                                return string.Join(".", namespaces);
                                            });
            this.typeData = typeData;
            this.namespaceMap = namespaceMap;
        }

        public string Lookup(string vkName)
        {
            return this.nameMapping[vkName];
        }

        public string Lookup(TypeReference type, bool isInterop, bool includePointers = true)
        {
            TypePattern pattern = typeData[type.VkName].Pattern;

            if (isInterop && pattern == TypePattern.Delegate)
            {
                return "IntPtr";
            }

            if (!isInterop && type.VkName == "VkBool32")
            {
                return "bool";
            }

            var baseName = this.nameMapping[type.VkName];

            if (pattern != TypePattern.Primitive)
            {
                if (isInterop && pattern != TypePattern.Union && typeData[type.VkName].RequiresMarshalling)
                {
                    baseName = "Interop." + baseName;
                }

                baseName = "SharpVk." + baseName;
            }

            if (isInterop && includePointers)
            {
                baseName += new string('*', type.PointerType.GetPointerCount());
            }

            return baseName;
        }
    }
}
