namespace Amba.TfVars.Model
{
    public class StringNode : TfVarsNode
    {
        public string Value { get; set; }

        public StringNode()
        {
        }
    
        public StringNode(string value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}