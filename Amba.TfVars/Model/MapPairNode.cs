namespace Amba.TfVars.Model;

public class MapPairNode : TfVarsNode
{
    public MapPairNode(string originalKey, TfVarsNode value)
    {
        Key = originalKey.Trim('"');
        OriginalKey = originalKey;
        Value = value;
    }

    public string Key { get; }
    public string OriginalKey { get; }
    public TfVarsNode? Value { get; set; }
}