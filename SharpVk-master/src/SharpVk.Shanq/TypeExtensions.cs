using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace SharpVk.Shanq
{
    public static class TypeExtensions
    {
        public static IEnumerable<FieldInfo> GetFieldsByOffset(this Type type)
        {
            return type.GetFields().OrderBy(x => Marshal.OffsetOf(type, x.Name).ToInt32());
        }
    }
}