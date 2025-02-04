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
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="TfVarsParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.2")]
[System.CLSCompliant(false)]
public interface ITfVarsVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="TfVarsParser.file_"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFile_([NotNull] TfVarsParser.File_Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TfVarsParser.variable_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariable_definition([NotNull] TfVarsParser.Variable_definitionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TfVarsParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifier([NotNull] TfVarsParser.IdentifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TfVarsParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpression([NotNull] TfVarsParser.ExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TfVarsParser.section"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSection([NotNull] TfVarsParser.SectionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TfVarsParser.val"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVal([NotNull] TfVarsParser.ValContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TfVarsParser.index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIndex([NotNull] TfVarsParser.IndexContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TfVarsParser.list_"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitList_([NotNull] TfVarsParser.List_Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TfVarsParser.map_"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMap_([NotNull] TfVarsParser.Map_Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TfVarsParser.map_pair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMap_pair([NotNull] TfVarsParser.Map_pairContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TfVarsParser.map_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMap_key([NotNull] TfVarsParser.Map_keyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TfVarsParser.string"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitString([NotNull] TfVarsParser.StringContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TfVarsParser.signed_number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSigned_number([NotNull] TfVarsParser.Signed_numberContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TfVarsParser.null"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNull([NotNull] TfVarsParser.NullContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TfVarsParser.number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumber([NotNull] TfVarsParser.NumberContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TfVarsParser.boolean"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolean([NotNull] TfVarsParser.BooleanContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TfVarsParser.comment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComment([NotNull] TfVarsParser.CommentContext context);
}
} // namespace Amba.TfVars
