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
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="TfVarsParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.2")]
[System.CLSCompliant(false)]
public interface ITfVarsListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="TfVarsParser.file_"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFile_([NotNull] TfVarsParser.File_Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TfVarsParser.file_"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFile_([NotNull] TfVarsParser.File_Context context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TfVarsParser.variable_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariable_definition([NotNull] TfVarsParser.Variable_definitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TfVarsParser.variable_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariable_definition([NotNull] TfVarsParser.Variable_definitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TfVarsParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifier([NotNull] TfVarsParser.IdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TfVarsParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifier([NotNull] TfVarsParser.IdentifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TfVarsParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] TfVarsParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TfVarsParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] TfVarsParser.ExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TfVarsParser.section"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSection([NotNull] TfVarsParser.SectionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TfVarsParser.section"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSection([NotNull] TfVarsParser.SectionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TfVarsParser.val"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVal([NotNull] TfVarsParser.ValContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TfVarsParser.val"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVal([NotNull] TfVarsParser.ValContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TfVarsParser.index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndex([NotNull] TfVarsParser.IndexContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TfVarsParser.index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndex([NotNull] TfVarsParser.IndexContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TfVarsParser.list_"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterList_([NotNull] TfVarsParser.List_Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TfVarsParser.list_"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitList_([NotNull] TfVarsParser.List_Context context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TfVarsParser.map_"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMap_([NotNull] TfVarsParser.Map_Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TfVarsParser.map_"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMap_([NotNull] TfVarsParser.Map_Context context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TfVarsParser.map_pair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMap_pair([NotNull] TfVarsParser.Map_pairContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TfVarsParser.map_pair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMap_pair([NotNull] TfVarsParser.Map_pairContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TfVarsParser.map_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMap_key([NotNull] TfVarsParser.Map_keyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TfVarsParser.map_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMap_key([NotNull] TfVarsParser.Map_keyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TfVarsParser.string"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterString([NotNull] TfVarsParser.StringContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TfVarsParser.string"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitString([NotNull] TfVarsParser.StringContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TfVarsParser.signed_number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSigned_number([NotNull] TfVarsParser.Signed_numberContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TfVarsParser.signed_number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSigned_number([NotNull] TfVarsParser.Signed_numberContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TfVarsParser.null"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNull([NotNull] TfVarsParser.NullContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TfVarsParser.null"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNull([NotNull] TfVarsParser.NullContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TfVarsParser.number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumber([NotNull] TfVarsParser.NumberContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TfVarsParser.number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumber([NotNull] TfVarsParser.NumberContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TfVarsParser.boolean"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBoolean([NotNull] TfVarsParser.BooleanContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TfVarsParser.boolean"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBoolean([NotNull] TfVarsParser.BooleanContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TfVarsParser.comment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComment([NotNull] TfVarsParser.CommentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TfVarsParser.comment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComment([NotNull] TfVarsParser.CommentContext context);
}
} // namespace Amba.TfVars
