using System;
using System.Collections.Generic;
using System.Globalization;
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
    
    public static Dictionary<string, TfVarsNode?>? ToDictionary(this TfVarsNode? node)
    {
        if (node is null)
        {
            return new Dictionary<string, TfVarsNode?>();
        }
        if (node is NullNode)
        {
            return null;
        }
        return node.AsMapNode()?.Pairs.ToDictionary(x => x.Key, x => x.Value);
    }
    
    public static List<string>? AsListOfStrings(this TfVarsNode? node)
    {
        if (node is null)
        {
            return new List<string>();
        }
        if (node is NullNode)
        {
            return null;
        }
        if (node is ListNode listNode)
        {
            return listNode.Values
                .Select(x => x.AsString())
                .Where(x => x != null)
                .ToList()!;
        }
        throw new InvalidOperationException($"Can't convert node {node.GetType()} to list of strings.");
    }
    
    public static string? AsString(this TfVarsNode? node)
    {
        if (node is null)
        {
            return null;
        }
        if (node is NumberNode)
        {
            return (node as NumberNode)?.Value.ToString(CultureInfo.InvariantCulture);
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
        throw new InvalidOperationException($"Cannot convert {node.GetType()} to string.");
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
        throw new InvalidOperationException($"Cannot convert {node.GetType()} to decimal.");
    }
}