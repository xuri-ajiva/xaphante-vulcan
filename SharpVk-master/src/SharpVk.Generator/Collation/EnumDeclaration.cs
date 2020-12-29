using System.Collections.Generic;

namespace SharpVk.Generator.Collation
{
    public class EnumDeclaration
    {
        public string VkName;
        public string Name;
        public string Extension;
        public bool IsFlags;
        public List<FieldDeclaration> Fields;
    }
}
