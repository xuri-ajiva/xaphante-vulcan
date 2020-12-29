using System;
using System.Collections.Generic;
using System.Text;

namespace SharpVk.Emit
{
    public class TypeBuilder
        : BlockBuilder
    {
        private readonly string name;

        private bool hasFirstMember;

        public TypeBuilder(IndentedTextWriter writer, string name)
            : base(writer)
        {
            this.name = name;
        }

        public void EmitField(string type,
            string name,
            AccessModifier accessModifier = AccessModifier.Private,
            MemberModifier methodModifers = MemberModifier.None,
            Action<ExpressionBuilder> initialiser = null,
            int? fixedLength = null,
            IEnumerable<string> summary = null,
            Action<DocBuilder> docs = null,
            IEnumerable<string> attributes = null)
        {
            EmitMemberSpacing();

            EmitMemberComments(accessModifier, summary, docs);

            if (attributes != null)
                foreach (var attributeName in attributes)
                    writer.WriteLine($"[{attributeName}]");

            var fixedLengthSuffix = fixedLength.HasValue ? $"[{fixedLength.Value}]" : "";

            writer.Write($"{accessModifier.Emit()} {RenderMemberModifiers(methodModifers)}{type} {name}{fixedLengthSuffix}");
            if (initialiser != null)
            {
                writer.Write(" = ");
                initialiser(new ExpressionBuilder(writer.GetSubWriter()));
            }
            writer.WriteLine("; ");
        }

        public void EmitConstructor(Action<CodeBlockBuilder> methodBody,
            Action<ParameterBuilder> parameters,
            AccessModifier accessModifier = AccessModifier.Private,
            MemberModifier methodModifers = MemberModifier.None,
            IEnumerable<Action<ExpressionBuilder>> baseArguments = null,
            IEnumerable<string> summary = null,
            Action<DocBuilder> docs = null,
            IEnumerable<string> attributes = null)
        {
            EmitMemberSpacing();

            EmitMemberComments(accessModifier, summary, docs);

            if (attributes != null)
                foreach (var attributeName in attributes)
                    writer.WriteLine($"[{attributeName}]");

            var parameterList = parameters != null
                ? ParameterBuilder.Apply(parameters)
                : "";

            writer.WriteLine($"{accessModifier.Emit()} {RenderMemberModifiers(methodModifers)}{name}({parameterList})");

            if (baseArguments != null)
            {
                writer.IncreaseIndent();
                writer.Write(": base(");
                ExpressionBuilder.EmitArguments(writer, baseArguments);
                writer.WriteLine(")");
                writer.DecreaseIndent();
            }

            using (var bodyEmitter = new CodeBlockBuilder(writer.GetSubWriter()))
            {
                methodBody(bodyEmitter);
            }
        }

        public void EmitMethod(string returnType,
            string name,
            Action<CodeBlockBuilder> methodBody,
            Action<ParameterBuilder> parameters,
            AccessModifier accessModifier = AccessModifier.Private,
            MemberModifier methodModifers = MemberModifier.None,
            IEnumerable<string> summary = null,
            Action<DocBuilder> docs = null,
            IEnumerable<string> attributes = null)
        {
            EmitMemberSpacing();

            EmitMemberComments(accessModifier, summary, docs);

            if (attributes != null)
                foreach (var attributeName in attributes)
                    writer.WriteLine($"[{attributeName}]");

            var parameterList = parameters != null
                ? ParameterBuilder.Apply(parameters)
                : "";

            writer.Write($"{accessModifier.Emit()} {RenderMemberModifiers(methodModifers)}{returnType} {name}({parameterList})");

            if (methodBody == null)
            {
                writer.WriteLine(";");
            }
            else
            {
                writer.WriteLine();

                using (var bodyEmitter = new CodeBlockBuilder(writer.GetSubWriter()))
                {
                    methodBody(bodyEmitter);
                }
            }
        }

        public void EmitProperty(string type,
            string name,
            AccessModifier accessModifier = AccessModifier.Private,
            MemberModifier methodModifers = MemberModifier.None,
            AccessModifier? getter = null,
            AccessModifier? setter = null,
            IEnumerable<string> summary = null,
            Action<DocBuilder> docs = null)
        {
            EmitMemberSpacing();

            EmitMemberComments(accessModifier, summary, docs);

            writer.WriteLine($"{accessModifier.Emit()} {RenderMemberModifiers(methodModifers)}{type} {name}");
            writer.WriteLine("{");
            writer.IncreaseIndent();

            if (getter != null)
            {
                if (getter.HasValue && getter.Value != accessModifier) writer.Write(getter.Value.Emit() + " ");
                writer.WriteLine("get;");
            }

            if (setter != null)
            {
                if (setter.HasValue && setter.Value != accessModifier) writer.Write(setter.Value.Emit() + " ");
                writer.WriteLine("set;");
            }

            writer.DecreaseIndent();
            writer.WriteLine("}");
        }

        public void EmitProperty(string type,
            string name,
            AccessModifier accessModifier = AccessModifier.Private,
            MemberModifier methodModifers = MemberModifier.None,
            Action<CodeBlockBuilder> getter = null,
            Action<CodeBlockBuilder> setter = null,
            IEnumerable<string> summary = null,
            Action<DocBuilder> docs = null)
        {
            EmitMemberSpacing();

            EmitMemberComments(accessModifier, summary, docs);

            writer.WriteLine($"{accessModifier.Emit()} {RenderMemberModifiers(methodModifers)}{type} {name}");
            writer.WriteLine("{");
            writer.IncreaseIndent();

            if (getter != null)
            {
                writer.WriteLine("get");
                using (var getBuilder = new CodeBlockBuilder(writer))
                {
                    getter(getBuilder);
                }
            }

            if (setter != null)
            {
                writer.WriteLine("set");
                using (var setBuilder = new CodeBlockBuilder(writer))
                {
                    setter(setBuilder);
                }
            }

            writer.DecreaseIndent();
            writer.WriteLine("}");
        }

        public void EmitProperty(string type,
            string name,
            Action<ExpressionBuilder> getter,
            AccessModifier accessModifier = AccessModifier.Private,
            MemberModifier methodModifers = MemberModifier.None,
            IEnumerable<string> summary = null,
            Action<DocBuilder> docs = null)
        {
            EmitMemberSpacing();

            EmitMemberComments(accessModifier, summary, docs);

            writer.Write($"{accessModifier.Emit()} {RenderMemberModifiers(methodModifers)}{type} {name} => ");
            getter(new ExpressionBuilder(writer.GetSubWriter()));
            writer.WriteLine(";");
        }

        private void EmitMemberComments(AccessModifier accessModifier, IEnumerable<string> summary, Action<DocBuilder> docs)
        {
            if (accessModifier == AccessModifier.Public || summary != null || docs != null)
            {
                var docBuilder = new DocBuilder(writer.GetSubWriter(), summary);

                docs?.Invoke(docBuilder);
            }
        }

        private string RenderMemberModifiers(MemberModifier modifiers)
        {
            var builder = new StringBuilder();

            foreach (MemberModifier value in Enum.GetValues(typeof(MemberModifier)))
                if (value != MemberModifier.None && modifiers.HasFlag(value))
                    builder.Append(value.ToString().ToLowerInvariant() + " ");

            return builder.ToString();
        }

        private void EmitMemberSpacing()
        {
            if (hasFirstMember)
                writer.WriteLine();
            else
                hasFirstMember = true;
        }
    }
}