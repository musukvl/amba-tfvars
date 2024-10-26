using System;

namespace Amba.TfVars.Model;

public abstract class TfVarsNode
{
    /// <summary>
    /// Gets the <see cref="JToken"/> with the specified key.
    /// </summary>
    /// <value>The <see cref="JToken"/> with the specified key.</value>
    public virtual TfVarsNode? this[object key]
    {
        get => throw new InvalidOperationException(@$"Cannot access child value on {GetType()}.");
        set => throw new InvalidOperationException(@$"Cannot set child value on {GetType()}.");
    }


    public static explicit operator bool(TfVarsNode value)
    {
        if (value is BoolNode boolNode)
        {
            return boolNode.Value;
        }
        throw new InvalidCastException();
    }

    public static explicit operator string(TfVarsNode value)
    {
        if (value is StringNode stringNode)
        {
            return stringNode.Value;
        }
        throw new InvalidCastException();
    }

    public static explicit operator int(TfVarsNode value)
    {
        if (value is NumberNode numberNode)
        {
            return Convert.ToInt32(numberNode.Value);
        }
        throw new InvalidCastException();
    }

    public static explicit operator decimal(TfVarsNode value)
    {
        if (value is NumberNode numberNode)
        {
            return numberNode.Value;
        }
        throw new InvalidCastException();
    }



}