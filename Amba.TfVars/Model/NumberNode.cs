namespace Amba.TfVars.Model;

public class NumberNode : TfVarsNode
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