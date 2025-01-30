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
        if (node is null)
        {
            return null;
        }
        if (node is NumberNode)
        {
            return (node as NumberNode)?.Value.ToString();
        }
        if (node is BoolNode)
        {
            return (node as BoolNode)?.Value.ToString();
        }
        if (node is NullNode)
        {
            return null;
        }
        if (node is StringNode)
        {
            return (node as StringNode)?.Value;
        }
        throw new System.InvalidOperationException($"Cannot convert {node?.GetType()} to string.");
    }
    
    public static decimal? AsDecimal(this TfVarsNode? node)
    {
        if (node is null)
        {
            return null;
        }   
        if (node is NumberNode numberNode)
        {
            return numberNode.Value;
        }
        if (node is NullNode)
        {
            return 0;
        }
        if (node is StringNode stringNode)
        {
            if (decimal.TryParse(stringNode.Value, out var result))
            {
                return result;
            }
        }
        throw new System.InvalidOperationException($"Cannot convert {node?.GetType()} to decimal.");
    }
}