using System.Collections.Generic;

namespace Amba.TfVars.Model
{
    public class VarsFileNode : TfVarsNode  
    {
        public Dictionary<string, VariableDefinitionNode?> Variables { get; set; } =
            new Dictionary<string, VariableDefinitionNode?>();
        
        public VariableDefinitionNode? this[string key]
        {
            get => Variables.ContainsKey(key) ? Variables[key] : null;
            set
            {
                if (!Variables.TryAdd(key, value))
                {
                    Variables[key] = value;
                }
            }
        }
    }
}
