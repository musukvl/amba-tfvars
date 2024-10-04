// Generated from c:/system/dev/hcl-parser/amba-tfvar-parser/Amba.TfvarsParser/Amba.TfvarsParser/Tfvars.g4 by ANTLR 4.13.1
import org.antlr.v4.runtime.tree.ParseTreeListener;

/**
 * This interface defines a complete listener for a parse tree produced by
 * {@link TfvarsParser}.
 */
public interface TfvarsListener extends ParseTreeListener {
	/**
	 * Enter a parse tree produced by {@link TfvarsParser#file_}.
	 * @param ctx the parse tree
	 */
	void enterFile_(TfvarsParser.File_Context ctx);
	/**
	 * Exit a parse tree produced by {@link TfvarsParser#file_}.
	 * @param ctx the parse tree
	 */
	void exitFile_(TfvarsParser.File_Context ctx);
	/**
	 * Enter a parse tree produced by {@link TfvarsParser#argument}.
	 * @param ctx the parse tree
	 */
	void enterArgument(TfvarsParser.ArgumentContext ctx);
	/**
	 * Exit a parse tree produced by {@link TfvarsParser#argument}.
	 * @param ctx the parse tree
	 */
	void exitArgument(TfvarsParser.ArgumentContext ctx);
	/**
	 * Enter a parse tree produced by {@link TfvarsParser#identifier}.
	 * @param ctx the parse tree
	 */
	void enterIdentifier(TfvarsParser.IdentifierContext ctx);
	/**
	 * Exit a parse tree produced by {@link TfvarsParser#identifier}.
	 * @param ctx the parse tree
	 */
	void exitIdentifier(TfvarsParser.IdentifierContext ctx);
	/**
	 * Enter a parse tree produced by {@link TfvarsParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterExpression(TfvarsParser.ExpressionContext ctx);
	/**
	 * Exit a parse tree produced by {@link TfvarsParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitExpression(TfvarsParser.ExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link TfvarsParser#section}.
	 * @param ctx the parse tree
	 */
	void enterSection(TfvarsParser.SectionContext ctx);
	/**
	 * Exit a parse tree produced by {@link TfvarsParser#section}.
	 * @param ctx the parse tree
	 */
	void exitSection(TfvarsParser.SectionContext ctx);
	/**
	 * Enter a parse tree produced by {@link TfvarsParser#val}.
	 * @param ctx the parse tree
	 */
	void enterVal(TfvarsParser.ValContext ctx);
	/**
	 * Exit a parse tree produced by {@link TfvarsParser#val}.
	 * @param ctx the parse tree
	 */
	void exitVal(TfvarsParser.ValContext ctx);
	/**
	 * Enter a parse tree produced by {@link TfvarsParser#index}.
	 * @param ctx the parse tree
	 */
	void enterIndex(TfvarsParser.IndexContext ctx);
	/**
	 * Exit a parse tree produced by {@link TfvarsParser#index}.
	 * @param ctx the parse tree
	 */
	void exitIndex(TfvarsParser.IndexContext ctx);
	/**
	 * Enter a parse tree produced by {@link TfvarsParser#list_}.
	 * @param ctx the parse tree
	 */
	void enterList_(TfvarsParser.List_Context ctx);
	/**
	 * Exit a parse tree produced by {@link TfvarsParser#list_}.
	 * @param ctx the parse tree
	 */
	void exitList_(TfvarsParser.List_Context ctx);
	/**
	 * Enter a parse tree produced by {@link TfvarsParser#map_}.
	 * @param ctx the parse tree
	 */
	void enterMap_(TfvarsParser.Map_Context ctx);
	/**
	 * Exit a parse tree produced by {@link TfvarsParser#map_}.
	 * @param ctx the parse tree
	 */
	void exitMap_(TfvarsParser.Map_Context ctx);
	/**
	 * Enter a parse tree produced by {@link TfvarsParser#string}.
	 * @param ctx the parse tree
	 */
	void enterString(TfvarsParser.StringContext ctx);
	/**
	 * Exit a parse tree produced by {@link TfvarsParser#string}.
	 * @param ctx the parse tree
	 */
	void exitString(TfvarsParser.StringContext ctx);
	/**
	 * Enter a parse tree produced by {@link TfvarsParser#signed_number}.
	 * @param ctx the parse tree
	 */
	void enterSigned_number(TfvarsParser.Signed_numberContext ctx);
	/**
	 * Exit a parse tree produced by {@link TfvarsParser#signed_number}.
	 * @param ctx the parse tree
	 */
	void exitSigned_number(TfvarsParser.Signed_numberContext ctx);
	/**
	 * Enter a parse tree produced by {@link TfvarsParser#operator_}.
	 * @param ctx the parse tree
	 */
	void enterOperator_(TfvarsParser.Operator_Context ctx);
	/**
	 * Exit a parse tree produced by {@link TfvarsParser#operator_}.
	 * @param ctx the parse tree
	 */
	void exitOperator_(TfvarsParser.Operator_Context ctx);
	/**
	 * Enter a parse tree produced by {@link TfvarsParser#number}.
	 * @param ctx the parse tree
	 */
	void enterNumber(TfvarsParser.NumberContext ctx);
	/**
	 * Exit a parse tree produced by {@link TfvarsParser#number}.
	 * @param ctx the parse tree
	 */
	void exitNumber(TfvarsParser.NumberContext ctx);
}