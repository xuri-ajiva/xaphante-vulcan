using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Pipeline;
using SharpVk.Generator.Specification.Elements;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Collation
{
    public class TypeCollator
        : IWorker
    {
        private readonly IEnumerable<TypeElement> types;
        private readonly NameFormatter nameFormatter;
        private readonly IEnumerable<string> handleTypes;

        public TypeCollator(IEnumerable<TypeElement> types, NameFormatter nameFormatter)
        {
            this.types = types;
            this.nameFormatter = nameFormatter;

            this.handleTypes = this.types.Where(x => x.Category == TypeCategory.handle)
                                        .Select(x => x.VkName)
                                        .ToArray();
        }

        public void Execute(IServiceCollection services)
        {
            var extendTypes = this.types.ToDictionary(x => x.VkName, x => this.types.Where(y => y.Extends?.Contains(x.VkName) ?? false).Select(y => y.VkName).ToList());

            var typeData = this.types
                                    .Where(x => x.Category != TypeCategory.define
                                            && x.Category != TypeCategory.include
                                            && x.Alias == null)
                                    .ToDictionary(x => x.VkName, x => new TypeDeclaration
                                    {
                                        Name = this.nameFormatter.FormatName(x),
                                        Parent = x.Parent,
                                        Extension = x.ExtensionNamespace?.FirstToUpper(),
                                        Pattern = x.Category.MapToPattern(),
                                        Members = this.GetMembers(x, this.nameFormatter.FormatName(x)).ToList(),
                                        ExtendTypes = extendTypes[x.VkName].ToList(),
                                        Extends = x.Extends,
                                        Type = x.Type,
                                        IsOutputOnly = x.IsReturnedOnly
                                    });

            foreach (var type in this.types.Where(x => x.Alias != null))
            {
                typeData.Add(type.VkName, typeData[type.Alias]);
            }

            bool newInteropTypes = true;

            while (newInteropTypes)
            {
                newInteropTypes = false;

                foreach (var type in typeData.Values)
                {
                    if (type.Pattern == TypePattern.NonMarshalledStruct
                            && type.Members.Any(x => x.RequiresMarshalling || typeData[x.Type.VkName].RequiresMarshalling))
                    {
                        type.Pattern = TypePattern.MarshalledStruct;

                        newInteropTypes = true;
                    }
                }
            }

            foreach (var type in typeData)
            {
                string name = type.Value.Name;

                services.AddSingleton(new TypeNameMapping
                {
                    VkName = type.Key,
                    Extension = type.Value.Extension,
                    IsDefined = type.Value.Pattern != TypePattern.Primitive,
                    OutputName = name
                });
            }

            services.AddSingleton(typeData);
        }

        private IEnumerable<MemberDeclaration> GetMembers(TypeElement type, string typeName)
        {
            foreach (var member in type.Members)
            {
                yield return new MemberDeclaration
                {
                    VkName = member.VkName,
                    Name = this.nameFormatter.FormatName(member, typeName, false),
                    IsOptional = member.IsOptional,
                    NoAutoValidity = member.NoAutoValidity,
                    ParamName = this.nameFormatter.FormatName(member, typeName, true),
                    FixedValue = member.Values,
                    Dimensions = member.Dimensions,
                    Type = new TypeReference
                    {
                        VkName = member.Type,
                        PointerType = member.PointerType,
                        FixedLength = member.FixedLength
                    }
                };
            }
        }
    }
}
