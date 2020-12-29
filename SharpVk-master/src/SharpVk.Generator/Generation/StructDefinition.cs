using System.Collections.Generic;

namespace SharpVk.Generator.Generation
{
    public class StructDefinition
    {
        public string Name;
        public string[] Namespace;
        public List<string> Comment;
        public bool IsUnsafe;
        public bool IsClass;
        public bool IsStatic;
        public bool HasZero;
        public MethodDefinition Constructor;
        public List<MethodDefinition> Methods;
        public List<MemberDefinition> Fields;
        public List<MemberDefinition> Properties;
    }
}
