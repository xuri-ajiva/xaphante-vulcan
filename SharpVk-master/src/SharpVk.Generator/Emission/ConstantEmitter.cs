using SharpVk.Emit;
using SharpVk.Generator.Generation;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;
using System.Linq;
using static SharpVk.Emit.AccessModifier;
using static SharpVk.Emit.ExpressionBuilder;
using static SharpVk.Emit.TypeModifier;

namespace SharpVk.Generator.Emission
{
    public class ConstantEmitter
        : IOutputWorker
    {
        private readonly IEnumerable<ConstantDefinition> constants;
        private readonly FileBuilderFactory builderFactory;

        public ConstantEmitter(IEnumerable<ConstantDefinition> constants, FileBuilderFactory builderFactory)
        {
            this.constants = constants;
            this.builderFactory = builderFactory;
        }

        public void Execute()
        {
            var constantNamespaces = this.constants.GroupBy(x => string.Join(".", x.Namespace.Prepend("SharpVk")));

            foreach (var constantNamespace in constantNamespaces)
            {
                var constantGroups = constantNamespace.GroupBy(x => x.ConstantGroup);

                var subfolder = string.Join("\\", constantNamespace.First().Namespace);

                if (string.IsNullOrWhiteSpace(subfolder))
                {
                    subfolder = null;
                }

                foreach (var constantGroup in constantGroups)
                {
                    this.builderFactory.Generate(constantGroup.Key, subfolder, fileBuilder =>
                    {
                        fileBuilder.EmitNamespace(constantNamespace.Key, namespaceBuilder =>
                        {
                            namespaceBuilder.EmitType(TypeKind.Class, constantGroup.Key, typeBuilder =>
                            {
                                foreach (var constant in constantGroup)
                                {
                                    typeBuilder.EmitField(constant.Type, constant.Name, Public, MemberModifier.Const, AsIs(constant.Value));
                                }
                            }, Public, modifiers: Static);
                        });
                    });
                }
            }
        }
    }
}
