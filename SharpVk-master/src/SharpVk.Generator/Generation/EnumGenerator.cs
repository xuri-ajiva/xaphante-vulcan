using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Collation;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Generation
{
    public class EnumGenerator
        : IWorker
    {
        private readonly IEnumerable<EnumDeclaration> enums;
        private readonly NamespaceMap namespaceMap;
        private readonly CommentGenerator commentGenerator;

        public EnumGenerator(IEnumerable<EnumDeclaration> enums, NamespaceMap namespaceMap, CommentGenerator commentGenerator)
        {
            this.enums = enums;
            this.namespaceMap = namespaceMap;
            this.commentGenerator = commentGenerator;
        }

        public void Execute(IServiceCollection services)
        {
            foreach (var enumeration in this.enums)
            {
                services.AddSingleton(new EnumDefinition
                {
                    Name = enumeration.Name,
                    Namespace = enumeration.Extension != null ? this.namespaceMap.Map(enumeration.Extension).ToArray() : null,
                    Comment = this.commentGenerator.Lookup(enumeration.VkName),
                    IsFlags = enumeration.IsFlags,
                    Fields = enumeration.Fields.Where(x => x.Value != null).Select(x => new FieldDefinition
                    {
                        Name = x.Name,
                        Comment = this.commentGenerator.Lookup(enumeration.VkName, x.VkName),
                        Value = x.Value
                    }).ToList()
                });
            }
        }
    }
}
