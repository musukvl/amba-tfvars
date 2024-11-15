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
            foreach (var node in mapNode.Values)
            {
                if (node.Key == key)
                {
                    mapNode.Values.Remove(node);
                    mapNode.Values.AddFirst(node);
                    break;
                }
            }
        }
    }
}