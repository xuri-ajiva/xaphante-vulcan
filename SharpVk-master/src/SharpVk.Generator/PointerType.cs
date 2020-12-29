namespace SharpVk.Generator
{
    public enum PointerType
    {
        Value,
        ConstValue,
        Pointer,
        DoublePointer,
        ConstPointer,
        DoubleConstPointer
    }

    public static class PointerTypeExtensions
    {
        public static PointerType Deref(this PointerType pointerType)
        {
            switch (pointerType)
            {
                case PointerType.DoublePointer:
                    return PointerType.Pointer;
                case PointerType.DoubleConstPointer:
                    return PointerType.ConstPointer;
                default:
                    return PointerType.Value;
            }
        }

        public static int GetPointerCount(this PointerType pointerType)
        {
            switch (pointerType)
            {
                case PointerType.Pointer:
                case PointerType.ConstPointer:
                    return 1;
                case PointerType.DoublePointer:
                case PointerType.DoubleConstPointer:
                    return 2;
                default:
                    return 0;
            }
        }

        public static bool IsPointer(this PointerType pointerType)
        {
            switch (pointerType)
            {
                case PointerType.Value:
                case PointerType.ConstValue:
                    return false;
                default:
                    return true;
            }
        }

        public static bool IsConst(this PointerType pointerType)
        {
            switch(pointerType)
            {
                case PointerType.Value:
                case PointerType.ConstValue:
                case PointerType.ConstPointer:
                case PointerType.DoubleConstPointer:
                    return true;
                default:
                    return false;
            }
        }
    }
}
