using Amba.TfVars;
using Amba.TfVars.Extensions;
using Amba.TfVars.Model;

namespace Amba.TfVarsTests.ModelTests;

public class MapNodeTests
{
    [Fact(DisplayName = "MapNode Add and access by key")]
    public void AddAndAccess()
    {
        var map = new MapNode();
        map.Add("name", new StringNode("test"));
        Assert.Equal("test", map["name"].AsString());
    }

    [Fact(DisplayName = "MapNode Add returns self for chaining")]
    public void AddReturnsSelf()
    {
        var map = new MapNode();
        var result = map.Add("a", new StringNode("1")).Add("b", new StringNode("2"));
        Assert.Same(map, result);
        Assert.Equal(2, map.Pairs.Count);
    }

    [Fact(DisplayName = "MapNode Remove existing key")]
    public void RemoveExistingKey()
    {
        var map = new MapNode();
        map.Add("a", new StringNode("1"));
        map.Add("b", new StringNode("2"));
        map.Remove("a");
        Assert.Single(map.Pairs);
        Assert.Null(map["a"]);
    }

    [Fact(DisplayName = "MapNode Remove non-existent key is safe")]
    public void RemoveNonExistentKey()
    {
        var map = new MapNode();
        map.Add("a", new StringNode("1"));
        var result = map.Remove("nonexistent");
        Assert.Same(map, result);
        Assert.Single(map.Pairs);
    }

    [Fact(DisplayName = "MapNode Property with comments")]
    public void PropertyWithComments()
    {
        var map = new MapNode();
        map.Property("name", new StringNode("test"), "# This is a comment");
        var pair = map.Child("name");
        Assert.Single(pair.CommentsBefore);
        Assert.Equal("# This is a comment", pair.CommentsBefore[0]);
    }

    [Fact(DisplayName = "MapNode Property with multiline comments")]
    public void PropertyWithMultilineComments()
    {
        var map = new MapNode();
        map.Property("name", new StringNode("test"), "# Line 1\n# Line 2");
        var pair = map.Child("name");
        Assert.Equal(2, pair.CommentsBefore.Length);
    }

    [Fact(DisplayName = "MapNode ParagraphProperty adds empty comment")]
    public void ParagraphProperty()
    {
        var map = new MapNode();
        map.Add("a", new StringNode("1"));
        map.ParagraphProperty("b", new StringNode("2"));
        var pair = map.Child("b");
        Assert.Single(pair.CommentsBefore);
        Assert.Equal("", pair.CommentsBefore[0]);
    }

    [Fact(DisplayName = "MapNode Child throws for missing key")]
    public void ChildThrowsForMissingKey()
    {
        var map = new MapNode();
        Assert.Throws<ArgumentException>(() => map.Child("missing"));
    }

    [Fact(DisplayName = "MapNode indexer returns null for missing key")]
    public void IndexerReturnsNullForMissing()
    {
        var map = new MapNode();
        Assert.Null(map["missing"]);
    }

    [Fact(DisplayName = "MapNode indexer setter updates existing key")]
    public void IndexerUpdatesExisting()
    {
        var map = new MapNode();
        map.Add("key", new StringNode("old"));
        ((TfVarsNode)map)["key"] = new StringNode("new");
        Assert.Equal("new", map["key"].AsString());
    }

    [Fact(DisplayName = "MapNode indexer setter adds new key")]
    public void IndexerAddsNew()
    {
        var map = new MapNode();
        ((TfVarsNode)map)["key"] = new StringNode("value");
        Assert.Equal("value", map["key"].AsString());
    }

    [Fact(DisplayName = "MapNode indexer with non-string key throws")]
    public void IndexerNonStringKeyThrows()
    {
        var map = new MapNode();
        Assert.Throws<ArgumentException>(() => ((TfVarsNode)map)[42]);
    }

    [Fact(DisplayName = "MapNode indexer setter with non-string key throws")]
    public void IndexerSetterNonStringKeyThrows()
    {
        var map = new MapNode();
        Assert.Throws<ArgumentException>(() => ((TfVarsNode)map)[42] = new StringNode("v"));
    }

    [Fact(DisplayName = "MapNode constructor with Dictionary<string, TfVarsNode>")]
    public void ConstructorDictionaryTfVarsNode()
    {
        var dict = new Dictionary<string, TfVarsNode>
        {
            ["a"] = new StringNode("1"),
            ["b"] = new NumberNode(2)
        };
        var map = new MapNode(dict);
        Assert.Equal(2, map.Pairs.Count);
        Assert.Equal("1", map["a"].AsString());
    }

    [Fact(DisplayName = "MapNode constructor with Dictionary<string, string>")]
    public void ConstructorDictionaryString()
    {
        var dict = new Dictionary<string, string>
        {
            ["a"] = "1",
            ["b"] = "2"
        };
        var map = new MapNode(dict);
        Assert.Equal(2, map.Pairs.Count);
    }

    [Fact(DisplayName = "MapNode constructor with List<KeyValuePair>")]
    public void ConstructorKeyValuePairList()
    {
        var pairs = new List<KeyValuePair<string, TfVarsNode>>
        {
            new("a", new StringNode("1")),
            new("b", new StringNode("2"))
        };
        var map = new MapNode(pairs);
        Assert.Equal(2, map.Pairs.Count);
    }

    [Fact(DisplayName = "MapNode SetOneLine returns self")]
    public void SetOneLineReturnsSelf()
    {
        var map = new MapNode();
        var result = map.SetOneLine(true);
        Assert.Same(map, result);
        Assert.True(map.OneLine);
    }

    [Fact(DisplayName = "MapNode Children returns MapPairNodes")]
    public void ChildrenReturnsPairs()
    {
        var map = new MapNode();
        map.Add("a", new StringNode("1"));
        map.Add("b", new StringNode("2"));
        var children = map.Children().ToList();
        Assert.Equal(2, children.Count);
        Assert.All(children, c => Assert.IsType<MapPairNode>(c));
    }
}
