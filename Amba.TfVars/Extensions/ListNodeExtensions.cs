﻿using System.Collections.Generic;
using System.Linq;
using Amba.TfVars.Model;

namespace Amba.TfVars.Extensions;

public static class ListNodeExtensions
{
    public static MapNode? ChildMap(this ListNode mapNode, int index)
    {
        var node = mapNode.Values.ElementAtOrDefault(index);
        return node?.AsMapNode();
    }

    public static IEnumerable<MapNode> ChildMaps(this ListNode mapNode)
    {
        foreach (var mapPair in mapNode.Values)
        {
            yield return mapPair.AsMapNode()!;
        }
    }

    public static IEnumerable<StringNode> ChildStrings(this ListNode mapNode)
    {
        foreach (var mapPair in mapNode.Values)
        {
            yield return mapPair.AsStringNode()!;
        }
    }
}