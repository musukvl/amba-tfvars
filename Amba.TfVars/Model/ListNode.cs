using System;
using System.Collections.Generic;

namespace Amba.TfVars.Model;

public class ListNode : CollectionNode, IList<TfVarsNode>
{
    public List<TfVarsNode> Values { get; } = new();

    public ListNode(bool oneLine = false)
    {
        OneLine = oneLine;
    }

    public ListNode(params TfVarsNode[] values)
    {
        Values.AddRange(values);
    }

    public ListNode(List<TfVarsNode> values, bool oneLine = false)
        : this(oneLine)
    {
        Values.AddRange(values);
    }
    
    public override IEnumerable<TfVarsNode> Children()
    {
        return Values;
    }

    public TfVarsNode ChildAt(int index)
    {
        return Values[index];
    }

    public override TfVarsNode? this[object key]
    {
        get
        {
            if (key is int intKey)
            {
                return Values[intKey];
            }
            throw new ArgumentException("Key must be an integer", nameof(key));
        }
        set
        {
            if (key is not int intKey)
            {
                throw new ArgumentException("Key must be an integer", nameof(key));
            }

            Values[intKey] = value ?? throw new ArgumentNullException(nameof(value), "List element can't be null");
        }
    }
    
    #region Modification Methods

    public ListNode AddItem(TfVarsNode node)
    {
        Values.Add(node);
        return this;
    }
    
    public ListNode SetOneLine(bool oneLine)
    {
        OneLine = oneLine;
        return this;
    }
    
    #endregion

    #region IList<TfVarsNode> Implementation
    public int Count => Values.Count;

    public bool IsReadOnly => false;

    public void Add(TfVarsNode item)
    {
        Values.Add(item);
    }

    public void Clear()
    {
        Values.Clear();
    }

    public bool Contains(TfVarsNode item)
    {
        return Values.Contains(item);
    }

    public void CopyTo(TfVarsNode[] array, int arrayIndex)
    {
        Values.CopyTo(array, arrayIndex);
    }

    public int IndexOf(TfVarsNode item)
    {
        return Values.IndexOf(item);
    }

    public void Insert(int index, TfVarsNode item)
    {
        Values.Insert(index, item);
    }

    public bool Remove(TfVarsNode item)
    {
        return Values.Remove(item);
    }

    public void RemoveAt(int index)
    {
        Values.RemoveAt(index);
    }

    public TfVarsNode this[int index]
    {
        get => Values[index];
        set => Values[index] = value ?? throw new ArgumentNullException(nameof(value));
    }
    #endregion
    
}