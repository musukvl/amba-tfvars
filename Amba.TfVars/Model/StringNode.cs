using System;

namespace Amba.TfVars.Model;

public class StringNode : ValueNode
{
    public string Value { get; set; } = string.Empty;

    public StringNode()
    {
    }

    public StringNode(string value, string? commentAfter = null)
    {
        Value = value;
        CommentAfter = commentAfter;
    }
    
    

    public override string ToString()
    {
        return Value;
    }
}