using System;

namespace SharpVk.Emit
{
    [Flags]
    public enum MemberModifier
    {
        None = 0,
        Static = 1 << 0,
        Const = 1 << 1,
        Extern = 1 << 2,
        Readonly = 1 << 3,
        Abstract = 1 << 4,
        Override = 1 << 5,
        Explicit = 1 << 6,
        Implicit = 1 << 7,
        Unsafe = 1 << 8,
        Fixed = 1 << 9
    }
}