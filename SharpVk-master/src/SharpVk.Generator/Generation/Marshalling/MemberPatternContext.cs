using SharpVk.Emit;
using System;

namespace SharpVk.Generator.Generation.Marshalling
{
    public struct MemberPatternContext
    {
        public MemberPatternContext(string methodVerb, bool isMethod, bool isBatchSingleMethod, int returnParamsCount, string extension, Func<string, Action<ExpressionBuilder>> getHandle, string vkName)
            : this()
        {
            this.MethodVerb = methodVerb;
            this.IsMethod = isMethod;
            this.IsBatchSingleMethod = isBatchSingleMethod;
            this.ReturnParamsCount = returnParamsCount;
            this.Extension = extension;
            this.GetHandle = getHandle;
            this.VkName = vkName;
        }

        public string MethodVerb
        {
            get;
            private set;
        }

        public bool IsMethod
        {
            get;
            private set;
        }

        public bool IsBatchSingleMethod
        {
            get;
            private set;
        }

        public int ReturnParamsCount
        {
            get;
            private set;
        }

        public bool HasReturnValue => this.ReturnParamsCount > 0;

        public string Extension
        {
            get;
            private set;
        }

        public Func<string, Action<ExpressionBuilder>> GetHandle
        {
            get;
            private set;
        }

        public string VkName
        {
            get;
            private set;
        }
    }
}
