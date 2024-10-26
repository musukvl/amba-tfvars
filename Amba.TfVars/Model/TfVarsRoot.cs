using System.Collections.Generic;

namespace Amba.TfVars.Model;

public class TfVarsRoot
{
    public Dictionary<string, VariableDefinitionNode?> Variables { get; } = new();

    public IVariableExpressionNode? this[string key]
    {
        get => Variables.GetValueOrDefault(key)?.Value;
        set
        {
            var variableDefinition = new VariableDefinitionNode(key, value);
            Variables[key] = variableDefinition;
        }
    }
}