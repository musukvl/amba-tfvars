using System;
using System.Collections.Generic;
using System.Linq;

namespace Amba.TfVars.Model;

public class MapNode : CollectionNode
{
    public LinkedList<MapPairNode> Pairs { get; } = new();

    public MapNode()
    {
    }

    public MapNode(Dictionary<string, TfVarsNode> pairs, bool oneLine = false) 
    {
        foreach (var (key, value) in pairs)
        {
            Pairs.AddLast(new MapPairNode(key, value));
        }
    }
    
    public MapNode(List<KeyValuePair<string, TfVarsNode>> pairs, bool oneLine = false) 
    {
        foreach (var (key, value) in pairs)
        {
            Pairs.AddLast(new MapPairNode(key, value));
        }
    }

    public MapPairNode Child(string key)
    {
        return Pairs.FirstOrDefault(x => x.Key == key) ?? throw new ArgumentException($"Key {key} not found", nameof(key));
    }

    public override IEnumerable<TfVarsNode> Children()
    {
        return Pairs;
    }
    
    public override TfVarsNode Add(string key, TfVarsNode value)
    {
        Pairs.AddLast(new MapPairNode(key, value));
        return this;
    }
    
    public override TfVarsNode Remove(string key)
    {
        var pair = Pairs.FirstOrDefault(x => x.Key == key);
        if (pair is not null)
        {
            Pairs.Remove(pair);
        }
        return this;
    }

    public override TfVarsNode? this[object key]
    {
        get
        {
            if (key is string strKey)
            {
                return Pairs.FirstOrDefault(x => x.Key == strKey)?.Value;
            }
            throw new ArgumentException("Key must be a string", nameof(key));
        }
        set
        {
            if (key is string strKey)
            {
                var existingPair = Pairs.FirstOrDefault(x => x.Key == strKey);
                if (existingPair is not null)
                {
                    existingPair.Value = value;
                }
                else
                {
                    Pairs.AddLast(new MapPairNode(strKey, value));
                }
            }
            else
                throw new ArgumentException("Key must be a string", nameof(key));
        }
    }

}