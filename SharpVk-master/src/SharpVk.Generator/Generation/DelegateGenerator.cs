using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Collation;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Generation
{
    public class DelegateGenerator
        : IWorker
    {
        private readonly IEnumerable<DelegateDeclaration> delegates;
        private readonly Dictionary<string, TypeDeclaration> typeData;
        private readonly NamespaceMap namespaceMap;
        private readonly NameLookup nameLookup;

        public DelegateGenerator(IEnumerable<DelegateDeclaration> delegates, Dictionary<string, TypeDeclaration> typeData, NamespaceMap namespaceMap, NameLookup nameLookup)
        {
            this.delegates = delegates;
            this.typeData = typeData;
            this.namespaceMap = namespaceMap;
            this.nameLookup = nameLookup;
        }

        public void Execute(IServiceCollection services)
        {
            foreach (var @delegate in delegates)
            {
                var type = this.typeData[@delegate.VkName];

                services.AddSingleton(new DelegateDefinition
                {
                    Name = type.Name,
                    Namespace = this.namespaceMap.Map(type.Extension).ToArray(),
                    ReturnType = this.typeData[@delegate.ReturnType].Name,
                    Parameters = @delegate.Params.Select(x =>
                    {
                        string typeName = this.nameLookup.Lookup(x.Type, true);

                        if (x.Type.PointerType.IsPointer())
                        {
                            if (x.Type.VkName == "char")
                            {
                                typeName = "string";
                            }
                            else
                            {
                                typeName = "IntPtr";
                            }
                        }

                        return new ParamDefinition
                        {
                            Name = x.Name,
                            Type = typeName
                        };
                    }).ToList()
                });

                //services.AddSingleton(new TypeNameMapping
                //{
                //    VkName = @delegate.VkName,
                //    OutputName = type.Name
                //});
            }
        }
    }
}
