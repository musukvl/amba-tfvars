namespace Amba.TfVars.Model;

public class NullNode : ValueNode
{
    public object? Value { get; } = null;

    public NullNode()
    {
    }

}
