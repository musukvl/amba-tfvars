using System;
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

    public static void AddAfter(this MapNode mapNode, string keyBefore, string newKey, string value)
    {
        mapNode.AddAfter(keyBefore, newKey, new StringNode(value));
    }

    public static void AddAfter(this MapNode mapNode, string keyBefore, string newKey, TfVarsNode value)
    {
        var mapPair = new MapPairNode(newKey, value);
        if (mapNode.Pairs.Any() == false)
        {
            mapNode.Pairs.AddFirst(mapPair);
            return;
        }
        
        var target = mapNode.Pairs.FindNode(x => x.Key == keyBefore);
        if (target is null)
        {
            mapNode.Pairs.AddLast(mapPair);
        }
        mapNode.Pairs.AddAfter(target, mapPair);
    }

    public static MapNode? ChildMap(this MapNode mapNode, string key)
    {
        var node = mapNode.Pairs.FirstOrDefault(x => x.Key == key);
        return node?.Value.AsMapNode();
    }

    public static IEnumerable<MapNode> ChildMaps(this MapNode mapNode)
    {
        foreach (var mapPair in mapNode.Pairs)
        {
            yield return mapPair.Value.AsMapNode()!;
        }
    }
    
    public static LinkedListNode<T>? FindNode<T>(this LinkedList<T> list, Predicate<T> match)
    {
        LinkedListNode<T> current = list.First;
        while (current != null)
        {
            if (match(current.Value))
            {
                return current;
            }
            current = current.Next;
        }
        return null;
    }

    public static IEnumerable<TfVarsNode?> Values(this MapNode mapNode)
    {
        foreach (var mapPair in mapNode.Pairs)
        {
            yield return mapPair.Value;
        }
    }

}