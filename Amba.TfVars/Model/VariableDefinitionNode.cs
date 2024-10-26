namespace Amba.TfVars.Model
{
    public class VariableDefinitionNode : ITfVarsNode
    {
        public string Name { get; set; }
        public ITfVarsNode Value { get; set; }

        public VariableDefinitionNode(string name, ITfVarsNode value)
        {
            Name = name;
            Value = value;
        }
    }
}