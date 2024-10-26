namespace Amba.TfVars.Model
{
    public class BoolNode : ITfVarsNode
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
}