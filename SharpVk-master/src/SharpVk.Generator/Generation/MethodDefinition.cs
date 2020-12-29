using SharpVk.Emit;
using System.Collections.Generic;

namespace SharpVk.Generator.Generation
{
    public class MethodDefinition
    {
        public string ReturnType;
        public string Name;
        public List<string> Comment;
        public bool IsPublic;
        public bool IsUnsafe;
        public bool IsStatic;
        public bool AllocatesUnmanagedMemory;
        public List<ParamActionDefinition> ParamActions;
        public List<MethodAction> MemberActions;
    }
}
