using SharpVk.Emit;
using System;

namespace SharpVk.Generator.Generation.Marshalling
{
    public struct MarshalInfo
    {
        public string MemberType;
        public string InteropType;
        public string HandleType;
        public AssignActionType MarshalToActionType;
        public AssignActionType MarshalFromActionType;
        public Func<Action<ExpressionBuilder>, Func<string, Action<ExpressionBuilder>>, Action<ExpressionBuilder>> BuildMarshalToValueExpression;
        public Func<Action<ExpressionBuilder>, Func<string, Action<ExpressionBuilder>>, Action<ExpressionBuilder>> BuildMarshalFromValueExpression;
    }
}
