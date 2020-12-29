using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Collation;
using SharpVk.Generator.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class ArraySingularMemberPattern
        : IMemberPatternRule
    {
        private readonly IEnumerable<IMarshalValueRule> marshallingRules;
        private readonly NameLookup nameLookup;
        private readonly ParsedExpressionEqualityCheck expressionEqualityCheck;
        private readonly CommentGenerator commentGenerator;
        private readonly IServiceProvider provider;

        public ArraySingularMemberPattern(IEnumerable<IMarshalValueRule> marshallingRules, NameLookup nameLookup, ParsedExpressionEqualityCheck expressionEqualityCheck, CommentGenerator commentGenerator, IServiceProvider provider)
        {
            this.marshallingRules = marshallingRules;
            this.nameLookup = nameLookup;
            this.expressionEqualityCheck = expressionEqualityCheck;
            this.commentGenerator = commentGenerator;
            this.provider = provider;
        }

        public bool Apply(IEnumerable<ITypedDeclaration> others, ITypedDeclaration source, MemberPatternContext context, MemberPatternInfo info)
        {
            if (source.Dimensions != null
                    && source.Dimensions.Length == 1
                    && source.Dimensions[0].Type == LenType.Expression
                    && context.IsBatchSingleMethod)
            {
                var resultMember = others.Last();
                var resultLen = resultMember.Dimensions[0].Value;

                if (!this.expressionEqualityCheck.Check(resultLen, source.Dimensions[0].Value))
                {
                    return false;
                }

                var verbInfoPattern = this.provider.GetServices<IMemberPatternRule>().OfType<VerbInfoMemberPattern>().Single();
                //var verbInfoPatternInfo = new MemberPatternInfo();
                if (verbInfoPattern.Apply(others,
                                                new ParamDeclaration
                                                {
                                                    Name = source.Name,
                                                    VkName = source.VkName,
                                                    Dimensions = null,
                                                    IsOptional = false,
                                                    NoAutoValidity = false,
                                                    Type = source.Type
                                                }, context, info))
                {

                }
                else
                {
                    string typeName = this.nameLookup.Lookup(source.Type, true);

                    info.Interop = new TypedDefinition
                    {
                        Name = source.Name,
                        Type = typeName
                    };

                    var marshalling = this.marshallingRules.ApplyFirst(source.Type);

                    info.InteropFullType = marshalling.InteropType.TrimEnd('*') + "*";

                    info.Public.Add(new TypedDefinition
                    {
                        Name = source.Name,
                        Type = marshalling.MemberType,
                        Comment = this.commentGenerator.Lookup(context.VkName, source.VkName),
                        DefaultValue = null
                    });

                    info.MarshalTo.Add((getTarget, getValue) => new AssignAction
                    {
                        Type = marshalling.MarshalToActionType,
                        MemberType = marshalling.InteropType,
                        ValueExpression = marshalling.BuildMarshalToValueExpression(getValue(source.Name), context.GetHandle),
                        TargetExpression = getTarget(source.Name)
                    });

                    info.MarshalFrom.Add((getTarget, getValue) => new AssignAction
                    {
                        TargetExpression = getTarget(source.Name),
                        MemberType = marshalling.MemberType,
                        Type = marshalling.MarshalFromActionType,
                        NullCheckExpression = IsNotEqual(getValue(source.Name), Null),
                        ValueExpression = marshalling.BuildMarshalFromValueExpression(getValue(source.Name), context.GetHandle)
                    });
                }

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
