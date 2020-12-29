using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Collation;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Generation
{
    public class ExceptionGenerator
        : IWorker
    {
        private readonly EnumDeclaration resultEnum;
        private readonly NamespaceMap namespaceMap;
        private readonly CommentGenerator commentGenerator;

        public ExceptionGenerator(IEnumerable<EnumDeclaration> enums, NamespaceMap namespaceMap, CommentGenerator commentGenerator)
        {
            this.resultEnum = enums.Single(x => x.VkName == "VkResult");
            this.namespaceMap = namespaceMap;
            this.commentGenerator = commentGenerator;
        }

        public void Execute(IServiceCollection services)
        {
            foreach (var error in this.resultEnum.Fields
                                        .Where(x => x.Value != null && int.Parse(x.Value) < 0))
            {
                string errorName = error.Name + "Exception";

                if (errorName.StartsWith("Error"))
                {
                    errorName = errorName.Substring(5);
                }

                services.AddSingleton(new ExceptionDefinition
                {
                    Name = errorName,
                    Comment = this.commentGenerator.Lookup(this.resultEnum.VkName, error.VkName),
                    Value = $"{this.resultEnum.Name}.{error.Name}",
                });
            }
        }
    }
}
