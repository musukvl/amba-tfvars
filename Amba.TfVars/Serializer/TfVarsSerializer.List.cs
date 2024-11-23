using Amba.TfVars.Model;

namespace Amba.TfVars.Serializer;

partial class TfVarsSerializer
{

    private void SerializeList(ListNode listNode, int depth)
    {
        if (listNode.OneLine)
        {
            SerializeListOneLine(listNode, depth);
        }
        else
        {
            SerializeListMultiLine(listNode, depth);
        }
    }

    private void SerializeListMultiLine(ListNode listNode, int depth)
    {
        _sb.AppendLine("[");
        for (var index = 0; index < listNode.Values.Count; index++)
        {
            var value = listNode.Values[index];
            AppendIdented("", depth);
            Serialize(value, depth + 1);
            if (!_options.IncludeListTrailingComma && index < listNode.Values.Count - 1)
                _sb.AppendLine(",");
            else
                _sb.AppendLine();
        }

        AppendIdented("]", depth - 1);
    }


    private void SerializeListOneLine(ListNode listNode, int depth)
    {
        _sb.Append("[");
        for (var index = 0; index < listNode.Values.Count; index++)
        {
            var value = listNode.Values[index];
            Serialize(value, depth + 1);
            if (!_options.IncludeListTrailingComma && index < listNode.Values.Count - 1)
                _sb.Append(", ");
        }

        _sb.Append("]");

        if (listNode.CommentsAfter != null)
        {
            _sb.Append(" ");
            _sb.Append(listNode.CommentsAfter);
        }
    }
}