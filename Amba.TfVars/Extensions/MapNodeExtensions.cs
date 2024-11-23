using System.Collections.Generic;
using System.Linq;
using Amba.TfVars.Model;

namespace Amba.TfVars.Extensions;

public static class MapNodeExtensions
{
    /// <summary>
    /// Reorder keys in the map node. Can be used for standardizing the order of properties in the objects.
    /// </summary>
    /// <param name="mapNode"></param>
    /// <param name="keysOrder"></param>
    public static void ReorderKeys(this MapNode mapNode, params string[] keysOrder)
    {
        foreach (var key in keysOrder.Reverse())
        {
            foreach (var node in mapNode.Pairs)
            {
                if (node.Key == key)
                {
                    mapNode.Pairs.Remove(node);
                    mapNode.Pairs.AddFirst(node);
                    break;
                }
            }
        }
    }

    public static MapNode? ChildMap(this MapNode mapNode, string key)
    {
        var node = mapNode.Pairs.FirstOrDefault(x => x.Key == key);
        return node?.Value.AsMap();
    }

    public static IEnumerable<MapNode> ChildMaps(this MapNode mapNode)
    {
        foreach (var mapPair in mapNode.Pairs)
        {
            yield return mapPair.Value.AsMap()!;
        }
    }

    public static IEnumerable<TfVarsNode?> Values(this MapNode mapNode)
    {
        foreach (var mapPair in mapNode.Pairs)
        {
            yield return mapPair.Value;
        }
    }


}