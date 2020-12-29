using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Pipeline;
using SharpVk.Generator.Specification.Elements;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Collation
{
    public class ConstantCollator
        : IWorker
    {
        private readonly EnumElement constantsEnum;
        private readonly NameFormatter nameFormatter;

        public ConstantCollator(IEnumerable<EnumElement> enums, NameFormatter nameFormatter)
        {
            this.constantsEnum = enums.Single(x => x.VkName == "API Constants");
            this.nameFormatter = nameFormatter;
        }

        public void Execute(IServiceCollection services)
        {
            foreach (var field in constantsEnum.Fields.Values)
            {
                if (field.Value != null)
                {
                    services.AddSingleton(new ConstantDeclaration
                    {
                        VkName = field.VkName,
                        Name = this.nameFormatter.FormatName(field),
                        Value = field.Value
                    });
                }
            }
        }
    }
}
