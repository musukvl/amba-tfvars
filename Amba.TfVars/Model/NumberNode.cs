namespace Amba.TfVars.Model;

public class NumberNode : IVariableExpressionNode
{
    public decimal Value { get; set; }

    public NumberNode()
    {
    }

    public NumberNode(decimal value)
    {
        Value = value;
    }
}