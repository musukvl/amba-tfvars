namespace Amba.TfVars.Model;

public class MapPairNode : IVariableExpressionNode
{
    public MapPairNode(string originalKey, IVariableExpressionNode value)
    {
        Key = originalKey.Trim('"');
        OriginalKey = originalKey;
        Value = value;
    }

    public string Key { get; }
    public string OriginalKey { get; }
    public IVariableExpressionNode? Value { get; set; }
}