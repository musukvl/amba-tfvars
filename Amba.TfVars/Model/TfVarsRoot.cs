using System;
using System.Collections.Generic;

namespace Amba.TfVars.Model;

public class TfVarsRoot : TfVarsNode
{
    public Dictionary<string, VariableDefinitionNode> Variables { get; } = new();


    public TfVarsRoot()
    {
    }

    public TfVarsRoot(Dictionary<string, TfVarsNode> values)
    {
        foreach (var (key, value) in values)
        {
            Variables[key] = new VariableDefinitionNode(key, value);
        }
    }

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
                return;
            }
            throw new ArgumentException("Key must be a string", nameof(key));
        }
    }

    public VariableDefinitionNode? Child(string name)
    {
        return Variables.GetValueOrDefault(name);
    }
}