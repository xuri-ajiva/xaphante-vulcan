using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Collation;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Generation
{
    public class HandleExtensionsGenerator
        : IWorker
    {
        private readonly Dictionary<string, TypeDeclaration> typeData;
        private readonly NameLookup nameLookup;
        private readonly IEnumerable<CommandDeclaration> commands;
        private readonly NamespaceMap namespaceMap;
        private readonly HandleGenerator handleGenerator;

        public HandleExtensionsGenerator(Dictionary<string, TypeDeclaration> typeData, NameLookup nameLookup, IEnumerable<CommandDeclaration> commands, NamespaceMap namespaceMap, HandleGenerator handleGenerator)
        {
            this.typeData = typeData;
            this.nameLookup = nameLookup;
            this.commands = commands;
            this.namespaceMap = namespaceMap;
            this.handleGenerator = handleGenerator;
        }

        public void Execute(IServiceCollection services)
        {
            foreach (var extension in this.commands.Where(x => x.ExtensionNamespace != null).GroupBy(x => x.ExtensionNamespace))
            {
                foreach (var handle in extension.GroupBy(x => x.HandleTypeName))
                {
                    var handleType = this.typeData[handle.Key];

                    var methods = handle.Where(x => x.ExtensionNamespace?.ToLower() != handleType.Extension?.ToLower())
                                            .SelectMany(x => this.handleGenerator.GenerateCommand(x, x.HandleTypeName, handleType, true))
                                            .ToList();

                    if (methods.Any())
                    {
                        services.AddSingleton(new HandleExtensionDefinition
                        {
                            Namespace = this.namespaceMap.Map(extension.Key).ToArray(),
                            Name = handleType.Name + "Extensions",
                            Methods = methods
                        });
                    }
                }
            }
        }
    }
}
