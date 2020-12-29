namespace SharpVk.Generator.Specification.Elements
{
    public class ChildElement
        : SpecElement
    {
        public bool IsOptional;
        public FixedLengthDeclaration FixedLength;
        public MemberLen[] Dimensions;
        public PointerType PointerType;
        public bool NoAutoValidity;
    }
}
