﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Amba.TfVars.Model;

public class MapNode : CollectionNode
{
    public LinkedList<MapPairNode> Values { get; } = new();

    public MapNode()
    {
    }

    public MapNode(Dictionary<string, TfVarsNode> values)
    {
        foreach (var (key, value) in values)
        {
            Values.AddLast(new MapPairNode(key, value));
        }
    }

    public MapNode(params MapPairNode[] values)
    {
        foreach (var value in values)
        {
            Values.AddLast(value);
        }
    }

    public MapPairNode Child(string key)
    {
        return Values.FirstOrDefault(x => x.Key == key) ?? throw new ArgumentException($"Key {key} not found", nameof(key));
    }

    public override IEnumerable<TfVarsNode> Children()
    {
        return Values;
    }
    
    public IEnumerable<MapPairNode> Pairs()
    {
        return Values;
    }

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
                    Values.AddLast(new MapPairNode(strKey, value));
                }
            }
            else
                throw new ArgumentException("Key must be a string", nameof(key));
        }
    }
}