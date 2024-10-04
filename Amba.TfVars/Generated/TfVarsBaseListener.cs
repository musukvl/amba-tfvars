//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from TfVars.g4 by ANTLR 4.13.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Amba.TfVars {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ITfVarsListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.2")]
[System.Diagnostics.DebuggerNonUserCode]
[System.CLSCompliant(false)]
public partial class TfVarsBaseListener : ITfVarsListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="TfVarsParser.file_"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFile_([NotNull] TfVarsParser.File_Context context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TfVarsParser.file_"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFile_([NotNull] TfVarsParser.File_Context context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TfVarsParser.variable_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariable_definition([NotNull] TfVarsParser.Variable_definitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TfVarsParser.variable_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariable_definition([NotNull] TfVarsParser.Variable_definitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TfVarsParser.identifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifier([NotNull] TfVarsParser.IdentifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TfVarsParser.identifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifier([NotNull] TfVarsParser.IdentifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TfVarsParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpression([NotNull] TfVarsParser.ExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TfVarsParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpression([NotNull] TfVarsParser.ExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TfVarsParser.section"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSection([NotNull] TfVarsParser.SectionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TfVarsParser.section"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSection([NotNull] TfVarsParser.SectionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TfVarsParser.val"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVal([NotNull] TfVarsParser.ValContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TfVarsParser.val"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVal([NotNull] TfVarsParser.ValContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TfVarsParser.index"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndex([NotNull] TfVarsParser.IndexContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TfVarsParser.index"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndex([NotNull] TfVarsParser.IndexContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TfVarsParser.list_"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterList_([NotNull] TfVarsParser.List_Context context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TfVarsParser.list_"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitList_([NotNull] TfVarsParser.List_Context context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TfVarsParser.map_"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMap_([NotNull] TfVarsParser.Map_Context context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TfVarsParser.map_"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMap_([NotNull] TfVarsParser.Map_Context context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TfVarsParser.map_pair"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMap_pair([NotNull] TfVarsParser.Map_pairContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TfVarsParser.map_pair"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMap_pair([NotNull] TfVarsParser.Map_pairContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TfVarsParser.map_key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMap_key([NotNull] TfVarsParser.Map_keyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TfVarsParser.map_key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMap_key([NotNull] TfVarsParser.Map_keyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TfVarsParser.string"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterString([NotNull] TfVarsParser.StringContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TfVarsParser.string"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitString([NotNull] TfVarsParser.StringContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TfVarsParser.signed_number"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSigned_number([NotNull] TfVarsParser.Signed_numberContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TfVarsParser.signed_number"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSigned_number([NotNull] TfVarsParser.Signed_numberContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TfVarsParser.number"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumber([NotNull] TfVarsParser.NumberContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TfVarsParser.number"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumber([NotNull] TfVarsParser.NumberContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TfVarsParser.boolean"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBoolean([NotNull] TfVarsParser.BooleanContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TfVarsParser.boolean"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBoolean([NotNull] TfVarsParser.BooleanContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TfVarsParser.comment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComment([NotNull] TfVarsParser.CommentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TfVarsParser.comment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComment([NotNull] TfVarsParser.CommentContext context) { }

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
} // namespace Amba.TfVars
