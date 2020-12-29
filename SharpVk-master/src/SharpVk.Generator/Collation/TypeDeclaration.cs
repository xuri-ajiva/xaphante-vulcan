using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Collation
{
    public class TypeDeclaration
    {
        public string Name;
        public string Parent;
        public string Extension;
        public string Type;
        public bool IsOutputOnly;
        public TypePattern Pattern;
        public List<MemberDeclaration> Members;
        public List<string> ExtendTypes;
        public List<string> Extends;

        public bool RequiresMarshalling => this.Pattern.RequiresMarshalling() || this.Members.Any(x => x.RequiresMarshalling) || this.Name == "Bool32";
    }
}
