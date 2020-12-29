using System.Collections.Generic;

namespace SharpVk.Generator.Specification.Elements
{
    public class CommandElement
        : SpecElement
    {
        public string Verb;
        public string ExtensionType;
        public string[] SuccessCodes;
        public readonly List<ParamElement> Params = new List<ParamElement>();
    }
}
