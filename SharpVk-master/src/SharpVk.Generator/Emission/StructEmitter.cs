using SharpVk.Emit;
using SharpVk.Generator.Generation;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;
using System.Linq;

using static SharpVk.Emit.AccessModifier;
using static SharpVk.Emit.TypeModifier;

namespace SharpVk.Generator.Emission
{
    public class StructEmitter
        : IOutputWorker
    {
        private readonly IEnumerable<StructDefinition> structs;
        private readonly MethodEmitter methodEmitter;
        private readonly FileBuilderFactory builderFactory;

        public StructEmitter(IEnumerable<StructDefinition> structs, MethodEmitter methodEmitter, FileBuilderFactory builderFactory)
        {
            this.structs = structs;
            this.methodEmitter = methodEmitter;
            this.builderFactory = builderFactory;
        }

        public void Execute()
        {
            foreach (var @struct in this.structs)
            {
                string path = null;
                string @namespace = "SharpVk";

                if (@struct.Namespace?.Any() ?? false)
                {
                    path = string.Join("\\", @struct.Namespace);
                    @namespace += "." + string.Join(".", @struct.Namespace);
                }

                this.builderFactory.Generate(@struct.Name, path, fileBuilder =>
                {
                    fileBuilder.EmitUsing("System");
                    fileBuilder.EmitUsing("System.Runtime.InteropServices");

                    fileBuilder.EmitNamespace(@namespace, namespaceBuilder =>
                    {
                        namespaceBuilder.EmitType(TypeKind.Struct, @struct.Name, typeBuilder =>
                        {
                            if (@struct.HasZero)
                            {
                                typeBuilder.EmitProperty(@struct.Name, "Zero", ExpressionBuilder.New(@struct.Name), Public, MemberModifier.Static);
                            }

                            if (@struct.Constructor != null)
                            {
                                this.methodEmitter.EmitConstructor(typeBuilder, @struct.Constructor);
                            }

                            if (@struct.Fields != null)
                            {
                                foreach (var member in @struct.Fields)
                                {
                                    typeBuilder.EmitField(member.Type,
                                                            member.Name,
                                                            member.IsPrivate ? Private : Public,
                                                            summary: member.Comment);
                                }
                            }

                            if (@struct.Properties != null)
                            {
                                foreach (var member in @struct.Properties)
                                {
                                    typeBuilder.EmitProperty(member.Type,
                                                            member.Name,
                                                            Public,
                                                            getter: member.IsPrivate ? Private : Public,
                                                            setter: member.IsPrivate ? Private : Public,
                                                            summary: member.Comment);
                                }
                            }

                            if (@struct.Methods != null)
                            {
                                foreach (var method in @struct.Methods)
                                {
                                    this.methodEmitter.Emit(typeBuilder, method);
                                }
                            }
                        }, Public, null, @struct.IsUnsafe ? Unsafe | Partial : Partial, attributes: new[] { "StructLayout(LayoutKind.Sequential)" }, summary: @struct.Comment?.ToArray());
                    });
                });
            }
        }
    }
}
