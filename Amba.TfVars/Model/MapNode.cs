using System;
using System.Collections.Generic;
using System.Linq;

namespace Amba.TfVars.Model;

public class MapNode : CollectionNode
{
    public LinkedList<MapPairNode> Pairs { get; } = new();

    public MapNode(bool oneLine = false)
    {
        OneLine = oneLine;
    }

    public MapNode(Dictionary<string, TfVarsNode> pairs, bool oneLine = false) 
    {
        foreach (var (key, value) in pairs)
        {
            Pairs.AddLast(new MapPairNode(key, value));
        }
    }
    
    public MapNode(Dictionary<string, string> pairs, bool oneLine = false) 
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
    
    # region Modification Methods
    
    public MapNode SetOneLine(bool oneLine)
    {
        OneLine = oneLine;
        return this;
    }

    
    public MapNode Add(string key, TfVarsNode value)
    {
        Pairs.AddLast(new MapPairNode(key, value));
        return this;
    }
    
    public MapNode Property(string key, TfVarsNode value, string? commentsBefore = null)
    {
        var pair = new MapPairNode(key, value);
        if (commentsBefore != null)
            pair.CommentsBefore = commentsBefore.Split("\n");
        Pairs.AddLast(pair);
        return this;
    }
    
    public MapNode ParagraphProperty(string key, TfVarsNode value)
    {
        this.Property(key, value, "");
        return this;
    }
    
    public MapNode Remove(string key)
    {
        var pair = Pairs.FirstOrDefault(x => x.Key == key);
        if (pair is not null)
        {
            Pairs.Remove(pair);
        }
        return this;
    }
    
    #endregion

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
