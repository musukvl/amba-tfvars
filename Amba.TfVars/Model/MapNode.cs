using System.Collections.Generic;
using System.Linq;

namespace Amba.TfVars.Model;

public class MapNode : IVariableExpressionNode
{
    public List<MapPairNode> Values { get; } = new();

    //index operator
    public IVariableExpressionNode? this[string key]
    {
        get
        {
            return Values.FirstOrDefault(x => x.Key == key)?.Value;
        }
        set
        {
            for (int i = 0; i < Values.Count; i++)
            {
                if (Values[i].Key == key)
                {
                    Values[i].Value = value;
                    return;
                }
            }
            Values.Add(new MapPairNode(key, value));
        }
    }
}