using System.Collections.Generic;

namespace SharpVk.Generator.Collation
{
    public class CommandDeclaration
    {
        public string VkName;
        public string Name;
        public string Verb;
        public string ExtensionNamespace;
        public string Extension;
        public string HandleTypeName;
        public int HandleParamsCount;
        public string ReturnType;
        public bool MultipleSuccessCodes;
        public List<ParamDeclaration> Params;
    }
}
