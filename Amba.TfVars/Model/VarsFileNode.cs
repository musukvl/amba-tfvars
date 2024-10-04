using System.Collections.Generic;
using System.Text;

namespace Amba.TfVars.Model
{
    public class VarsFileNode : TfVarsNode
    {
        public Dictionary<string, VariableDefinitionNode?> Variables { get; set; } =
            new Dictionary<string, VariableDefinitionNode?>();
        
        public VariableDefinitionNode? this[string key]
        {
            get => Variables.ContainsKey(key) ? Variables[key] : null;
            set => Variables[key] = value;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var var in Variables)
            {
                sb.AppendLine(var.Value.ToString());
            }

            return sb.ToString();
        }
    }
}
