using SharpVk.Generator.Generation;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;
using System.Linq;

using static SharpVk.Emit.AccessModifier;
using static SharpVk.Emit.TypeModifier;

namespace SharpVk.Generator.Emission
{
    public class DelegateEmitter
        : IOutputWorker
    {
        private readonly IEnumerable<DelegateDefinition> delegates;
        private readonly FileBuilderFactory builderFactory;

        public DelegateEmitter(IEnumerable<DelegateDefinition> delegates, FileBuilderFactory builderFactory)
        {
            this.delegates = delegates;
            this.builderFactory = builderFactory;
        }

        public void Execute()
        {
            foreach (var @delegate in this.delegates)
            {
                string path = null;
                string @namespace = "SharpVk";

                if (@delegate.Namespace?.Any() ?? false)
                {
                    path = string.Join("\\", @delegate.Namespace);
                    @namespace += "." + string.Join(".", @delegate.Namespace);
                }

                this.builderFactory.Generate(@delegate.Name, path, fileBuilder =>
                {
                    fileBuilder.EmitUsing("System");

                    fileBuilder.EmitNamespace(@namespace, namespaceBuilder =>
                    {
                        namespaceBuilder.EmitDelegate(@delegate.ReturnType,
                                                        @delegate.Name,
                                                        Public,
                                                        @delegate.IsUnsafe ? Unsafe : None,
                                                        parameters =>
                                                        {
                                                            if (@delegate.Parameters != null)
                                                            {
                                                                foreach (var param in @delegate.Parameters)
                                                                {
                                                                    parameters.EmitParam(param.Type, param.Name);
                                                                }
                                                            }
                                                        },
                                                        @delegate.Comment);
                    });
                });
            }
        }
    }
}
