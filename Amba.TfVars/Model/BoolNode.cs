namespace Amba.TfVars.Model;

public class BoolNode : ValueNode
{
    public bool Value { get; set; }

    public BoolNode()
    {
    }

    public BoolNode(bool value)
    {
        Value = value;
    }
}
