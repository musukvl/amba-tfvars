namespace Amba.TfVars.Model
{
    public class VariableDefinitionNode : TfVarsNode
    {
        public string Name { get; set; }
        public TfVarsNode TfVars { get; set; }

        public override string ToString()
        {
            return $"{Name} = {TfVars}" ;
        }
    }
}