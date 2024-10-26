namespace Amba.TfVars.Model;

public class VariableDefinitionNode
{
    public string Name { get; set; }
    public TfVarsNode? Value { get; set; }

    public VariableDefinitionNode(string name, TfVarsNode? value)
    {
        Name = name;
        Value = value;
    }
}