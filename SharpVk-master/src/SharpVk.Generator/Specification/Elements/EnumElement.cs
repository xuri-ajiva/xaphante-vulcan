using System;
using System.Collections.Generic;
using System.Text;

namespace SharpVk.Generator.Specification.Elements
{
    public class EnumElement
        : SpecElement
    {
        public readonly Dictionary<string, EnumField> Fields = new Dictionary<string, EnumField>();
    }
}
