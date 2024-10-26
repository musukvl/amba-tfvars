using System.Globalization;

namespace Amba.TfVars.Model
{
    public class NumberNode : ITfVarsNode
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
}