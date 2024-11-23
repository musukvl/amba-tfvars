using Amba.TfVars.Model;

namespace Amba.TfVars;

public partial class ExtendedVisitor
{
    public override object VisitList_(TfVarsParser.List_Context context)
    {
        var result = new ListNode();

        foreach (var expression in context.expression())
        {
            result.Values.Add((TfVarsNode)Visit(expression));
        }
        result.OneLine = IsOneLine(context.Start, context.Stop);
        if (result.OneLine)
        {
            result.CommentsAfter = GetCommentsAfterToken(context.Stop);
        }
        return result;
    }
}