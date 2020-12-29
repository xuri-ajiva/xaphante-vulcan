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
            Writer.Write($"{type} {name}");
            if (assignment != null)
            {
                Writer.Write(" = ");
                assignment(GetExpressionBuilder());
            }

            WriteSemicolon();
        }

        public void EmitAssignment(Action<ExpressionBuilder> target, Action<ExpressionBuilder> assignment)
        {
            target(GetExpressionBuilder());
            Writer.Write(" = ");
            assignment(GetExpressionBuilder());

            WriteSemicolon();
        }

        public void EmitThrow(Action<ExpressionBuilder> expression)
        {
            Writer.Write("throw ");
            expression(GetExpressionBuilder());

            WriteSemicolon();
        }

        public void EmitReturn(Action<ExpressionBuilder> expression)
        {
            Writer.Write("return ");
            expression(GetExpressionBuilder());

            WriteSemicolon();
        }

        public void EmitStatement(string statement)
        {
            Writer.Write(statement);

            if (writeSemicolons) Writer.WriteLine();
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
            Writer.Write("for(");
            Writer.WriteCodeBlock(initialiser, false, true);
            Writer.Write("; ");
            condition(GetExpressionBuilder());
            Writer.Write("; ");
            Writer.WriteCodeBlock(afterthought, false, true);
            Writer.WriteLine(")");
            Writer.WriteCodeBlock(loopBlock);
        }

        public void EmitIfBlock(Action<ExpressionBuilder> condition, Action<CodeBlockBuilder> ifBlock)
        {
            Writer.Write("if (");
            condition(GetExpressionBuilder());
            Writer.WriteLine(")");
            using (var ifBlockBuilder = new CodeBlockBuilder(Writer.GetSubWriter()))
            {
                ifBlock(ifBlockBuilder);
            }
        }

        public void EmitIfBlock(Action<ExpressionBuilder> condition, Action<CodeBlockBuilder> ifBlock, Action<CodeBlockBuilder> elseBlock)
        {
            EmitIfBlock(condition, ifBlock);

            Writer.WriteLine("else");
            using (var elseBlockBuilder = new CodeBlockBuilder(Writer.GetSubWriter()))
            {
                elseBlock(elseBlockBuilder);
            }
        }

        public void EmitUnsafeBlock(Action<CodeBlockBuilder> unsafeBlock)
        {
            Writer.WriteLine("unsafe");
            using (var unsafeBlockBuilder = new CodeBlockBuilder(Writer.GetSubWriter()))
            {
                unsafeBlock(unsafeBlockBuilder);
            }
        }

        public void EmitTry(Action<CodeBlockBuilder> tryBlock, Action<CodeBlockBuilder> finallyBlock)
        {
            Writer.WriteLine("try");
            using (var blockBuilder = new CodeBlockBuilder(Writer.GetSubWriter()))
            {
                tryBlock(blockBuilder);
            }
            Writer.WriteLine("finally");
            using (var blockBuilder = new CodeBlockBuilder(Writer.GetSubWriter()))
            {
                finallyBlock(blockBuilder);
            }
        }

        public void EmitSwitchBlock(Action<ExpressionBuilder> target, Action<SwitchCaseBuilder> caseBuilder)
        {
            Writer.Write("switch (");
            target(GetExpressionBuilder());
            Writer.WriteLine(")");
            using (var switchBlockBuilder = new SwitchCaseBuilder(Writer.GetSubWriter()))
            {
                caseBuilder(switchBlockBuilder);
            }
        }

        private void WriteSemicolon()
        {
            if (writeSemicolons) Writer.WriteLine(";");
        }

        private ExpressionBuilder GetExpressionBuilder()
        {
            return new ExpressionBuilder(Writer.GetSubWriter());
        }
    }
}
