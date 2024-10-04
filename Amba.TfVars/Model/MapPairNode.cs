namespace Amba.TfVars.Model
{
    public class MapPairNode : TfVarsNode
    {
        public MapPairNode(string originalKey, TfVarsNode tfVars)
        {
            Key = originalKey.Trim('"');
            OriginalKey = originalKey;
            TfVars = tfVars;
        }
        
        public string Key { get; }
        public string OriginalKey { get;  }
        public TfVarsNode TfVars { get; }
    }
}