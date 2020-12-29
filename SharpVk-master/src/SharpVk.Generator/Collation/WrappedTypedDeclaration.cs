namespace SharpVk.Generator.Collation
{
    public class WrappedTypedDeclaration
        : ITypedDeclaration
    {
        private readonly ITypedDeclaration wrappedDeclaration;
        
        public WrappedTypedDeclaration(ITypedDeclaration wrappedDeclaration, MemberLen[] dimensions)
        {
            this.wrappedDeclaration = wrappedDeclaration;
            this.Dimensions = dimensions;
        }

        public string VkName => this.wrappedDeclaration.VkName;

        public string Name => this.wrappedDeclaration.Name;

        public bool IsOptional => this.wrappedDeclaration.IsOptional;

        public bool NoAutoValidity => this.wrappedDeclaration.NoAutoValidity;

        public string FixedValue => this.wrappedDeclaration.FixedValue;

        public TypeReference Type => this.wrappedDeclaration.Type;

        public MemberLen[] Dimensions { get; private set; }
    }
}
