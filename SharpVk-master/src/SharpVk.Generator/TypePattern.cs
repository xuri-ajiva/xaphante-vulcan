using System;

namespace SharpVk.Generator
{
    public enum TypePattern
    {
        Handle,
        MarshalledStruct,
        NonMarshalledStruct,
        Enum,
        Delegate,
        Union,
        Primitive
    }

    public static class TypePatternExtensions
    {
        public static TypePattern MapToPattern(this TypeCategory category)
        {
            switch (category)
            {
                case TypeCategory.@struct:
                    return TypePattern.NonMarshalledStruct;
                case TypeCategory.@enum:
                case TypeCategory.bitmask:
                    return TypePattern.Enum;
                case TypeCategory.funcpointer:
                    return TypePattern.Delegate;
                case TypeCategory.None:
                case TypeCategory.basetype:
                    return TypePattern.Primitive;
                case TypeCategory.handle:
                    return TypePattern.Handle;
                case TypeCategory.union:
                    return TypePattern.Union;
                default:
                    throw new NotSupportedException();
            }
        }

        public static bool RequiresMarshalling(this TypePattern pattern)
        {
            return pattern == TypePattern.Handle || pattern == TypePattern.MarshalledStruct;
        }
    }
}
