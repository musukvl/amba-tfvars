using System;
using System.Collections.Generic;
using System.Text;

namespace Amba.TfVars.Model;

public class ListNode : TfVarsNode
{
    public List<TfVarsNode> Values { get; } = new();

    public ListNode()
    {
    }

    public ListNode(params TfVarsNode[] values)
    {
        Values.AddRange(values);
    }

    public override IEnumerable<TfVarsNode> Children()
    {
        return Values;
    }
    
    public TfVarsNode ChildAt(int index)
    {
        return Values[index];
    }

    public override TfVarsNode? this[object key]
    {
        get
        {
            if (key is int intKey)
            {
                return Values[intKey];
            }
            throw new ArgumentException("Key must be an integer", nameof(key));
        }
        set
        {
            if (key is not int intKey)
            {
                throw new ArgumentException("Key must be an integer", nameof(key));
            }

            Values[intKey] = value ?? throw new ArgumentNullException(nameof(value), "List element can't be null");
        }
    }
}