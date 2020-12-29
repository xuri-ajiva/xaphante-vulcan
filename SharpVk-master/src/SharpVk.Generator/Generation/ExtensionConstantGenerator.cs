using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Generation
{
    public class ExtensionConstantGenerator
        : IWorker
    {
        private readonly IEnumerable<ExtensionInfo> extensions;
        private readonly NameLookup nameLookup;
        private readonly NamespaceMap namespaceMap;

        public ExtensionConstantGenerator(IEnumerable<ExtensionInfo> extensions, NameLookup nameLookup, NamespaceMap namespaceMap)
        {
            this.extensions = extensions;
            this.nameLookup = nameLookup;
            this.namespaceMap = namespaceMap;
        }

        public void Execute(IServiceCollection services)
        {
            foreach (var extension in this.extensions)
            {
                var namespaces = this.namespaceMap.Map(extension.Extension).ToArray();
                var name = this.nameLookup.Lookup(extension.Name);

                if (char.IsDigit(name[0]))
                {
                    name = extension.Extension.FirstToUpper() + name;
                }

                services.AddSingleton(new ConstantDefinition
                {
                    ConstantGroup = extension.Extension.FirstToUpper() + "Extensions",
                    Namespace = namespaces,
                    Name = name,
                    Type = "string",
                    Value = $"\"{extension.Name}\""
                }); ;
            }
        }
    }
}
