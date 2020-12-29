using SharpVk.Emit;
using SharpVk.Generator.Generation;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;
using System.Linq;

using static SharpVk.Emit.AccessModifier;
using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Emission
{
    class HandleExtensionEmitter
        : IOutputWorker
    {
        private readonly IEnumerable<HandleExtensionDefinition> handleExtensions;
        private readonly MethodEmitter methodEmitter;
        private readonly FileBuilderFactory builderFactory;

        public HandleExtensionEmitter(IEnumerable<HandleExtensionDefinition> handleExtensions, MethodEmitter methodEmitter, FileBuilderFactory builderFactory)
        {
            this.handleExtensions = handleExtensions;
            this.methodEmitter = methodEmitter;
            this.builderFactory = builderFactory;
        }

        public void Execute()
        {
            foreach (var handleExtension in this.handleExtensions)
            {
                string path = string.Join("\\", handleExtension.Namespace);
                string @namespace = string.Join(".", handleExtension.Namespace.Prepend("SharpVk"));

                this.builderFactory.Generate(handleExtension.Name, path, fileBuilder =>
                {
                    fileBuilder.EmitUsing("System");

                    fileBuilder.EmitNamespace(@namespace, namespaceBuilder =>
                    {
                        namespaceBuilder.EmitType(TypeKind.Class, handleExtension.Name, typeBuilder =>
                        {
                            foreach (var method in handleExtension.Methods)
                            {
                                this.methodEmitter.Emit(typeBuilder, method);
                            }

                        }, Public, modifiers: TypeModifier.Static);
                    });
                });
            }
        }
    }
}
