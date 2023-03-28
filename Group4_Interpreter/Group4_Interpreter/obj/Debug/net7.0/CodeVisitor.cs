﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:\School\CS322\group4-interpreter\Group4_Interpreter\Group4_Interpreter\Interpret\Code.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Group4_Interpreter.Interpret {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="CodeParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface ICodeVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.programStructure"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgramStructure([NotNull] CodeParser.ProgramStructureContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.programLines"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgramLines([NotNull] CodeParser.ProgramLinesContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.programStatements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgramStatements([NotNull] CodeParser.ProgramStatementsContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.variableInitialization"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariableInitialization([NotNull] CodeParser.VariableInitializationContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.assignmentOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignmentOperator([NotNull] CodeParser.AssignmentOperatorContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.beginBlocks"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBeginBlocks([NotNull] CodeParser.BeginBlocksContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.ifCondition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfCondition([NotNull] CodeParser.IfConditionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.elseIfCondition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElseIfCondition([NotNull] CodeParser.ElseIfConditionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.whileLoop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhileLoop([NotNull] CodeParser.WhileLoopContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.programDataTypes"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgramDataTypes([NotNull] CodeParser.ProgramDataTypesContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.constantValues"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstantValues([NotNull] CodeParser.ConstantValuesContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpression([NotNull] CodeParser.ExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.multDivModOperators"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultDivModOperators([NotNull] CodeParser.MultDivModOperatorsContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.addSubConcatenatorOperators"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAddSubConcatenatorOperators([NotNull] CodeParser.AddSubConcatenatorOperatorsContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.comparisonOperators"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComparisonOperators([NotNull] CodeParser.ComparisonOperatorsContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.logicalOperators"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLogicalOperators([NotNull] CodeParser.LogicalOperatorsContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.openParenthesis"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOpenParenthesis([NotNull] CodeParser.OpenParenthesisContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.closeParenthesis"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCloseParenthesis([NotNull] CodeParser.CloseParenthesisContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.methodCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethodCall([NotNull] CodeParser.MethodCallContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.display"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDisplay([NotNull] CodeParser.DisplayContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.scanFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitScanFunction([NotNull] CodeParser.ScanFunctionContext context);
}
} // namespace Group4_Interpreter.Interpret
