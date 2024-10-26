using System;
using System.Collections.Generic;
using System.Text;

namespace Amba.TfVars.Model;

public class ListNode : TfVarsNode
{
    public List<TfVarsNode> Values { get; set; } = new();

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

            Values[intKey] = value;
        }
    }
}