using System.Collections.Generic;
using System.Linq;

namespace Amba.TfVars.Model.Extensions;

public static class TfVarsNodeExtensions
{
    public static Dictionary<string, IVariableExpressionNode>? ToDictionary(this IVariableExpressionNode node)
    {
        var map = node.ToMap();
        return map.Values.ToDictionary(x => x.Key, x => x.Value);
    }
    public static MapNode ToMap(this IVariableExpressionNode node)
    {
        return node as MapNode ?? new MapNode();
    }

    public static ListNode ToList(this IVariableExpressionNode node)
    {
        return node as ListNode ?? new ListNode();
    }

}