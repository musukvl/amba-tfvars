using System;

namespace Amba.TfVars.Model;

public class VariableDefinitionNode
{
    public string Name { get; set; }
    public TfVarsNode? Value { get; set; }
    public string[] CommentsBefore { get; set; } = Array.Empty<string>();
    public string[] CommentsAfter { get; set; } = Array.Empty<string>();

    public VariableDefinitionNode(string name, TfVarsNode? value)
    {
        Name = name;
        Value = value;
    }
}