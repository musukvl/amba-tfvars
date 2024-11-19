using Amba.TfVars.Model;

namespace Amba.TfVars.Extensions;

public static class TfVarsNodeExtension
{
    public static ValueNode? AsValue(this TfVarsNode? node)
    {
        return node as ValueNode;
    }

    public static MapNode? AsMap(this TfVarsNode? node)
    {
        return node as MapNode;
    }

    public static ListNode? AsList(this TfVarsNode? node)
    {
        return node as ListNode;
    }

    public static BoolNode? AsBool(this TfVarsNode? node)
    {
        return node as BoolNode;
    }

    public static StringNode? AsString(this TfVarsNode? node)
    {
        return node as StringNode;
    }

    public static NumberNode? AsNumber(this TfVarsNode? node)
    {
        return node as NumberNode;
    }
}