using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Pipeline;
using SharpVk.Generator.Specification.Elements;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Collation
{
    public class EnumCollator
        : IWorker
    {
        private readonly Dictionary<string, EnumElement> enums;
        private readonly Dictionary<string, TypeElement> types;
        private readonly NameFormatter nameFormatter;
        private readonly IEnumerable<string> enumTypes;
        private readonly IEnumerable<TypeElement> bitmaskTypes;

        public EnumCollator(IEnumerable<EnumElement> enums, IEnumerable<TypeElement> types, NameFormatter nameFormatter)
        {
            this.enums = enums.ToDictionary(x => x.VkName);
            this.types = types.ToDictionary(x => x.VkName);

            this.nameFormatter = nameFormatter;

            var enumTypes = this.enums.Select(x => x.Key).ToList();

            var bitmaskTypes = new List<TypeElement>();

            foreach (var bitmaskType in types.Where(x => x.Category == TypeCategory.bitmask))
            {
                bitmaskTypes.Add((bitmaskType));

                if (bitmaskType.Requires != null)
                {
                    enumTypes.Remove(bitmaskType.Requires);
                }
            }

            enumTypes.Remove("API Constants");

            this.enumTypes = enumTypes;
            this.bitmaskTypes = bitmaskTypes;
        }

        public void Execute(IServiceCollection services)
        {
            var enumLookup = new Dictionary<string, EnumMapping>();

            foreach (var enumType in this.enumTypes)
            {
                var enumeration = this.enums[enumType];

                string name = this.nameFormatter.FormatName(enumeration);
                string extension = enumeration.ExtensionNamespace?.FirstToUpper();

                services.AddSingleton(new EnumDeclaration
                {
                    VkName = enumeration.VkName,
                    Name = name,
                    Extension = extension,
                    Fields = this.DeclareFields(enumeration, false, enumLookup)
                });

                services.AddSingleton(new TypeNameMapping
                {
                    VkName = enumeration.VkName,
                    Priority = 1,
                    Extension = extension,
                    OutputName = name
                });
            }

            foreach (var bitmaskType in this.bitmaskTypes)
            {
                var enumeration = bitmaskType.Requires != null
                                        ? this.enums[bitmaskType.Requires]
                                        : null;

                string name = this.nameFormatter.FormatName(bitmaskType);
                string extension = bitmaskType.ExtensionNamespace?.FirstToUpper();

                services.AddSingleton(new EnumDeclaration
                {
                    VkName = enumeration?.VkName ?? bitmaskType.VkName,
                    Name = name,
                    Extension = extension,
                    IsFlags = true,
                    Fields = this.DeclareFields(enumeration, true, enumLookup)
                });

                if (enumeration != null)
                {
                    services.AddSingleton(new TypeNameMapping
                    {
                        VkName = enumeration.VkName,
                        Extension = extension,
                        OutputName = name,
                        Priority = 1
                    });
                }

                services.AddSingleton(new TypeNameMapping
                {
                    VkName = bitmaskType.VkName,
                    Extension = extension,
                    OutputName = name,
                    Priority = 1
                });
            }

            services.AddSingleton(enumLookup);
        }

        private List<FieldDeclaration> DeclareFields(EnumElement enumeration, bool isBitmask, Dictionary<string, EnumMapping> enumLookup)
        {
            var result = new List<FieldDeclaration>();

            if (enumeration != null)
            {
                if (isBitmask && !enumeration.Fields.Values.Any(x => x.Value == "0" && !x.IsBitmask))
                {
                    AddNoneField(result);
                }

                var fieldNameLookup = enumeration.Fields.Values.ToDictionary(x => x.VkName, x => this.nameFormatter.FormatName(enumeration, x, x.IsBitmask));
                var fieldNameCount = fieldNameLookup.Values.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

                foreach (var field in enumeration.Fields.Values)
                {
                    var name = fieldNameLookup[field.VkName];
                    if (fieldNameCount[name] > 1)
                    {
                        name += field.ExtensionNamespace;
                    }
                    string value = field.Value;

                    if (field.IsBitmask)
                    {
                        value = $"1 << {value}";
                    }

                    result.Add(new FieldDeclaration
                    {
                        VkName = field.VkName,
                        Name = name,
                        Extension = field.ExtensionNamespace,
                        Value = value
                    });

                    enumLookup.Add(field.VkName, new EnumMapping(enumeration.VkName, name));
                }
            }
            else
            {
                AddNoneField(result);
            }

            return result;
        }

        private static void AddNoneField(List<FieldDeclaration> result)
        {
            result.Add(new FieldDeclaration
            {
                VkName = "__none",
                Name = "None",
                Value = "0"
            });
        }
    }
}
