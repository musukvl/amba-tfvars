using System.Linq;
using Amba.TfVars.Model;

namespace Amba.TfVars.Serializer;

//TODO: Move ListSerializer to a separate class
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
        _sb.AppendLine("{");
        
        var doFormatting = DoMapFormatting(mapNode);
        var maxKeyLength = mapNode.Pairs.Any() ? mapNode.Pairs.Max(x => x.OriginalKey.Length) : 0;
        
        foreach (var mapPair in mapNode.Pairs)
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
        foreach (var mapPair in mapNode.Pairs)
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
        _sb.Append("{");
        var values = mapNode.Pairs.ToArray();
        for (var i = 0; i < values.Length; i++)
        {
            var mapPair = values[i]; 
            _sb.Append(" ");
            
            _sb.Append(mapPair.OriginalKey);
            _sb.Append(" = ");
            Serialize(mapPair.Value, depth + 1);
            if (i < values.Length - 1)
            {
                _sb.Append(",");
            }
            else
            {
                _sb.Append(" ");
            }
        }
        _sb.Append("}");
    }
}