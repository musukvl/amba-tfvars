using System.Collections.Generic;
using System.Linq;
using Amba.TfVars.Model;

namespace Amba.TfVars.Extensions;

public static class ValueExtensions
{
    public static bool? AsBool(this TfVarsNode? node)
    {
        if (node is NullNode)
        {
            return null;
        }
        return (node as BoolNode)?.Value;
    }
    
    public static IDictionary<string, TfVarsNode>? ToDictionary(this TfVarsNode? node)
    {
        if (node is null)
        {
            return new Dictionary<string, TfVarsNode>();
        }
        if (node is NullNode)
        {
            return null;
        }
        return node.AsMapNode()?.Pairs?.ToDictionary(x => x.Key, x => x.Value);
    }
    
    public static string? AsString(this TfVarsNode? node)
    {
        if (node is NullNode)
        {
            return null;
        }
        return (node as StringNode)?.Value;
    }
    
    public static decimal AsDecimal(this TfVarsNode? node)
    {
        if (node is NullNode)
        {
            return 0;
        }
        return (node as NumberNode)?.Value ?? 0;
    }
}