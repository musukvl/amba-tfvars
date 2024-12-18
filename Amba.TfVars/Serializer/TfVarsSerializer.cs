﻿using System;
using System.Globalization;
using System.Text;
using Amba.TfVars.Model;

namespace Amba.TfVars.Serializer;

internal partial class TfVarsSerializer
{
    private readonly StringBuilder _sb;
    private readonly SerializerOptions _options;

    public TfVarsSerializer(StringBuilder sb, SerializerOptions options)
    {
        _sb = sb;
        _options = options;
    }

    public void Serialize(object? node, int depth)
    {
        switch (node)
        {
            case NumberNode numberNode:
                _sb.Append(numberNode.Value.ToString(CultureInfo.InvariantCulture));
                break;
            case StringNode stringNode:
                _sb.Append("\"");
                _sb.Append(stringNode.Value);
                _sb.Append("\"");
                break;
            case BoolNode boolNode:
                _sb.Append(boolNode.Value ? "true" : "false");
                break;
            case ListNode listNode:
                SerializeList(listNode, depth);
                break;
            case MapNode mapNode:
                SerializeMap(mapNode, depth);
                break;
            case TfVarsRoot varsFileNode:
                SerializeVarsFile(varsFileNode, depth);
                break;
            case VariableDefinitionNode variableDefinitionNode:
                SerializeVaribleDefinition(variableDefinitionNode, depth);
                break;
            case NullNode nullNode:
                SerializeNullNode(nullNode, depth);
                break;
        }

        if (node is ValueNode valueNode && !string.IsNullOrWhiteSpace(valueNode.CommentAfter))
        {
            _sb.Append(" ");
            //TODO: Check comment after in case of list
            _sb.Append(valueNode.CommentAfter);
        }
    }

    private void SerializeVaribleDefinition(VariableDefinitionNode variableDefinitionNode, int depth)
    {
        AppendLineIdented(variableDefinitionNode.CommentsBefore, depth);
        AppendIdented(variableDefinitionNode.Name, depth);
        _sb.Append(" = ");
        Serialize(variableDefinitionNode.Value, depth + 1);
        _sb.AppendLine();
    }

    private void SerializeVarsFile(TfVarsRoot tfVarsRoot, int depth)
    {
        foreach (var var in tfVarsRoot.Variables)
        {
            this.SerializeVaribleDefinition(var.Value, 0);
        }
    }

    //TODO: Make append methods as extension methods for string builder
    private void AppendLineIdented(string value, int depth)
    {
        AppendIdented(value, depth);
        _sb.Append(Environment.NewLine);
    }

    private void AppendLineIdented(string[] values, int depth)
    {
        foreach (var value in values)
        {
            AppendIdented(value, depth);
            _sb.Append(Environment.NewLine);
        }
    }

    private void AppendIdented(string value, int depth)
    {
        if (_options.Indent)
        {
            _sb.Append(new string(' ', depth * _options.IndentSize));
        }
        _sb.Append(value);
    }

    private void SerializeNullNode(NullNode nullNode, int depth)
    {
        _sb.Append("null");
    }
}