using SharpVk.Emit;
using SharpVk.Generator.Generation;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;
using System.Linq;
using static SharpVk.Emit.AccessModifier;
using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Emission
{
    class EnumEmitter
        : IOutputWorker
    {
        private readonly IEnumerable<EnumDefinition> enums;
        private readonly FileBuilderFactory builderFactory;

        public EnumEmitter(IEnumerable<EnumDefinition> enums, FileBuilderFactory builderFactory)
        {
            this.enums = enums;
            this.builderFactory = builderFactory;
        }

        public void Execute()
        {
            foreach (var @enum in this.enums)
            {
                string path = null;
                string @namespace = "SharpVk";

                if (@enum.Namespace?.Any() ?? false)
                {
                    path = string.Join("\\", @enum.Namespace);
                    @namespace += "." + string.Join(".", @enum.Namespace);
                }

                this.builderFactory.Generate(@enum.Name, path, fileBuilder =>
                {
                    fileBuilder.EmitNamespace(@namespace, namespaceBuilder =>
                    {
                        var attributes = @enum.IsFlags ? new[] { "System.Flags" } : null;

                        namespaceBuilder.EmitEnum(@enum.Name, enumBuilder =>
                        {
                            foreach (var field in @enum.Fields)
                            {
                                enumBuilder.EmitField(field.Name, AsIs(field.Value), summary: field.Comment);
                            }
                        }, Public, attributes: attributes, summary: @enum.Comment);
                    });
                });
            }
        }
    }
}
