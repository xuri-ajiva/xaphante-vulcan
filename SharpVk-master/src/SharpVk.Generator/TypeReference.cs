namespace SharpVk.Generator
{
    public class TypeReference
    {
        public string VkName;
        public PointerType PointerType;
        public FixedLengthDeclaration FixedLength;

        public TypeReference Deref()
        {
            return new TypeReference()
            {
                VkName = this.VkName,
                PointerType = this.PointerType.Deref(),
                FixedLength = new FixedLengthDeclaration
                {
                    Type = FixedLengthType.None
                }
            };
        }
    }
}
