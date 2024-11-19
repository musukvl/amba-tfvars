using Antlr4.Runtime;

namespace Amba.TfVars;

public partial class ExtendedVisitor
{
    private bool IsOneLine(IToken startToken, IToken stopToken)
    {
        var hasEof = false;
        for (var i = startToken.TokenIndex; i < stopToken.TokenIndex; i++)
        {
            var token = _tokenStream.Get(i);
            if (token.Type == TfVarsLexer.EOLS)
            {
                hasEof = true;
                break;
            }
        }
        return !hasEof;
    }
}