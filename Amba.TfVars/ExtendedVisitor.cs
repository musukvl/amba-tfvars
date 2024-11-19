using System.Collections.Generic;
using System.Globalization;
using Amba.TfVars.Model;
using Antlr4.Runtime;

namespace Amba.TfVars;

public partial class ExtendedVisitor : TfVarsBaseVisitor<object>
{
    private readonly ITokenStream _tokenStream;

    public ExtendedVisitor(ITokenStream tokenStream)
    {
        _tokenStream = tokenStream;
    }

    public override object VisitFile_(TfVarsParser.File_Context context)
    {
        var result = new TfVarsRoot();
        foreach (var variableDefinition in context.variable_definition())
        {
            var variable = (VariableDefinitionNode)Visit(variableDefinition);
            result.Variables[variable.Name] = variable;
        }
        return result;
    }

    public override object VisitVariable_definition(TfVarsParser.Variable_definitionContext context)
    {
        var commentBefore = GetCommentsBeforeToken(context.Start);
        var value = (TfVarsNode)Visit(context.expression());
        var result = new VariableDefinitionNode(
            name: context.identifier().GetText(),
            value: value
        );
        result.CommentsBefore = commentBefore;
        return result;
    }

    public override object VisitString(TfVarsParser.StringContext context)
    {
        var str = context.GetText();
        var commentAfter = GetCommentsAfterToken(context.Stop);
        var result = new StringNode(str[1..^1])
        {
            CommentAfter = commentAfter
        };
        return result;
    }

    public override object VisitBoolean(TfVarsParser.BooleanContext context)
    {
        var commentAfter = GetCommentsAfterToken(context.Stop);
        var result = new BoolNode(context.GetText().ToLower() == "true")
        {
            CommentAfter = commentAfter
        };
        return result;
    }

    public override object VisitNumber(TfVarsParser.NumberContext context)
    {
        var commentAfter = GetCommentsAfterToken(context.Stop);
        var result = new NumberNode(decimal.Parse(context.GetText(), CultureInfo.InvariantCulture))
        {
            CommentAfter = commentAfter
        };
        return result;
    }

    public override object VisitSigned_number(TfVarsParser.Signed_numberContext context)
    {
        var commentAfter = GetCommentsAfterToken(context.Stop);
        var result = new NumberNode(decimal.Parse(context.GetText(), CultureInfo.InvariantCulture))
        {
            CommentAfter = commentAfter
        };
        return result;
    }



}