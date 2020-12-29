using System;
using System.Collections.Generic;

namespace SharpVk.Emit
{
    public class ExpressionBuilder
    {
        private readonly IndentedTextWriter writer;

        public ExpressionBuilder(IndentedTextWriter writer)
        {
            this.writer = writer;
        }

        public static Action<ExpressionBuilder> Null
        {
            get
            {
                return builder => builder.EmitNull();
            }
        }

        public static Action<ExpressionBuilder> This
        {
            get
            {
                return builder => builder.EmitThis();
            }
        }

        public void EmitAsIs(string expression)
        {
            writer.Write(expression);
        }

        public void EmitLiteral(char prefix, string literal)
        {
            writer.Write(prefix);
            writer.Write('"');
            writer.Write(literal);
            writer.Write('"');
        }

        public void EmitLiteral(string literal)
        {
            writer.Write('"');
            writer.Write(literal);
            writer.Write('"');
        }

        public void EmitLiteral(int literal)
        {
            writer.Write(literal);
        }

        public void EmitLiteral(bool literal)
        {
            writer.Write(literal ? "true" : "false");
        }

        public void EmitArrayInit(string elementTypeName, params Action<ExpressionBuilder>[] elements)
        {
            writer.WriteLine($"new {elementTypeName}[]");
            writer.Write("{");
            writer.IncreaseIndent();
            var isFirstElement = true;
            foreach (var element in elements)
            {
                if (!isFirstElement)
                    writer.WriteLine(",");
                else
                    isFirstElement = false;

                element(new ExpressionBuilder(writer.GetSubWriter()));
            }
            writer.DecreaseIndent();
            writer.WriteLine();
            writer.Write("}");
        }

        public void EmitMemberInit(string name, Action<MemberInitBuilder> members)
        {
            writer.WriteLine($"new {name}");
            writer.Write("{");
            writer.IncreaseIndent();
            members(new MemberInitBuilder(writer.GetSubWriter()));
            writer.DecreaseIndent();
            writer.WriteLine();
            writer.Write("}");
        }

        public void EmitNew(string name, params Action<ExpressionBuilder>[] arguments)
        {
            writer.Write($"new {name}(");
            EmitArguments(arguments);
            writer.Write(")");
        }

        public void EmitNewArray(string name, params Action<ExpressionBuilder>[] arguments)
        {
            writer.Write($"new {name}[");
            EmitArguments(arguments);
            writer.Write("]");
        }

        public void EmitNewValueTuple(params Action<ExpressionBuilder>[] items)
        {
            writer.Write("(");
            EmitArguments(items);
            writer.Write(")");
        }

        public void EmitDefault(string type)
        {
            writer.Write($"default({type})");
        }

        public void EmitDefault()
        {
            writer.Write("default");
        }

        public void EmitNull()
        {
            writer.Write("null");
        }

        public void EmitThis()
        {
            writer.Write("this");
        }

        public void EmitVariable(string name)
        {
            writer.Write(name);
        }

        public void EmitCast(string type, Action<ExpressionBuilder> target)
        {
            writer.Write($"({type})(");
            target(GetSubBuilder());
            writer.Write(")");
        }

        public void EmitCastAs(string type, Action<ExpressionBuilder> target)
        {
            writer.Write("((");
            target(GetSubBuilder());
            writer.Write(") as {type})");
        }

        public void EmitStaticCall(string type, string method, params Action<ExpressionBuilder>[] arguments)
        {
            writer.Write($"{type}.{method}(");

            EmitArguments(arguments);

            writer.Write(")");
        }

        public void EmitDelegateCall(Action<ExpressionBuilder> @delegate, params Action<ExpressionBuilder>[] arguments)
        {
            @delegate(GetSubBuilder());

            writer.Write("(");

            EmitArguments(arguments);

            writer.Write(")");
        }

        public void EmitCall(Action<ExpressionBuilder> target, string method, params Action<ExpressionBuilder>[] arguments)
        {
            target(GetSubBuilder());

            writer.Write($".{method}(");

            EmitArguments(arguments);

            writer.Write(")");
        }

        public void EmitMember(Action<ExpressionBuilder> target, params string[] members)
        {
            target(GetSubBuilder());

            foreach (var member in members) writer.Write($".{member}");
        }

        public void EmitCoalesceMember(Action<ExpressionBuilder> target, string member)
        {
            target(GetSubBuilder());

            writer.Write($"?.{member}");
        }

        public void EmitIndex(Action<ExpressionBuilder> target, Action<ExpressionBuilder> index)
        {
            target(GetSubBuilder());

            writer.Write("[");

            index(GetSubBuilder());

            writer.Write("]");
        }

        public void EmitDeref(Action<ExpressionBuilder> target)
        {
            writer.Write("*");
            target(GetSubBuilder());
        }

        public void EmitDerefMember(Action<ExpressionBuilder> target, string member)
        {
            target(GetSubBuilder());

            writer.Write($"->{member}");
        }

        public void EmitAddressOf(Action<ExpressionBuilder> value)
        {
            writer.Write("&");

            value(GetSubBuilder());
        }

        public void EmitBrackets(Action<ExpressionBuilder> value)
        {
            writer.Write("(");

            value(GetSubBuilder());

            writer.Write(")");
        }

        public void EmitCoalesce(Action<ExpressionBuilder> left, Action<ExpressionBuilder> right)
        {
            left(GetSubBuilder());

            writer.Write(" ?? ");

            right(GetSubBuilder());
        }

        public void EmitIsEqual(Action<ExpressionBuilder> left, Action<ExpressionBuilder> right)
        {
            left(GetSubBuilder());

            writer.Write(" == ");

            right(GetSubBuilder());
        }

        public void EmitIsNotEqual(Action<ExpressionBuilder> left, Action<ExpressionBuilder> right)
        {
            left(GetSubBuilder());

            writer.Write(" != ");

            right(GetSubBuilder());
        }

        public void EmitGreaterThan(Action<ExpressionBuilder> left, Action<ExpressionBuilder> right)
        {
            left(GetSubBuilder());

            writer.Write(" > ");

            right(GetSubBuilder());
        }

        public void EmitGreaterThanEqualTo(Action<ExpressionBuilder> left, Action<ExpressionBuilder> right)
        {
            left(GetSubBuilder());

            writer.Write(" >= ");

            right(GetSubBuilder());
        }

        public void EmitLessThan(Action<ExpressionBuilder> left, Action<ExpressionBuilder> right)
        {
            left(GetSubBuilder());

            writer.Write(" < ");

            right(GetSubBuilder());
        }

        public void EmitLessThanEqualTo(Action<ExpressionBuilder> left, Action<ExpressionBuilder> right)
        {
            left(GetSubBuilder());

            writer.Write(" <= ");

            right(GetSubBuilder());
        }

        public void EmitShiftLeft(Action<ExpressionBuilder> left, Action<ExpressionBuilder> right)
        {
            left(GetSubBuilder());

            writer.Write(" << ");

            right(GetSubBuilder());
        }

        public void EmitShiftRight(Action<ExpressionBuilder> left, Action<ExpressionBuilder> right)
        {
            left(GetSubBuilder());

            writer.Write(" >> ");

            right(GetSubBuilder());
        }

        public void EmitMultiply(Action<ExpressionBuilder> left, Action<ExpressionBuilder> right)
        {
            left(GetSubBuilder());

            writer.Write(" * ");

            right(GetSubBuilder());
        }

        public void EmitDivide(Action<ExpressionBuilder> left, Action<ExpressionBuilder> right)
        {
            left(GetSubBuilder());

            writer.Write(" / ");

            right(GetSubBuilder());
        }

        public void EmitNot(Action<ExpressionBuilder> target)
        {
            writer.Write("!");

            target(GetSubBuilder());
        }

        public void EmitLogicalAnd(Action<ExpressionBuilder> left, Action<ExpressionBuilder> right)
        {
            left(GetSubBuilder());

            writer.Write(" && ");

            right(GetSubBuilder());
        }

        public void EmitEnumField(string type, string field)
        {
            writer.Write($"{type}.{field}");
        }

        private void EmitArguments(IEnumerable<Action<ExpressionBuilder>> arguments)
        {
            EmitArguments(writer, arguments);
        }

        private ExpressionBuilder GetSubBuilder()
        {
            return new ExpressionBuilder(writer.GetSubWriter());
        }

        public static Action<ExpressionBuilder> AsIs(string expression)
        {
            return builder => builder.EmitAsIs(expression);
        }

        public static void EmitArguments(IndentedTextWriter writer, IEnumerable<Action<ExpressionBuilder>> arguments)
        {
            var isFirstArgument = true;

            foreach (var argument in arguments)
            {
                if (isFirstArgument)
                    isFirstArgument = false;
                else
                    writer.Write(", ");

                argument(new ExpressionBuilder(writer.GetSubWriter()));
            }
        }

        public static Action<ExpressionBuilder> Literal(char prefix, string literal)
        {
            return builder => builder.EmitLiteral(prefix, literal);
        }

        public static Action<ExpressionBuilder> Literal(string literal)
        {
            return builder => builder.EmitLiteral(literal);
        }

        public static Action<ExpressionBuilder> Literal(int literal)
        {
            return builder => builder.EmitLiteral(literal);
        }

        public static Action<ExpressionBuilder> Literal(bool literal)
        {
            return builder => builder.EmitLiteral(literal);
        }

        public static Action<ExpressionBuilder> ArrayInit(string elementTypeName, params Action<ExpressionBuilder>[] elements)
        {
            return builder => builder.EmitArrayInit(elementTypeName, elements);
        }

        public static Action<ExpressionBuilder> MemberInit(string name, Action<MemberInitBuilder> members)
        {
            return builder => builder.EmitMemberInit(name, members);
        }

        public static Action<ExpressionBuilder> New(string name, params Action<ExpressionBuilder>[] arguments)
        {
            return builder => builder.EmitNew(name, arguments);
        }

        public static Action<ExpressionBuilder> NewArray(string name, params Action<ExpressionBuilder>[] arguments)
        {
            return builder => builder.EmitNewArray(name, arguments);
        }

        public static Action<ExpressionBuilder> NewValueTuple(params Action<ExpressionBuilder>[] items)
        {
            return builder => builder.EmitNewValueTuple(items);
        }

        public static Action<ExpressionBuilder> Default(string type)
        {
            return builder => builder.EmitDefault(type);
        }

        public static Action<ExpressionBuilder> Default()
        {
            return builder => builder.EmitDefault();
        }

        public static Action<ExpressionBuilder> Variable(string name)
        {
            return builder => builder.EmitVariable(name);
        }

        public static Action<ExpressionBuilder> Cast(string type, Action<ExpressionBuilder> target)
        {
            return builder => builder.EmitCast(type, target);
        }

        public static Action<ExpressionBuilder> CastAs(string type, Action<ExpressionBuilder> target)
        {
            return builder => builder.EmitCastAs(type, target);
        }

        public static Action<ExpressionBuilder> StaticCall(string type, string method, params Action<ExpressionBuilder>[] arguments)
        {
            return builder => builder.EmitStaticCall(type, method, arguments);
        }

        public static Action<ExpressionBuilder> DelegateCall(Action<ExpressionBuilder> @delegate, params Action<ExpressionBuilder>[] arguments)
        {
            return builder => builder.EmitDelegateCall(@delegate, arguments);
        }

        public static Action<ExpressionBuilder> Call(Action<ExpressionBuilder> target, string method, params Action<ExpressionBuilder>[] arguments)
        {
            return builder => builder.EmitCall(target, method, arguments);
        }

        public static Action<ExpressionBuilder> Index(Action<ExpressionBuilder> target, Action<ExpressionBuilder> index)
        {
            return builder => builder.EmitIndex(target, index);
        }

        public static Action<ExpressionBuilder> Member(Action<ExpressionBuilder> target, params string[] members)
        {
            return builder => builder.EmitMember(target, members);
        }

        public static Action<ExpressionBuilder> CoalesceMember(Action<ExpressionBuilder> target, string member)
        {
            return builder => builder.EmitCoalesceMember(target, member);
        }

        public static Action<ExpressionBuilder> Deref(Action<ExpressionBuilder> target)
        {
            return builder => builder.EmitDeref(target);
        }

        public static Action<ExpressionBuilder> DerefMember(Action<ExpressionBuilder> target, string member)
        {
            return builder => builder.EmitDerefMember(target, member);
        }

        public static Action<ExpressionBuilder> AddressOf(Action<ExpressionBuilder> value)
        {
            return builder => builder.EmitAddressOf(value);
        }

        public static Action<ExpressionBuilder> Brackets(Action<ExpressionBuilder> value)
        {
            return builder => builder.EmitBrackets(value);
        }

        public static Action<ExpressionBuilder> Coalesce(Action<ExpressionBuilder> left, Action<ExpressionBuilder> right)
        {
            return builder => builder.EmitCoalesce(left, right);
        }

        public static Action<ExpressionBuilder> IsEqual(Action<ExpressionBuilder> left, Action<ExpressionBuilder> right)
        {
            return builder => builder.EmitIsEqual(left, right);
        }

        public static Action<ExpressionBuilder> IsNotEqual(Action<ExpressionBuilder> left, Action<ExpressionBuilder> right)
        {
            return builder => builder.EmitIsNotEqual(left, right);
        }

        public static Action<ExpressionBuilder> GreaterThan(Action<ExpressionBuilder> left, Action<ExpressionBuilder> right)
        {
            return builder => builder.EmitGreaterThan(left, right);
        }

        public static Action<ExpressionBuilder> GreaterThanEqualTo(Action<ExpressionBuilder> left, Action<ExpressionBuilder> right)
        {
            return builder => builder.EmitGreaterThanEqualTo(left, right);
        }

        public static Action<ExpressionBuilder> LessThan(Action<ExpressionBuilder> left, Action<ExpressionBuilder> right)
        {
            return builder => builder.EmitLessThan(left, right);
        }

        public static Action<ExpressionBuilder> LessThanEqualTo(Action<ExpressionBuilder> left, Action<ExpressionBuilder> right)
        {
            return builder => builder.EmitLessThanEqualTo(left, right);
        }

        public static Action<ExpressionBuilder> ShiftLeft(Action<ExpressionBuilder> left, Action<ExpressionBuilder> right)
        {
            return builder => builder.EmitShiftLeft(left, right);
        }

        public static Action<ExpressionBuilder> ShiftRight(Action<ExpressionBuilder> left, Action<ExpressionBuilder> right)
        {
            return builder => builder.EmitShiftRight(left, right);
        }

        public static Action<ExpressionBuilder> Multiply(Action<ExpressionBuilder> left, Action<ExpressionBuilder> right)
        {
            return builder => builder.EmitMultiply(left, right);
        }

        public static Action<ExpressionBuilder> Divide(Action<ExpressionBuilder> left, Action<ExpressionBuilder> right)
        {
            return builder => builder.EmitDivide(left, right);
        }

        public static Action<ExpressionBuilder> Not(Action<ExpressionBuilder> target)
        {
            return builder => builder.EmitNot(target);
        }

        public static Action<ExpressionBuilder> LogicalAnd(Action<ExpressionBuilder> left, Action<ExpressionBuilder> right)
        {
            return builder => builder.EmitLogicalAnd(left, right);
        }

        public static Action<ExpressionBuilder> EnumField(string type, string field)
        {
            return builder => builder.EmitEnumField(type, field);
        }
    }
}