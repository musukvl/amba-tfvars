namespace Amba.TfVars.Model;

public class BoolNode : IVariableExpressionNode
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
