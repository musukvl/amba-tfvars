using System.Collections.Generic;
using System.Globalization;
using Amba.TfVars.Model;
using Antlr4.Runtime;

namespace Amba.TfVars;

public class ExtendedVisitor : TfVarsBaseVisitor<object>
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
        var value = (TfVarsNode)Visit(context.expression());
        var result = new VariableDefinitionNode(
            name: context.identifier().GetText(),
            value: value
        );
        return result;
    }

    public override object VisitString(TfVarsParser.StringContext context)
    {
        var str = context.GetText();
        return new StringNode(str[1..^1]);
    }

    public override object VisitBoolean(TfVarsParser.BooleanContext context)
    {
        return new BoolNode(context.GetText().ToLower() == "true");
    }

    public override object VisitNumber(TfVarsParser.NumberContext context)
    {
        return new NumberNode(decimal.Parse(context.GetText(), CultureInfo.InvariantCulture));
    }

    public override object VisitSigned_number(TfVarsParser.Signed_numberContext context)
    {
        return new NumberNode(decimal.Parse(context.GetText(), CultureInfo.InvariantCulture));
    }

    public override object VisitMap_(TfVarsParser.Map_Context context)
    {
        var result = new MapNode();
        foreach (var mapPair in context.map_pair())
        {
            var pair = (MapPairNode)Visit(mapPair);
            result.Values.AddLast(pair);
        }
        return result;
    }

    public override object VisitMap_pair(TfVarsParser.Map_pairContext context)
    {
        var key = context.map_key().GetText();
        var value = Visit(context.expression());
        var result = new MapPairNode(key, (TfVarsNode)value);
        return result;
    }

    public override object VisitList_(TfVarsParser.List_Context context)
    {
        var result = new ListNode();

        foreach (var expression in context.expression())
        {
            result.Values.Add((TfVarsNode)Visit(expression));
        }
        return result;
    }

    private string GetCommentsAfterToken(IToken token)
    {
        var comments = new List<string>();
        var t = _tokenStream.Get(token.TokenIndex + 1);

        if (t.Channel == Lexer.Hidden)
        {
            comments.Add(t.Text);
        }
        return string.Join(", ", comments);
    }

    private string GetCommentsBeforeToken(IToken token)
    {
        var comments = new List<string>();
        var t = _tokenStream.Get(token.TokenIndex - 1);

        if (t.Channel == Lexer.Hidden)
        {
            comments.Add(t.Text);
        }
        return string.Join(", ", comments);
    }
}