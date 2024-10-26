using System;
using System.Globalization;
using System.Text;
using Amba.TfVars.Model;

namespace Amba.TfVars;

internal class TfVarsSerializer
{
    private readonly StringBuilder _sb;
    private bool Ident { get; }
    private readonly int _identSize;

    public TfVarsSerializer(StringBuilder sb, bool ident, int identSize)
    {
        _sb = sb;
        Ident = ident;
        _identSize = identSize;
    }

    public void Serialize(object? node, int depth)
    {
        if (node is null)
        {
            _sb.Append("null");
            return;
        }
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
        }
    }

    private void SerializeVaribleDefinition(VariableDefinitionNode variableDefinitionNode, int depth)
    {
        AppendIdented(variableDefinitionNode.Name, depth);
        _sb.Append(" = ");
        Serialize(variableDefinitionNode.Value, depth + 1);
        _sb.AppendLine();
    }

    private void SerializeList(ListNode listNode, int depth)
    {
        _sb.AppendLine("[");
        foreach (var value in listNode.Values)
        {
            AppendIdented("", depth);
            Serialize(value, depth + 1);
            _sb.AppendLine(",");
        }

        AppendIdented("]", depth - 1);
    }

    private void SerializeMap(MapNode mapNode, int depth)
    {
        _sb.AppendLine("{");
        foreach (var mapPair in mapNode.Values)
        {
            AppendIdented(mapPair.OriginalKey, depth);
            _sb.Append(" = ");
            Serialize(mapPair.Value, depth + 1);
            _sb.AppendLine();
        }

        AppendIdented("}", depth - 1);
    }

    private void SerializeVarsFile(TfVarsRoot tfVarsRoot, int depth)
    {
        foreach (var var in tfVarsRoot.Variables)
        {
            this.SerializeVaribleDefinition(var.Value, 0);
        }
    }

    private void AppendLineIdented(string value, int depth)
    {
        AppendIdented(value, depth);
        _sb.Append(Environment.NewLine);
    }

    private void AppendIdented(string value, int depth)
    {
        if (Ident)
        {
            _sb.Append(new string(' ', depth * 4));
        }

        _sb.Append(value);
    }
}