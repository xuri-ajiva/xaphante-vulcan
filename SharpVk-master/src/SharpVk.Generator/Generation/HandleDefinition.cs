using System.Collections.Generic;

namespace SharpVk.Generator.Generation
{
    public class HandleDefinition
    {
        public string Name;
        public string Parent;
        public string[] Namespace;
        public string[] ParentNamespace;
        public List<string> Comment;
        public bool IsDispatch;
        public string CommandCacheType;
        public List<MethodDefinition> Commands;
        public List<string> Interfaces;
    }
}
