﻿namespace Amba.TfVars.Model
{
    public class StringNode : ITfVarsNode
    {
        public string Value { get; set; } = string.Empty;

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