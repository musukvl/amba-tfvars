using System;
using System.Collections.Generic;

namespace Amba.TfVars.Model;

public class TfVarsRoot : TfVarsNode
{
    public Dictionary<string, VariableDefinitionNode?> Variables { get; } = new();

    public override TfVarsNode? this[object key]
    {
        get
        {
            if (key is string strKey)
            {
                return Variables.GetValueOrDefault(strKey)?.Value;
            }
            throw new ArgumentException("Key must be a string", nameof(key));
        }
        set
        {
            if (key is string strKey)
            {
                Variables[strKey] = new VariableDefinitionNode(strKey, value);
            }
            throw new ArgumentException("Key must be a string", nameof(key));
        }
    }
}