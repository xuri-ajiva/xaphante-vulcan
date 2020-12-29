using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Collation
{
    public class ExtensionCollator
        : IWorker
    {
        private readonly IEnumerable<ExtensionInfo> extensions;

        public ExtensionCollator(IEnumerable<ExtensionInfo> extensions)
        {
            this.extensions = extensions;
        }

        public void Execute(IServiceCollection services)
        {
            foreach (var extension in this.extensions)
            {
                var nameParts = extension.Name.Split('_').Skip(2);

                string outputName = string.Join("", nameParts.Select(StringExtensions.FirstToUpper));

                services.AddSingleton(new TypeNameMapping
                {
                    VkName = extension.Name,
                    OutputName = outputName
                });

                services.AddSingleton(new ExtensionDeclaration
                {
                    Name = extension.Name,
                    Scope = extension.Scope
                });
            }
        }
    }
}
