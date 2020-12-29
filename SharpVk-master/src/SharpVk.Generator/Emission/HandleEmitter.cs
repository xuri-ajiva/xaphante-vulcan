using SharpVk.Emit;
using SharpVk.Generator.Generation;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;
using System.Linq;

using static SharpVk.Emit.AccessModifier;
using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Emission
{
    class HandleEmitter
        : IOutputWorker
    {
        private readonly IEnumerable<HandleDefinition> handles;
        private readonly MethodEmitter methodEmitter;
        private readonly FileBuilderFactory builderFactory;

        public HandleEmitter(IEnumerable<HandleDefinition> handles, MethodEmitter methodEmitter, FileBuilderFactory builderFactory)
        {
            this.handles = handles;
            this.methodEmitter = methodEmitter;
            this.builderFactory = builderFactory;
        }

        public void Execute()
        {
            foreach (var handle in this.handles)
            {
                string path = null;
                string @namespace = "SharpVk";

                string interopPath = "Interop";
                string interopNamespace = "SharpVk.Interop";
                string parentNamespace = "SharpVk";

                if (handle.Namespace?.Any() ?? false)
                {
                    path = string.Join("\\", handle.Namespace);
                    @namespace += "." + string.Join(".", handle.Namespace);

                    interopPath += "\\" + string.Join("\\", handle.Namespace);
                    interopNamespace += "." + string.Join(".", handle.Namespace);
                }

                if (handle.ParentNamespace?.Any() ?? false)
                {
                    parentNamespace += "." + string.Join(".", handle.ParentNamespace);
                }

                string rawType = handle.IsDispatch ? "UIntPtr" : "ulong";

                this.builderFactory.Generate(handle.Name, interopPath, fileBuilder =>
                {
                    fileBuilder.EmitUsing("System");

                    fileBuilder.EmitNamespace(interopNamespace, namespaceBuilder =>
                    {
                        namespaceBuilder.EmitType(TypeKind.Struct, handle.Name, typeBuilder =>
                        {
                            typeBuilder.EmitField(rawType, "handle", Internal);

                            typeBuilder.EmitConstructor(body =>
                            {
                                body.EmitAssignment(Member(This, "handle"), Variable("handle"));
                            },
                            parameters =>
                            {
                                parameters.EmitParam(rawType, "handle");
                            }, Public);

                            typeBuilder.EmitProperty(handle.Name, "Null", New(handle.Name, Default(rawType)), Public);

                            typeBuilder.EmitMethod("ulong", "ToUInt64", body =>
                            {
                                var returnValue = Member(This, "handle");

                                if (handle.IsDispatch)
                                {
                                    returnValue = Call(returnValue, "ToUInt64");
                                }

                                body.EmitReturn(returnValue);
                            },
                            parameters => { }, Public);
                        }, Public, summary: handle.Comment);
                    });

                });

                this.builderFactory.Generate(handle.Name, path, fileBuilder =>
                {
                    fileBuilder.EmitUsing("System");

                    string interopTypeName = $"{interopNamespace}.{handle.Name}";
                    string parentName = $"{parentNamespace}.{handle.Parent}";

                    fileBuilder.EmitNamespace(@namespace, namespaceBuilder =>
                    {
                        namespaceBuilder.EmitType(TypeKind.Class, handle.Name, typeBuilder =>
                        {
                            typeBuilder.EmitField(interopTypeName, "handle", Internal, MemberModifier.Readonly);
                            typeBuilder.EmitField("CommandCache", "commandCache", Internal, MemberModifier.Readonly);

                            if (handle.Parent != null)
                            {
                                typeBuilder.EmitField(parentName, "parent", Internal, MemberModifier.Readonly);
                            }

                            typeBuilder.EmitConstructor(body =>
                            {
                                body.EmitAssignment(Member(This, "handle"), Variable("handle"));

                                var commandCacheValue = Null;

                                if (handle.Parent != null)
                                {
                                    body.EmitAssignment(Member(This, "parent"), Variable("parent"));
                                    commandCacheValue = Member(Variable("parent"), "commandCache");
                                }
                                else if (handle.Commands.Any())
                                {
                                    commandCacheValue = Variable("commandCache");
                                }

                                if (handle.CommandCacheType != null)
                                {
                                    body.EmitAssignment(Member(This, "commandCache"), New("CommandCache", This, Literal(handle.CommandCacheType), commandCacheValue));
                                    body.EmitCall(Member(This, "commandCache"), "Initialise");
                                }
                                else
                                {
                                    body.EmitAssignment(Member(This, "commandCache"), commandCacheValue);
                                }
                            },
                            parameters =>
                            {
                                if (handle.Parent != null)
                                {
                                    parameters.EmitParam(parentName, "parent");
                                }
                                else if (handle.Commands.Any())
                                {
                                    parameters.EmitParam("CommandCache", "commandCache");
                                }

                                parameters.EmitParam(interopTypeName, "handle");
                            }, Internal);

                            typeBuilder.EmitProperty(interopTypeName, "RawHandle", Member(This, "handle"), Public, summary: new[] { "The raw handle for this instance." });

                            foreach (var command in handle.Commands)
                            {
                                this.methodEmitter.Emit(typeBuilder, command);
                            }
                        }, Public, handle.Interfaces, modifiers: TypeModifier.Partial, summary: handle.Comment);
                    });
                });
            }
        }
    }
}
