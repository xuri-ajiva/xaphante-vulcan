using System.Collections.Generic;

namespace SharpVk.Generator.Generation
{
    public class DelegateDefinition
    {
        public string Name;
        public string[] Namespace;
        public string ReturnType;
        public bool IsUnsafe;
        public List<string> Comment;
        public List<ParamDefinition> Parameters;
        public string VkName;
        public string LookupScope;
    }
}
