using SharpVk.Emit;
using System;
using System.Collections.Generic;

namespace SharpVk.Generator.Generation
{
    public struct TypedDefinition
    {
        public string Name;
        public List<string> Comment;
        public string Type;
        public Action<ExpressionBuilder> DefaultValue;
        public int? Repeats;
    }
}
