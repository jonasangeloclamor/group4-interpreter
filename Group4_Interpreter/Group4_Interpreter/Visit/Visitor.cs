﻿using Antlr4.Runtime.Misc;
using Group4_Interpreter.Interpret;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group4_Interpreter.Visit
{
    public class Visitor : CodeBaseVisitor<object?>
    {
        public Dictionary<string, object?> Variables { get; } = new();
        public override object? VisitProgramStructure([NotNull] CodeParser.ProgramStructureContext context)
        {
            string code = context.GetText().Trim();
            if (code.StartsWith("BEGIN CODE") && code.EndsWith("END CODE"))
            {
                // Visit each statement in the code
                foreach (var statementContext in context.programLines())
                {
                    VisitProgramLines(statementContext);
                }
            }
            else
            {
                Console.WriteLine("Code must start with 'BEGIN CODE' and end with 'END CODE'.");
            }

            return null;
        }

        public override object? VisitProgramLines([NotNull] CodeParser.ProgramLinesContext context)
        {
            return base.VisitProgramLines(context);
        }

        public override object VisitProgramStatements([NotNull] CodeParser.ProgramStatementsContext context)
        {
            return base.VisitProgramStatements(context);
        }

        public override object? VisitVariableInitialization([NotNull] CodeParser.VariableInitializationContext context)
        {
            var dataType = context.programDataTypes().GetText();
            var variableName = context.IDENTIFIERS().Select(id => id.GetText()).ToArray();
            var variableValue = Visit(context.expression());
            foreach(var name in variableName)
            {
                //something something
            }
            return base.VisitVariableInitialization(context);
        }

        public override object? VisitAssignmentOperator([NotNull] CodeParser.AssignmentOperatorContext context)
        {
            var dataType = context.programDataTypes().GetText();
            var variableName = context.IDENTIFIERS().GetText();
            var variableValue = Visit(context.expression());

            return Variables[variableName] = variableValue;
            //kuwang ug error handling pa
        }

        public override object VisitBeginBlocks([NotNull] CodeParser.BeginBlocksContext context)
        {
            return base.VisitBeginBlocks(context);
        }

        public override object VisitIfCondition([NotNull] CodeParser.IfConditionContext context)
        {
            return base.VisitIfCondition(context);
        }

        public override object? VisitDisplay([NotNull] CodeParser.DisplayContext context)
        {
            foreach (var variable in Variables)
            {
                Console.WriteLine("{0}", variable.Value);
                break;
            }
            Console.WriteLine();
            return null;
        }
    }
}