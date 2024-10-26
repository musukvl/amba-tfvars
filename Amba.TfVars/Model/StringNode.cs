namespace Amba.TfVars.Model;

public class StringNode : IVariableExpressionNode
{
    public string Value { get; set; } = string.Empty;

    public StringNode()
    {
    }

    public StringNode(string value)
    {
        Value = value;
    }
}