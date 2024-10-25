using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Amba.TfVars.Model;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace Amba.TfVars
{
    public class ExtendedVisitor : TfVarsBaseVisitor<TfVarsNode>
    {
        private readonly ITokenStream _tokenStream;

        public ExtendedVisitor(ITokenStream tokenStream)
        {
            _tokenStream = tokenStream;
        }
        
        public override TfVarsNode VisitFile_(TfVarsParser.File_Context context)
        {
            var result = new VarsFileNode();
            foreach (var variableDefinition in context.variable_definition())
            {
                var variable = (VariableDefinitionNode) Visit(variableDefinition);
                result[variable.Name] = variable;   
            }
            return result;
        }

        public override TfVarsNode VisitVariable_definition(TfVarsParser.Variable_definitionContext context)
        {
            var result = new VariableDefinitionNode();
            result.Name = context.identifier().GetText();
            result.TfVars = Visit(context.expression());
            return result;
        }

        public override TfVarsNode VisitString(TfVarsParser.StringContext context)
        {
            return new StringNode(context.GetText());
        }
        
        public override TfVarsNode VisitBoolean(TfVarsParser.BooleanContext context)
        {
            return new BoolNode(context.GetText().ToLower() == "true");
        }

        public override TfVarsNode VisitNumber(TfVarsParser.NumberContext context)
        {
            return new NumberNode(decimal.Parse(context.GetText(), CultureInfo.InvariantCulture));
        }

        public override TfVarsNode VisitSigned_number(TfVarsParser.Signed_numberContext context)
        {
            return new NumberNode(decimal.Parse(context.GetText(), CultureInfo.InvariantCulture));
        }
        
        public override TfVarsNode VisitMap_(TfVarsParser.Map_Context context)
        {
            var result = new MapNode();
            foreach (var mapPair in context.map_pair())
            {
                var pair = (MapPairNode)Visit(mapPair);
                result.Values.Add(pair);
            }
            return result;
        }

        public override TfVarsNode VisitMap_pair(TfVarsParser.Map_pairContext context)
        {
            var key = context.map_key().GetText();
            var value = Visit(context.expression());
            var result = new MapPairNode(key, value);
            return result;
        }

        public override TfVarsNode VisitList_(TfVarsParser.List_Context context)
        {
            var result = new ListNode();

            foreach (var expression in context.expression())
            {
                result.Values.Add(Visit(expression));
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
}