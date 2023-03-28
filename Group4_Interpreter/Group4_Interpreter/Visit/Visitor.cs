using Antlr4.Runtime.Misc;
using Group4_Interpreter.Interpret;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group4_Interpreter.Visit
{
    public class Visitor : CodeBaseVisitor<object?>
    {
        public Dictionary<string, object?> Variables { get; } = new();
        public override object VisitProgramStructure([NotNull] CodeParser.ProgramStructureContext context)
        {
            string beginDelimiter = "BEGIN CODE";
            string endDelimiter = "END CODE";
            string? beginCode = context.BEGIN_CODE()?.GetText();
            string? endCode = context.END_CODE()?.GetText();
            string code = context.GetText().Trim();
            
            if (beginCode != beginDelimiter || endCode != endDelimiter)
            {
                throw new Exception("Invalid code delimiters");
            }
            
            if (code.StartsWith(beginDelimiter) && code.EndsWith(endDelimiter))
            {
                Console.WriteLine("Code is valid");
            }
            else
            {
                throw new Exception("Code must start with 'BEGIN CODE' and end with 'END CODE'");
            }
            return base.VisitProgramStructure(context);
        }

        public override object VisitProgramLines([NotNull] CodeParser.ProgramLinesContext context)
        {
            return base.VisitProgramLines(context);
        }

        public override object VisitProgramStatements([NotNull] CodeParser.ProgramStatementsContext context)
        {
            return base.VisitProgramStatements(context);
        }

        public override object VisitVariableInitialization([NotNull] CodeParser.VariableInitializationContext context)
        {
            return base.VisitVariableInitialization(context);
        }

        public override object VisitAssignmentOperator([NotNull] CodeParser.AssignmentOperatorContext context)
        {
            return base.VisitAssignmentOperator(context);
        }

        public override object VisitBeginBlocks([NotNull] CodeParser.BeginBlocksContext context)
        {
            return base.VisitBeginBlocks(context);
        }

        public override object VisitIfCondition([NotNull] CodeParser.IfConditionContext context)
        {
            return base.VisitIfCondition(context);
        }
    }
}
