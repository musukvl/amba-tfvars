using System;
using System.Collections.Generic;
using System.Linq;

namespace Amba.TfVars.Model;

public class MapNode : TfVarsNode
{
    public List<MapPairNode> Values { get; } = new();

    public override TfVarsNode? this[object key]
    {
        get
        {
            if (key is string strKey)
            {
                return Values.FirstOrDefault(x => x.Key == strKey)?.Value;
            }
            throw new ArgumentException("Key must be a string", nameof(key));
        }
        set
        {
            if (key is string strKey)
            {
                var existingPair = Values.FirstOrDefault(x => x.Key == strKey);
                if (existingPair is not null)
                {
                    existingPair.Value = value;
                }
                else
                {
                    Values.Add(new MapPairNode(strKey, value));
                }
            }
            throw new ArgumentException("Key must be a string", nameof(key));
        }
    }
}