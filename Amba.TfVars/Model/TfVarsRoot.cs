using System.Collections.Generic;

namespace Amba.TfVars.Model
{
    public class TfVarsRoot : ITfVarsNode
    {
        public Dictionary<string, VariableDefinitionNode?> Variables { get; private set; } =
            new Dictionary<string, VariableDefinitionNode?>();

        public ITfVarsNode? this[string key]
        {
            get => Variables.GetValueOrDefault(key);
            set
            {
                var variableDefinition = new VariableDefinitionNode(key, value);
                Variables[key] = variableDefinition;
            }
        }
    }
}
