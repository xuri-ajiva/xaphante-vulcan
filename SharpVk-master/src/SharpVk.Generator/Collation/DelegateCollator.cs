using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Pipeline;
using SharpVk.Generator.Specification.Elements;
using System.Collections.Generic;
using System.Linq;
using System;

namespace SharpVk.Generator.Collation
{
    public class DelegateCollator
        : IWorker
    {
        private readonly IEnumerable<TypeElement> delegateTypes;
        private readonly NameFormatter nameFormatter;

        public DelegateCollator(IEnumerable<TypeElement> types, NameFormatter nameFormatter)
        {
            this.delegateTypes = types.Where(x => x.Category == TypeCategory.funcpointer);
            this.nameFormatter = nameFormatter;
        }

        public void Execute(IServiceCollection services)
        {
            foreach (var @delegate in this.delegateTypes)
            {
                services.AddSingleton(new DelegateDeclaration
                {
                    VkName = @delegate.VkName,
                    ReturnType = @delegate.Type,
                    Params = @delegate.Members.Select(DeclareParam).ToList()
                });
            }
        }

        private ParamDeclaration DeclareParam(MemberElement param)
        {
            return new ParamDeclaration
            {
                VkName = param.VkName,
                Type = new TypeReference
                {
                    VkName = param.Type,
                    PointerType = param.PointerType
                },
                Name = this.nameFormatter.FormatName(param, null, true)
            };
        }
    }
}
