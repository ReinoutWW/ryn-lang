//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from ../Ryn.g4 by ANTLR 4.13.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419


using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IRynListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.2")]
[System.Diagnostics.DebuggerNonUserCode]
[System.CLSCompliant(false)]
public partial class RynBaseListener : IRynListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="RynParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProgram([NotNull] RynParser.ProgramContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RynParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProgram([NotNull] RynParser.ProgramContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RynParser.classDecl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassDecl([NotNull] RynParser.ClassDeclContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RynParser.classDecl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassDecl([NotNull] RynParser.ClassDeclContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RynParser.methodDecl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethodDecl([NotNull] RynParser.MethodDeclContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RynParser.methodDecl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethodDecl([NotNull] RynParser.MethodDeclContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RynParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatement([NotNull] RynParser.StatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RynParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatement([NotNull] RynParser.StatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RynParser.varDecl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVarDecl([NotNull] RynParser.VarDeclContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RynParser.varDecl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVarDecl([NotNull] RynParser.VarDeclContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RynParser.printStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrintStmt([NotNull] RynParser.PrintStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RynParser.printStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrintStmt([NotNull] RynParser.PrintStmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RynParser.ifStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIfStmt([NotNull] RynParser.IfStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RynParser.ifStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIfStmt([NotNull] RynParser.IfStmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RynParser.forStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForStmt([NotNull] RynParser.ForStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RynParser.forStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForStmt([NotNull] RynParser.ForStmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RynParser.exprStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprStmt([NotNull] RynParser.ExprStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RynParser.exprStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprStmt([NotNull] RynParser.ExprStmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>StringExpr</c>
	/// labeled alternative in <see cref="RynParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStringExpr([NotNull] RynParser.StringExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>StringExpr</c>
	/// labeled alternative in <see cref="RynParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStringExpr([NotNull] RynParser.StringExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>NumberExpr</c>
	/// labeled alternative in <see cref="RynParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumberExpr([NotNull] RynParser.NumberExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>NumberExpr</c>
	/// labeled alternative in <see cref="RynParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumberExpr([NotNull] RynParser.NumberExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ComparisonExpr</c>
	/// labeled alternative in <see cref="RynParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComparisonExpr([NotNull] RynParser.ComparisonExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ComparisonExpr</c>
	/// labeled alternative in <see cref="RynParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComparisonExpr([NotNull] RynParser.ComparisonExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>IdentifierExpr</c>
	/// labeled alternative in <see cref="RynParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifierExpr([NotNull] RynParser.IdentifierExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>IdentifierExpr</c>
	/// labeled alternative in <see cref="RynParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifierExpr([NotNull] RynParser.IdentifierExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>BinaryExpr</c>
	/// labeled alternative in <see cref="RynParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBinaryExpr([NotNull] RynParser.BinaryExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>BinaryExpr</c>
	/// labeled alternative in <see cref="RynParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBinaryExpr([NotNull] RynParser.BinaryExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ParenExpr</c>
	/// labeled alternative in <see cref="RynParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParenExpr([NotNull] RynParser.ParenExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ParenExpr</c>
	/// labeled alternative in <see cref="RynParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParenExpr([NotNull] RynParser.ParenExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="RynParser.accessModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAccessModifier([NotNull] RynParser.AccessModifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="RynParser.accessModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAccessModifier([NotNull] RynParser.AccessModifierContext context) { }

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
