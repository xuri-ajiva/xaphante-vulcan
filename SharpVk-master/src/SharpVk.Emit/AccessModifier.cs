using System;

namespace SharpVk.Emit
{
    public enum AccessModifier
    {
        Private,
        Protected,
        Internal,
        ProtectedInternal,
        Public
    }

    public static class AccessModifierExtensions
    {
        public static string Emit(this AccessModifier modifier)
        {
            switch (modifier)
            {
                case AccessModifier.Private:
                case AccessModifier.Protected:
                case AccessModifier.Internal:
                case AccessModifier.Public:
                    return modifier.ToString().ToLowerInvariant();
                case AccessModifier.ProtectedInternal:
                    return "protected internal";
                default:
                    throw new NotSupportedException($"Unrecognised access modifier '{modifier}'");
            }
        }
    }
}