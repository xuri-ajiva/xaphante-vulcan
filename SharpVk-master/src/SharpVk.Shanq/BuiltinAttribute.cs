using System;
using SharpVk.Spirv;

namespace SharpVk.Shanq
{
    [AttributeUsage(AttributeTargets.Field)]
    public class BuiltInAttribute
        : Attribute
    {
        public BuiltInAttribute(BuiltIn builtIn)
        {
            BuiltIn = builtIn;
        }

        public BuiltIn BuiltIn
        {
            get;
        }
    }
}