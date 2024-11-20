using System.Linq;
using Amba.TfVars.Model;

namespace Amba.TfVars.Serializer;

//TODO: Move TfVarsSerializer to a separate class
partial class TfVarsSerializer
{
    private void SerializeMap(MapNode mapNode, int depth)
    {
        if (mapNode.OneLine)
        {
            SerializeOneLineMap(mapNode, depth);
        }
        else
        {
            SerializeMapMultiLine(mapNode, depth);
        }
    }

    private void SerializeMapMultiLine(MapNode mapNode, int depth)
    {
        var maxKeyLength = mapNode.Values.Max(x => x.OriginalKey.Length);
        var doFormatting = DoMapFormatting(mapNode);
        _sb.AppendLine("{");
        foreach (var mapPair in mapNode.Values)
        {
            AppendLineIdented(mapPair.CommentsBefore, depth);
            AppendIdented(mapPair.OriginalKey, depth);

            if (doFormatting)
            {
                var numberOfSpaces = maxKeyLength - mapPair.OriginalKey.Length;
                if (numberOfSpaces > 0)
                    _sb.Append(' ', numberOfSpaces);
            }

            _sb.Append(" = ");
            Serialize(mapPair.Value, depth + 1);
            _sb.AppendLine();
        }

        AppendIdented("}", depth - 1);
    }

    private static bool DoMapFormatting(MapNode mapNode)
    {
        foreach (var mapPair in mapNode.Values)
        {
            switch (mapPair.Value)
            {
                case MapNode { OneLine: false }:
                case ListNode { OneLine: false }:
                    return false;
            }
        }
        return true;
    }

    private void SerializeOneLineMap(MapNode mapNode, int depth)
    {
        _sb.Append("{ ");
        foreach (var mapPair in mapNode.Values)
        {
            _sb.Append(mapPair.OriginalKey);
            _sb.Append(" = ");
            Serialize(mapPair.Value, depth + 1);
        }
        _sb.Append("}");
    }
}