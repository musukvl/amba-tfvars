namespace Amba.TfVars.Model;

public class StringNode : TfVarsNode
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