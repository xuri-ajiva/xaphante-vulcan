using System.Collections.Generic;

namespace SharpVk.Generator.Specification.Elements
{
    public class SpecElement
    {
        public string VkName;
        public string Type;
        public string[] NameParts;
        public string ExtensionNamespace;
        public List<string> Comment;
    }
}
