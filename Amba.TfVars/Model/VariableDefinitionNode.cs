namespace Amba.TfVars.Model;

public class VariableDefinitionNode
{
    public string Name { get; set; }
    public IVariableExpressionNode? Value { get; set; }

    public VariableDefinitionNode(string name, IVariableExpressionNode? value)
    {
        Name = name;
        Value = value;
    }
}