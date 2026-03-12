using Amba.TfVars;
using Amba.TfVars.Extensions;
using Amba.TfVars.Model;

namespace Amba.TfVarsTests.ModelTests;

public class ListNodeTests
{
    [Fact(DisplayName = "ListNode IList Add and Count")]
    public void IListAddAndCount()
    {
        var list = new ListNode();
        list.Add(new StringNode("a"));
        list.Add(new StringNode("b"));
        Assert.Equal(2, list.Count);
    }

    [Fact(DisplayName = "ListNode IList Contains")]
    public void IListContains()
    {
        var list = new ListNode();
        var node = new StringNode("a");
        list.Add(node);
        // Testing IList.Contains by reference equality
        var containsNode = list.Contains(node);
        var containsNew = list.Contains(new StringNode("b"));
#pragma warning disable xUnit2017
        Assert.True(containsNode);
        Assert.False(containsNew);
#pragma warning restore xUnit2017
    }

    [Fact(DisplayName = "ListNode IList IndexOf")]
    public void IListIndexOf()
    {
        var list = new ListNode();
        var node = new StringNode("a");
        list.Add(new StringNode("x"));
        list.Add(node);
        Assert.Equal(1, list.IndexOf(node));
    }

    [Fact(DisplayName = "ListNode IList Insert")]
    public void IListInsert()
    {
        var list = new ListNode();
        list.Add(new StringNode("a"));
        list.Add(new StringNode("c"));
        list.Insert(1, new StringNode("b"));
        Assert.Equal(3, list.Count);
        Assert.Equal("b", list[1].AsString());
    }

    [Fact(DisplayName = "ListNode IList Remove")]
    public void IListRemove()
    {
        var list = new ListNode();
        var node = new StringNode("a");
        list.Add(node);
        list.Add(new StringNode("b"));
        Assert.True(list.Remove(node));
        Assert.Single(list.Values);
        Assert.Equal("b", list[0].AsString());
    }

    [Fact(DisplayName = "ListNode IList RemoveAt")]
    public void IListRemoveAt()
    {
        var list = new ListNode();
        list.Add(new StringNode("a"));
        list.Add(new StringNode("b"));
        list.Add(new StringNode("c"));
        list.RemoveAt(1);
        Assert.Equal(2, list.Count);
        Assert.Equal("c", list[1].AsString());
    }

    [Fact(DisplayName = "ListNode IList Clear")]
    public void IListClear()
    {
        var list = new ListNode();
        list.Add(new StringNode("a"));
        list.Add(new StringNode("b"));
        list.Clear();
        Assert.Empty(list.Values);
    }

    [Fact(DisplayName = "ListNode IList CopyTo")]
    public void IListCopyTo()
    {
        var list = new ListNode();
        list.Add(new StringNode("a"));
        list.Add(new StringNode("b"));
        var array = new TfVarsNode[2];
        list.CopyTo(array, 0);
        Assert.Equal("a", ((StringNode)array[0]).Value);
        Assert.Equal("b", ((StringNode)array[1]).Value);
    }

    [Fact(DisplayName = "ListNode IsReadOnly is false")]
    public void IsReadOnlyFalse()
    {
        var list = new ListNode();
        Assert.False(list.IsReadOnly);
    }

    [Fact(DisplayName = "ListNode typed indexer get and set")]
    public void TypedIndexer()
    {
        var list = new ListNode();
        list.Add(new StringNode("a"));
        Assert.Equal("a", ((StringNode)list[0]).Value);

        list[0] = new StringNode("b");
        Assert.Equal("b", ((StringNode)list[0]).Value);
    }

    [Fact(DisplayName = "ListNode typed indexer setter rejects null")]
    public void TypedIndexerNullThrows()
    {
        var list = new ListNode();
        list.Add(new StringNode("a"));
        Assert.Throws<ArgumentNullException>(() => list[0] = null!);
    }

    [Fact(DisplayName = "ListNode object indexer with non-int key throws")]
    public void ObjectIndexerNonIntKeyThrows()
    {
        var list = new ListNode();
        Assert.Throws<ArgumentException>(() => ((TfVarsNode)list)["key"]);
    }

    [Fact(DisplayName = "ListNode object indexer setter with non-int key throws")]
    public void ObjectIndexerSetterNonIntKeyThrows()
    {
        var list = new ListNode();
        Assert.Throws<ArgumentException>(() => ((TfVarsNode)list)["key"] = new StringNode("v"));
    }

    [Fact(DisplayName = "ListNode object indexer setter rejects null")]
    public void ObjectIndexerSetterNullThrows()
    {
        var list = new ListNode();
        list.Add(new StringNode("a"));
        Assert.Throws<ArgumentNullException>(() => ((TfVarsNode)list)[0] = null);
    }

    [Fact(DisplayName = "ListNode constructor with params")]
    public void ConstructorParams()
    {
        var list = new ListNode(new StringNode("a"), new StringNode("b"));
        Assert.Equal(2, list.Count);
    }

    [Fact(DisplayName = "ListNode constructor with List and oneLine")]
    public void ConstructorListAndOneLine()
    {
        var values = new List<TfVarsNode> { new StringNode("a") };
        var list = new ListNode(values, oneLine: true);
        Assert.Single(list.Values);
        Assert.True(list.OneLine);
    }

    [Fact(DisplayName = "ListNode ChildAt returns correct element")]
    public void ChildAt()
    {
        var list = new ListNode();
        list.Add(new StringNode("first"));
        list.Add(new StringNode("second"));
        var child = list.ChildAt(1);
        Assert.Equal("second", ((StringNode)child).Value);
    }

    [Fact(DisplayName = "ListNode Children returns all values")]
    public void ChildrenReturnsValues()
    {
        var list = new ListNode();
        list.Add(new StringNode("a"));
        list.Add(new StringNode("b"));
        Assert.Equal(2, list.Children().Count());
    }

    [Fact(DisplayName = "ListNode AddItem returns self for chaining")]
    public void AddItemReturnsSelf()
    {
        var list = new ListNode();
        var result = list.AddItem(new StringNode("a")).AddItem(new StringNode("b"));
        Assert.Same(list, result);
        Assert.Equal(2, list.Count);
    }

    [Fact(DisplayName = "ListNode SetOneLine returns self for chaining")]
    public void SetOneLineReturnsSelf()
    {
        var list = new ListNode();
        var result = list.SetOneLine(true);
        Assert.Same(list, result);
        Assert.True(list.OneLine);
    }
}
