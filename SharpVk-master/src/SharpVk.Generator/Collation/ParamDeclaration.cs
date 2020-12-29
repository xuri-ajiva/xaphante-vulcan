using System;

namespace SharpVk.Generator.Collation
{
    public class ParamDeclaration
        : ITypedDeclaration
    {
        public string VkName;
        public string Name;
        public TypeReference Type;
        public MemberLen[] Dimensions;
        public bool IsOptional;
        public bool NoAutoValidity;

        string ITypedDeclaration.Name => this.Name;

        bool ITypedDeclaration.IsOptional => this.IsOptional;

        bool ITypedDeclaration.NoAutoValidity => this.NoAutoValidity;

        TypeReference ITypedDeclaration.Type => this.Type;

        string ITypedDeclaration.VkName => this.VkName;

        string ITypedDeclaration.FixedValue => null;

        MemberLen[] ITypedDeclaration.Dimensions => this.Dimensions;
    }
}
