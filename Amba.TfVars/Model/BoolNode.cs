﻿namespace Amba.TfVars.Model;

public class BoolNode : TfVarsNode
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
