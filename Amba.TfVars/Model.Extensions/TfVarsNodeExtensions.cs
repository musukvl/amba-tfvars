using System.Collections.Generic;
using System.Linq;

namespace Amba.TfVars.Model.Extensions;

public static class TfVarsNodeExtensions
{
    public static Dictionary<string, TfVarsNode>? ToDictionary(this TfVarsNode node)
    {
        var map = node.ToMap();
        return map.Values.ToDictionary(x => x.Key, x => x.Value);
    }
    public static MapNode ToMap(this TfVarsNode node)
    {
        return node as MapNode ?? new MapNode();
    }

    public static ListNode ToList(this TfVarsNode node)
    {
        return node as ListNode ?? new ListNode();
    }

}