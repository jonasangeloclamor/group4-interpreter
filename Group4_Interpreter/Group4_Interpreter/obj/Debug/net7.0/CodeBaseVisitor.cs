﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:\School\CS322\group4-interpreter\Group4_Interpreter\Group4_Interpreter\Code.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Group4_Interpreter {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ICodeVisitor{Result}"/>,
/// which can be extended to create a visitor which only needs to handle a subset
/// of the available methods.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class CodeBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, ICodeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.programStructure"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitProgramStructure([NotNull] CodeParser.ProgramStructureContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.programLines"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitProgramLines([NotNull] CodeParser.ProgramLinesContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.programStatements"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitProgramStatements([NotNull] CodeParser.ProgramStatementsContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.variableInitialization"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitVariableInitialization([NotNull] CodeParser.VariableInitializationContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.assignmentOperator"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAssignmentOperator([NotNull] CodeParser.AssignmentOperatorContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.beginBlocks"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBeginBlocks([NotNull] CodeParser.BeginBlocksContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.ifCondition"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIfCondition([NotNull] CodeParser.IfConditionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.elseIfCondition"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitElseIfCondition([NotNull] CodeParser.ElseIfConditionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.whileLoop"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitWhileLoop([NotNull] CodeParser.WhileLoopContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.programDataTypes"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitProgramDataTypes([NotNull] CodeParser.ProgramDataTypesContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.constantValues"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitConstantValues([NotNull] CodeParser.ConstantValuesContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExpression([NotNull] CodeParser.ExpressionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.multDivModOperators"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMultDivModOperators([NotNull] CodeParser.MultDivModOperatorsContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.addSubConcatenatorOperators"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAddSubConcatenatorOperators([NotNull] CodeParser.AddSubConcatenatorOperatorsContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.comparisonOperators"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitComparisonOperators([NotNull] CodeParser.ComparisonOperatorsContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.logicalOperators"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitLogicalOperators([NotNull] CodeParser.LogicalOperatorsContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.openParenthesis"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitOpenParenthesis([NotNull] CodeParser.OpenParenthesisContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.closeParenthesis"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCloseParenthesis([NotNull] CodeParser.CloseParenthesisContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.methodCall"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMethodCall([NotNull] CodeParser.MethodCallContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="CodeParser.scanFunction"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitScanFunction([NotNull] CodeParser.ScanFunctionContext context) { return VisitChildren(context); }
}
} // namespace Group4_Interpreter
