using System.Collections.Generic;
using System.Linq;
using Amba.TfVars.Model;

namespace Amba.TfVars.Extensions;

public static class TfVarsNodeExtension
{
    public static ValueNode? AsValueNode(this TfVarsNode? node)
    {
        return node as ValueNode;
    }

    public static MapNode? AsMapNode(this TfVarsNode? node)
    {
        if (node is NullNode)
        {
            return null;
        }
        return node as MapNode;
    }
    
    public static ListNode? AsListNode(this TfVarsNode? node)
    {
        if (node is NullNode)
        {
            return null;
        }
        return node as ListNode;
    }

    public static BoolNode? AsBoolNode(this TfVarsNode? node)
    {
        if (node is NullNode)
        {
            return null;
        }
        return node as BoolNode;
    }
    
    public static StringNode? AsStringNode(this TfVarsNode? node)
    {
        if (node is NullNode)
        {
            return null;
        }
        return node as StringNode;
    }

    public static NumberNode? AsNumberNode(this TfVarsNode? node)
    {
        if (node is NullNode)
        {
            return null;
        }
        return node as NumberNode;
    }
    
    
}