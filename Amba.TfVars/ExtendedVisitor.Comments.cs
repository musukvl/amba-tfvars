using System;
using System.Collections.Generic;
using Antlr4.Runtime;

namespace Amba.TfVars;

public partial class ExtendedVisitor
{
    /// <summary>
    /// Get comments after the token. It could be comma after token. Captures comment before EOL. 
    /// </summary>
    /// <param name="token"></param>
    /// <returns></returns>
    private string[] GetCommentsAfterToken(IToken token)
    {
        if (token.TokenIndex == _tokenStream.Size - 1)
        {
            return Array.Empty<string>();
        }

        var lookupPosition = token.TokenIndex + 1;
        var t = _tokenStream.Get(lookupPosition);
        // check if the token is comma
        if (t.Text == ",")
        {
            // check if lookupPosition in bounds
            if (lookupPosition == _tokenStream.Size - 1)
                return Array.Empty<string>();

            // 
            lookupPosition += 1;
            t = _tokenStream.Get(lookupPosition);
        }

        var comments = new List<string>();
        if (t.Channel == Lexer.Hidden && t.Type == TfVarsLexer.LINECOMMENT || t.Type == TfVarsLexer.BLOCKCOMMENT)
        {
            comments.Add(t.Text);
        }
        return comments.ToArray();
    }

    /// <summary>
    /// Get comments before the token. But it shouldn't be a one line comment after previous token.
    /// </summary>
    /// <param name="startToken"></param>
    /// <returns></returns>
    private string[] GetCommentsBeforeToken(IToken startToken)
    {
        var comments = new List<string>();
        if (startToken.TokenIndex == 0)
        {
            return comments.ToArray();
        }

        // go up from the current token to the beginning of the file to find comments
        for (var tokenIndex = startToken.TokenIndex - 1; tokenIndex >= 0; tokenIndex--)
        {
            var t = _tokenStream.Get(tokenIndex);
            if (t.Type == TfVarsLexer.EOLS)
            {
                continue;
            }

            if (t.Channel == Lexer.Hidden && t.Type == TfVarsLexer.LINECOMMENT || t.Type == TfVarsLexer.BLOCKCOMMENT)
            {
                // the first comment in stream
                if (tokenIndex == 0)
                {
                    comments.Add(t.Text);
                    break;
                }

                // check what is before the comment: if that is just code line with comment, or it belongs to another Token.
                var beforeCommentToken = _tokenStream.Get(tokenIndex - 1);
                if (beforeCommentToken.Type == TfVarsLexer.EOLS)
                {
                    comments.Add(t.Text);
                }
            }
            else
            {
                break;
            }
        }
        return comments.ToArray();
    }

}