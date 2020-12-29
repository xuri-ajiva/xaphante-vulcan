using System;

namespace SharpVk.Emit
{
    public class CodeBlockBuilder
        : BlockBuilder
    {
        private readonly bool writeSemicolons;

        public CodeBlockBuilder(IndentedTextWriter writer, bool hasBraces = true, bool writeSemicolons = true)
            : base(writer, hasBraces)
        {
            this.writeSemicolons = writeSemicolons;
        }

        public void EmitVariableDeclaration(string type, string name, Action<ExpressionBuilder> assignment = null)
        {
            writer.Write($"{type} {name}");
            if (assignment != null)
            {
                writer.Write(" = ");
                assignment(GetExpressionBuilder());
            }

            WriteSemicolon();
        }

        public void EmitAssignment(Action<ExpressionBuilder> target, Action<ExpressionBuilder> assignment)
        {
            target(GetExpressionBuilder());
            writer.Write(" = ");
            assignment(GetExpressionBuilder());

            WriteSemicolon();
        }

        public void EmitThrow(Action<ExpressionBuilder> expression)
        {
            writer.Write("throw ");
            expression(GetExpressionBuilder());

            WriteSemicolon();
        }

        public void EmitReturn(Action<ExpressionBuilder> expression)
        {
            writer.Write("return ");
            expression(GetExpressionBuilder());

            WriteSemicolon();
        }

        public void EmitStatement(string statement)
        {
            writer.Write(statement);

            if (writeSemicolons) writer.WriteLine();
        }

        public void EmitCallExpression(Action<ExpressionBuilder> expression)
        {
            expression(GetExpressionBuilder());

            WriteSemicolon();
        }

        public void EmitStaticCall(string type, string method, params Action<ExpressionBuilder>[] arguments)
        {
            EmitCallExpression(ExpressionBuilder.StaticCall(type, method, arguments));
        }

        public void EmitDelegateCall(Action<ExpressionBuilder> @delegate, params Action<ExpressionBuilder>[] arguments)
        {
            GetExpressionBuilder().EmitDelegateCall(@delegate, arguments);

            WriteSemicolon();
        }

        public void EmitCall(Action<ExpressionBuilder> target, string method, params Action<ExpressionBuilder>[] arguments)
        {
            GetExpressionBuilder().EmitCall(target, method, arguments);

            WriteSemicolon();
        }

        public void EmitForLoop(Action<CodeBlockBuilder> initialiser, Action<ExpressionBuilder> condition, Action<CodeBlockBuilder> afterthought, Action<CodeBlockBuilder> loopBlock)
        {
            writer.Write("for(");
            writer.WriteCodeBlock(initialiser, false, true);
            writer.Write("; ");
            condition(GetExpressionBuilder());
            writer.Write("; ");
            writer.WriteCodeBlock(afterthought, false, true);
            writer.WriteLine(")");
            writer.WriteCodeBlock(loopBlock);
        }

        public void EmitIfBlock(Action<ExpressionBuilder> condition, Action<CodeBlockBuilder> ifBlock)
        {
            writer.Write("if (");
            condition(GetExpressionBuilder());
            writer.WriteLine(")");
            using (var ifBlockBuilder = new CodeBlockBuilder(writer.GetSubWriter()))
            {
                ifBlock(ifBlockBuilder);
            }
        }

        public void EmitIfBlock(Action<ExpressionBuilder> condition, Action<CodeBlockBuilder> ifBlock, Action<CodeBlockBuilder> elseBlock)
        {
            EmitIfBlock(condition, ifBlock);

            writer.WriteLine("else");
            using (var elseBlockBuilder = new CodeBlockBuilder(writer.GetSubWriter()))
            {
                elseBlock(elseBlockBuilder);
            }
        }

        public void EmitUnsafeBlock(Action<CodeBlockBuilder> unsafeBlock)
        {
            writer.WriteLine("unsafe");
            using (var unsafeBlockBuilder = new CodeBlockBuilder(writer.GetSubWriter()))
            {
                unsafeBlock(unsafeBlockBuilder);
            }
        }

        public void EmitTry(Action<CodeBlockBuilder> tryBlock, Action<CodeBlockBuilder> finallyBlock)
        {
            writer.WriteLine("try");
            using (var blockBuilder = new CodeBlockBuilder(writer.GetSubWriter()))
            {
                tryBlock(blockBuilder);
            }
            writer.WriteLine("finally");
            using (var blockBuilder = new CodeBlockBuilder(writer.GetSubWriter()))
            {
                finallyBlock(blockBuilder);
            }
        }

        public void EmitSwitchBlock(Action<ExpressionBuilder> target, Action<SwitchCaseBuilder> caseBuilder)
        {
            writer.Write("switch (");
            target(GetExpressionBuilder());
            writer.WriteLine(")");
            using (var switchBlockBuilder = new SwitchCaseBuilder(writer.GetSubWriter()))
            {
                caseBuilder(switchBlockBuilder);
            }
        }

        private void WriteSemicolon()
        {
            if (writeSemicolons) writer.WriteLine(";");
        }

        private ExpressionBuilder GetExpressionBuilder()
        {
            return new ExpressionBuilder(writer.GetSubWriter());
        }
    }
}