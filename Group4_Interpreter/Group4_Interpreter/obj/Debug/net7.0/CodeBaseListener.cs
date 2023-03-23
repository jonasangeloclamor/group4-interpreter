//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:\Group4_Interpreter\Group4_Interpreter\Code.g4 by ANTLR 4.6.6

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
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ICodeListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class CodeBaseListener : ICodeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.programStructure"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProgramStructure([NotNull] CodeParser.ProgramStructureContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.programStructure"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProgramStructure([NotNull] CodeParser.ProgramStructureContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.programLines"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProgramLines([NotNull] CodeParser.ProgramLinesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.programLines"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProgramLines([NotNull] CodeParser.ProgramLinesContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.programStatements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProgramStatements([NotNull] CodeParser.ProgramStatementsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.programStatements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProgramStatements([NotNull] CodeParser.ProgramStatementsContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.variableInitialization"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariableInitialization([NotNull] CodeParser.VariableInitializationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.variableInitialization"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariableInitialization([NotNull] CodeParser.VariableInitializationContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.assignmentOperator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignmentOperator([NotNull] CodeParser.AssignmentOperatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.assignmentOperator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignmentOperator([NotNull] CodeParser.AssignmentOperatorContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.beginBlocks"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBeginBlocks([NotNull] CodeParser.BeginBlocksContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.beginBlocks"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBeginBlocks([NotNull] CodeParser.BeginBlocksContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.ifCondition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIfCondition([NotNull] CodeParser.IfConditionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.ifCondition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIfCondition([NotNull] CodeParser.IfConditionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.elseIfCondition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterElseIfCondition([NotNull] CodeParser.ElseIfConditionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.elseIfCondition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitElseIfCondition([NotNull] CodeParser.ElseIfConditionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.whileLoop"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhileLoop([NotNull] CodeParser.WhileLoopContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.whileLoop"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhileLoop([NotNull] CodeParser.WhileLoopContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.programDataTypes"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProgramDataTypes([NotNull] CodeParser.ProgramDataTypesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.programDataTypes"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProgramDataTypes([NotNull] CodeParser.ProgramDataTypesContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.constantValues"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstantValues([NotNull] CodeParser.ConstantValuesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.constantValues"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstantValues([NotNull] CodeParser.ConstantValuesContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpression([NotNull] CodeParser.ExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpression([NotNull] CodeParser.ExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.multDivModOperators"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMultDivModOperators([NotNull] CodeParser.MultDivModOperatorsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.multDivModOperators"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMultDivModOperators([NotNull] CodeParser.MultDivModOperatorsContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.addSubConcatenatorOperators"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAddSubConcatenatorOperators([NotNull] CodeParser.AddSubConcatenatorOperatorsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.addSubConcatenatorOperators"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAddSubConcatenatorOperators([NotNull] CodeParser.AddSubConcatenatorOperatorsContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.comparisonOperators"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComparisonOperators([NotNull] CodeParser.ComparisonOperatorsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.comparisonOperators"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComparisonOperators([NotNull] CodeParser.ComparisonOperatorsContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.logicalOperators"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogicalOperators([NotNull] CodeParser.LogicalOperatorsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.logicalOperators"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogicalOperators([NotNull] CodeParser.LogicalOperatorsContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.openParenthesis"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpenParenthesis([NotNull] CodeParser.OpenParenthesisContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.openParenthesis"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpenParenthesis([NotNull] CodeParser.OpenParenthesisContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.closeParenthesis"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCloseParenthesis([NotNull] CodeParser.CloseParenthesisContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.closeParenthesis"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCloseParenthesis([NotNull] CodeParser.CloseParenthesisContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.methodCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethodCall([NotNull] CodeParser.MethodCallContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.methodCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethodCall([NotNull] CodeParser.MethodCallContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="CodeParser.scanFunction"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterScanFunction([NotNull] CodeParser.ScanFunctionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CodeParser.scanFunction"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitScanFunction([NotNull] CodeParser.ScanFunctionContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace Group4_Interpreter