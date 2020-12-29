using SharpVk.Emit;
using System;
using System.Collections.Generic;

namespace SharpVk.Generator.Generation
{
    public class ParamDefinition
    {
        public string Name;
        public List<string> Comment;
        public string Type;
        public bool IsOut;
        public Action<ExpressionBuilder> DefaultValue;
    }
}
