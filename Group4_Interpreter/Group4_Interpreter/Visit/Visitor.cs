using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;
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
