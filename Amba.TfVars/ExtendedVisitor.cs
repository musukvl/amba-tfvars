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
        var commentBefore = GetCommentsBeforeToken(context.Start);
        var result = new MapPairNode(key, (TfVarsNode)value);
        var commentAfter = GetCommentsAfterToken(context.Stop);
        
        result.CommentBefore = commentBefore;
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

    private string[] GetCommentsAfterToken(IToken token)
    {
        var comments = new List<string>();
        if (token.TokenIndex == _tokenStream.Size - 1)
        {
            return comments.ToArray();
        }
        var t = _tokenStream.Get(token.TokenIndex + 1);

        if (t.Channel == Lexer.Hidden && t.Type != TfVarsLexer.EOLS)
        {
            comments.Add(t.Text);
        }
        return comments.ToArray();
    }

    private string[] GetCommentsBeforeToken(IToken token)
    {
        var comments = new List<string>();
        if (token.TokenIndex == 0)
        {
            return comments.ToArray();
        }
        
        // go up from the current token to the beginning of the file to find comments
        for (var i = token.TokenIndex - 1; i >= 0; i--)
        {
            var t = _tokenStream.Get(i);
            if (t.Channel == Lexer.Hidden && t.Type != TfVarsLexer.EOLS)
            {
                comments.Add(t.Text);
            }
            else if (t.Type == TfVarsLexer.EOLS)
            {
                continue;
            }
            else
            {
                break;
            }
        }
        return comments.ToArray();
    }
    
    
}