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
                    Writer.WriteLine($"[{attributeName}]");

            var fixedLengthSuffix = fixedLength.HasValue ? $"[{fixedLength.Value}]" : "";

            Writer.Write($"{accessModifier.Emit()} {RenderMemberModifiers(methodModifers)}{type} {name}{fixedLengthSuffix}");
            if (initialiser != null)
            {
                Writer.Write(" = ");
                initialiser(new ExpressionBuilder(Writer.GetSubWriter()));
            }
            Writer.WriteLine("; ");
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
                    Writer.WriteLine($"[{attributeName}]");

            var parameterList = parameters != null
                ? ParameterBuilder.Apply(parameters)
                : "";

            Writer.WriteLine($"{accessModifier.Emit()} {RenderMemberModifiers(methodModifers)}{name}({parameterList})");

            if (baseArguments != null)
            {
                Writer.IncreaseIndent();
                Writer.Write(": base(");
                ExpressionBuilder.EmitArguments(Writer, baseArguments);
                Writer.WriteLine(")");
                Writer.DecreaseIndent();
            }

            using (var bodyEmitter = new CodeBlockBuilder(Writer.GetSubWriter()))
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
                    Writer.WriteLine($"[{attributeName}]");

            var parameterList = parameters != null
                ? ParameterBuilder.Apply(parameters)
                : "";

            Writer.Write($"{accessModifier.Emit()} {RenderMemberModifiers(methodModifers)}{returnType} {name}({parameterList})");

            if (methodBody == null)
            {
                Writer.WriteLine(";");
            }
            else
            {
                Writer.WriteLine();

                using (var bodyEmitter = new CodeBlockBuilder(Writer.GetSubWriter()))
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

            Writer.WriteLine($"{accessModifier.Emit()} {RenderMemberModifiers(methodModifers)}{type} {name}");
            Writer.WriteLine("{");
            Writer.IncreaseIndent();

            if (getter != null)
            {
                if (getter.HasValue && getter.Value != accessModifier) Writer.Write(getter.Value.Emit() + " ");
                Writer.WriteLine("get;");
            }

            if (setter != null)
            {
                if (setter.HasValue && setter.Value != accessModifier) Writer.Write(setter.Value.Emit() + " ");
                Writer.WriteLine("set;");
            }

            Writer.DecreaseIndent();
            Writer.WriteLine("}");
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

            Writer.WriteLine($"{accessModifier.Emit()} {RenderMemberModifiers(methodModifers)}{type} {name}");
            Writer.WriteLine("{");
            Writer.IncreaseIndent();

            if (getter != null)
            {
                Writer.WriteLine("get");
                using (var getBuilder = new CodeBlockBuilder(Writer))
                {
                    getter(getBuilder);
                }
            }

            if (setter != null)
            {
                Writer.WriteLine("set");
                using (var setBuilder = new CodeBlockBuilder(Writer))
                {
                    setter(setBuilder);
                }
            }

            Writer.DecreaseIndent();
            Writer.WriteLine("}");
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

            Writer.Write($"{accessModifier.Emit()} {RenderMemberModifiers(methodModifers)}{type} {name} => ");
            getter(new ExpressionBuilder(Writer.GetSubWriter()));
            Writer.WriteLine(";");
        }

        private void EmitMemberComments(AccessModifier accessModifier, IEnumerable<string> summary, Action<DocBuilder> docs)
        {
            if (accessModifier == AccessModifier.Public || summary != null || docs != null)
            {
                var docBuilder = new DocBuilder(Writer.GetSubWriter(), summary);

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
                Writer.WriteLine();
            else
                hasFirstMember = true;
        }
    }
}
