namespace SharpVk.Generator.Collation
{
    public class MemberDeclaration
        : ITypedDeclaration
    {
        public string VkName;
        public string Name;
        public bool IsOptional;
        public bool NoAutoValidity;
        public string ParamName;
        public TypeReference Type;
        public string FixedValue;
        public MemberLen[] Dimensions;

        public bool RequiresMarshalling => this.Type.PointerType.IsPointer() || this.Type.FixedLength.Type != FixedLengthType.None;

        string ITypedDeclaration.Name => this.Name;

        bool ITypedDeclaration.IsOptional => this.IsOptional;

        bool ITypedDeclaration.NoAutoValidity => this.NoAutoValidity;

        TypeReference ITypedDeclaration.Type => this.Type;

        string ITypedDeclaration.VkName => this.VkName;

        string ITypedDeclaration.FixedValue => this.FixedValue;

        MemberLen[] ITypedDeclaration.Dimensions => this.Dimensions;
    }
}
