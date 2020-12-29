using System;

namespace SharpVk.Emit
{
    [Flags]
    public enum TypeModifier
    {
        None = 0,
        Static = 1 << 0,
        Abstract = 1 << 1,
        Unsafe = 1 << 2,
        Partial = 1 << 3
    }
}