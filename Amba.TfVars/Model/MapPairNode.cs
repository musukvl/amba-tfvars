namespace Amba.TfVars.Model
{
    public class MapPairNode : ITfVarsNode
    {
        public MapPairNode(string originalKey, ITfVarsNode value)
        {
            Key = originalKey.Trim('"');
            OriginalKey = originalKey;
            Value = value;
        }

        public string Key { get; }
        public string OriginalKey { get; }
        public ITfVarsNode Value { get; }
    }
}