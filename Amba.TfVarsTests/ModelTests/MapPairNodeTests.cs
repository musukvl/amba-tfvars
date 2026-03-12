using Amba.TfVars.Model;

namespace Amba.TfVarsTests.ModelTests;

public class MapPairNodeTests
{
    [Fact(DisplayName = "MapPairNode trims quotes from key")]
    public void KeyTrimsQuotes()
    {
        var pair = new MapPairNode("\"mykey\"", new StringNode("val"));
        Assert.Equal("mykey", pair.Key);
        Assert.Equal("\"mykey\"", pair.OriginalKey);
    }

    [Fact(DisplayName = "MapPairNode preserves unquoted key")]
    public void KeyUnquoted()
    {
        var pair = new MapPairNode("mykey", new StringNode("val"));
        Assert.Equal("mykey", pair.Key);
        Assert.Equal("mykey", pair.OriginalKey);
    }

    [Fact(DisplayName = "MapPairNode CommentsBefore defaults empty")]
    public void CommentsBeforeDefaultsEmpty()
    {
        var pair = new MapPairNode("key", new StringNode("val"));
        Assert.Empty(pair.CommentsBefore);
    }

    [Fact(DisplayName = "MapPairNode indexer delegates to Value")]
    public void IndexerDelegatesToValue()
    {
        var innerMap = new MapNode();
        innerMap.Add("inner", new StringNode("value"));
        var pair = new MapPairNode("key", innerMap);
        Assert.Equal("value", pair["inner"]?.ToString());
    }

    [Fact(DisplayName = "MapPairNode Value can be set")]
    public void ValueCanBeSet()
    {
        var pair = new MapPairNode("key", new StringNode("old"));
        pair.Value = new StringNode("new");
        Assert.Equal("new", ((StringNode)pair.Value).Value);
    }
}
