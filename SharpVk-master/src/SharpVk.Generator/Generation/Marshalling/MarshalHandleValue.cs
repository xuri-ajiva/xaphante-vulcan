using SharpVk.Emit;
using SharpVk.Generator.Collation;
using System;
using System.Collections.Generic;
using System.Linq;
using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class MarshalHandleValue
        : IMarshalValueRule
    {
        private readonly Dictionary<string, TypeDeclaration> typeData;
        private readonly NameLookup nameLookup;

        public MarshalHandleValue(NameLookup nameLookup, Dictionary<string, TypeDeclaration> typeData)
        {
            this.nameLookup = nameLookup;
            this.typeData = typeData;
        }

        public bool Apply(TypeReference type, out MarshalInfo info)
        {
            var typeInfo = this.typeData[type.VkName];
            var typePattern = typeInfo.Pattern;

            if (typePattern == TypePattern.Handle)
            {
                string memberType = this.nameLookup.Lookup(type, false);
                var interopType = this.nameLookup.Lookup(type, true, false);

                info = new MarshalInfo
                {
                    MemberType = memberType,
                    InteropType = interopType,
                    HandleType = type.VkName
                };

                var handleExpressions = new List<Func<Action<ExpressionBuilder>, Func<string, Action<ExpressionBuilder>>, Action<ExpressionBuilder>>>();

                if (typeInfo.Parent != null)
                {
                    handleExpressions.Add((value, getHandle) => getHandle(typeInfo.Parent));
                }
                else
                {
                    //HACK
                    if (typeInfo.Name == "Instance")
                    {
                        handleExpressions.Add((value, getHandle) => Variable("commandCache"));
                    }
                }

                if (type.PointerType.IsPointer())
                {
                    info.BuildMarshalToValueExpression = (value, getHandle) => Member(value, "handle");
                    info.MarshalToActionType = AssignActionType.AllocAndAssign;
                    handleExpressions.Add((value, getHandle) => Deref(value));
                }
                else
                {
                    info.BuildMarshalToValueExpression = (value, getHandle) => Coalesce(CoalesceMember(value, "handle"), Default(interopType));
                    handleExpressions.Add((value, getHandle) => value);
                }

                info.BuildMarshalFromValueExpression = (value, getHandle) => New(memberType, handleExpressions.Select(x => x(value, getHandle)).ToArray());

                return true;
            }
            else
            {
                info = new MarshalInfo();

                return false;
            }
        }
    }
}
