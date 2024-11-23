

using Amba.TfVars.Model;

namespace Amba.TfVars;

public partial class ExtendedVisitor
{
    public override object VisitMap_(TfVarsParser.Map_Context context)
    {
        var result = new MapNode();
        foreach (var mapPair in context.map_pair())
        {
            var pair = (MapPairNode)Visit(mapPair);
            result.Pairs.AddLast(pair);
        }
        result.OneLine = IsOneLine(context.Start, context.Stop);
        if (result.OneLine)
        {
            result.CommentsAfter = GetCommentsAfterToken(context.Stop);
        }
        return result;
    }

    public override object VisitMap_pair(TfVarsParser.Map_pairContext context)
    {
        var key = context.map_key().GetText();
        var value = Visit(context.expression());
        var commentBefore = GetCommentsBeforeToken(context.Start);
        var result = new MapPairNode(key, (TfVarsNode)value)
        {
            CommentsBefore = commentBefore
        };
        return result;
    }
}