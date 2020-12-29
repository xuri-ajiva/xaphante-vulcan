using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Collation;
using SharpVk.Generator.Generation.Marshalling;
using SharpVk.Generator.Pipeline;
using SharpVk.Generator.Rules;
using System.Collections.Generic;
using System.Linq;
using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generation
{
    public class MarshalledStructGenerator
        : IWorker
    {
        private readonly Dictionary<string, TypeDeclaration> typeData;
        private readonly NameLookup nameLookup;
        private readonly IEnumerable<IMemberPatternRule> patternRules;
        private readonly NamespaceMap namespaceMap;
        private readonly CommentGenerator commentGenerator;

        public MarshalledStructGenerator(Dictionary<string, TypeDeclaration> typeData, NameLookup nameLookup, IEnumerable<IMemberPatternRule> patternRules, NamespaceMap namespaceMap, CommentGenerator commentGenerator)
        {
            this.typeData = typeData;
            this.nameLookup = nameLookup;
            this.patternRules = patternRules;
            this.namespaceMap = namespaceMap;
            this.commentGenerator = commentGenerator;
        }

        public void Execute(IServiceCollection services)
        {
            foreach (var typeItem in this.typeData.Where(x => x.Value.Pattern == TypePattern.MarshalledStruct))
            {
                var type = typeItem.Value;
                var typeNamespace = new List<string>();

                if (type.Extension != null)
                {
                    typeNamespace.AddRange(this.namespaceMap.Map(type.Extension));
                }

                var publicStruct = new StructDefinition
                {
                    Name = type.Name,
                    Namespace = typeNamespace.ToArray(),
                    Comment = this.commentGenerator.Lookup(typeItem.Key),
                    Methods = new List<MethodDefinition>(),
                    Properties = new List<MemberDefinition>()
                };

                var marshalToMethod = new MethodDefinition
                {
                    Name = "MarshalTo",
                    IsUnsafe = true,
                    ParamActions = new List<ParamActionDefinition>
                    {
                        new ParamActionDefinition
                        {
                            Param = new ParamDefinition
                            {
                                Name = "pointer",
                                Type = this.nameLookup.Lookup(new TypeReference
                                {
                                    VkName = typeItem.Key,
                                    PointerType = PointerType.Pointer
                                }, true)
                            }
                        }
                    },
                    MemberActions = new List<MethodAction>()
                };


                var marshalFromMethod = new MethodDefinition
                {
                    Name = "MarshalFrom",
                    ReturnType = type.Name,
                    IsUnsafe = true,
                    IsStatic = true,
                    ParamActions = new List<ParamActionDefinition>
                    {
                        new ParamActionDefinition
                        {
                            Param = new ParamDefinition
                            {
                                Name = "pointer",
                                Type = this.nameLookup.Lookup(new TypeReference
                                {
                                    VkName = typeItem.Key,
                                    PointerType = PointerType.Pointer
                                }, true)
                            }
                        }
                    },
                    MemberActions = new List<MethodAction>()
                };

                if (!type.IsOutputOnly || (type.Extends?.Any(x => !this.typeData[x].IsOutputOnly) ?? false))
                {
                    publicStruct.Methods.Add(marshalToMethod);
                }

                if (type.IsOutputOnly || (!type.Name.EndsWith("Info") && type.Members.All(this.CanMarshalFrom)))
                {
                    publicStruct.Methods.Add(marshalFromMethod);
                }

                typeNamespace.Insert(0, "Interop");

                var interopStruct = new StructDefinition
                {
                    Name = type.Name,
                    Namespace = typeNamespace.ToArray(),
                    IsUnsafe = true,
                    Fields = new List<MemberDefinition>()
                };

                foreach (var member in type.Members)
                {
                    var patternInfo = new MemberPatternInfo
                    {
                    };

                    this.patternRules.ApplyFirst(type.Members, member, new MemberPatternContext(null, false, false, 0, type.Extension, x => Default(this.nameLookup.Lookup(new TypeReference { VkName = x }, false)), typeItem.Key), patternInfo);

                    marshalToMethod.MemberActions.AddRange(patternInfo.MarshalTo.Select(action => action(targetName => DerefMember(Variable("pointer"), targetName), valueName => Member(This, valueName))));
                    marshalFromMethod.MemberActions.AddRange(patternInfo.MarshalFrom.Select(action => action(targetName => Member(Variable("result"), targetName), valueName => DerefMember(Variable("pointer"), valueName))));

                    foreach (var publicMember in patternInfo.Public)
                    {
                        publicStruct.Properties.Add(new MemberDefinition
                        {
                            Name = publicMember.Name,
                            Type = publicMember.Type,
                            Comment = this.commentGenerator.Lookup(typeItem.Key, member.VkName)
                        });
                    }

                    if (patternInfo.Interop.Repeats.HasValue)
                    {
                        for (int index = 0; index < patternInfo.Interop.Repeats.Value; index++)
                        {
                            interopStruct.Fields.Add(new MemberDefinition
                            {
                                Name = patternInfo.Interop.Name + "_" + index,
                                Type = patternInfo.Interop.Type
                            });
                        }
                    }
                    else
                    {
                        interopStruct.Fields.Add(new MemberDefinition
                        {
                            Name = patternInfo.Interop.Name,
                            Type = patternInfo.Interop.Type,
                            Comment = this.commentGenerator.Lookup(typeItem.Key, member.VkName)
                        });
                    }

                }

                services.AddSingleton(publicStruct);

                services.AddSingleton(interopStruct);
            }
        }

        private bool CanMarshalFrom(MemberDeclaration param)
        {
            var typeData = this.typeData[param.Type.VkName];

            return typeData.Pattern != TypePattern.Delegate
                    && !typeData.Name.EndsWith("Info");
        }
    }
}
