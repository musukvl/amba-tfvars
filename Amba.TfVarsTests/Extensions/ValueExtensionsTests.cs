using Amba.TfVars;
using Amba.TfVars.Extensions;
using Amba.TfVars.Model;

namespace Amba.TfVarsTests.Extensions;

public class ValueExtensionsTests
{
    [Fact(DisplayName = "AsBool returns true for true value")]
    public void AsBoolTrue()
    {
        var parsed = TfVarsContent.Parse("flag = true");
        Assert.True(parsed!["flag"].AsBool());
    }

    [Fact(DisplayName = "AsBool returns false for false value")]
    public void AsBoolFalse()
    {
        var parsed = TfVarsContent.Parse("flag = false");
        Assert.False(parsed!["flag"].AsBool());
    }

    [Fact(DisplayName = "AsBool returns null for NullNode")]
    public void AsBoolNullNode()
    {
        var node = new NullNode();
        Assert.Null(node.AsBool());
    }

    [Fact(DisplayName = "AsBool returns null for null reference")]
    public void AsBoolNullReference()
    {
        TfVarsNode? node = null;
        Assert.Null(node.AsBool());
    }

    [Fact(DisplayName = "AsString returns string value")]
    public void AsStringStringNode()
    {
        var parsed = TfVarsContent.Parse("""name = "hello" """);
        Assert.Equal("hello", parsed!["name"].AsString());
    }

    [Fact(DisplayName = "AsString returns null for NullNode")]
    public void AsStringNullNode()
    {
        var node = new NullNode();
        Assert.Null(node.AsString());
    }

    [Fact(DisplayName = "AsString returns null for null reference")]
    public void AsStringNullReference()
    {
        TfVarsNode? node = null;
        Assert.Null(node.AsString());
    }

    [Fact(DisplayName = "AsString returns number as string")]
    public void AsStringNumberNode()
    {
        var parsed = TfVarsContent.Parse("count = 42");
        Assert.Equal("42", parsed!["count"].AsString());
    }

    [Fact(DisplayName = "AsString returns bool as string")]
    public void AsStringBoolNode()
    {
        var parsed = TfVarsContent.Parse("flag = true");
        Assert.Equal("True", parsed!["flag"].AsString());
    }

    [Fact(DisplayName = "AsString throws for MapNode")]
    public void AsStringThrowsForMap()
    {
        var parsed = TfVarsContent.Parse("m = { a = 1 }");
        Assert.Throws<InvalidOperationException>(() => parsed!["m"].AsString());
    }

    [Fact(DisplayName = "AsDecimal returns decimal from NumberNode")]
    public void AsDecimalNumberNode()
    {
        var parsed = TfVarsContent.Parse("price = 19.99");
        Assert.Equal(19.99m, parsed!["price"].AsDecimal());
    }

    [Fact(DisplayName = "AsDecimal returns null for null reference")]
    public void AsDecimalNullReference()
    {
        TfVarsNode? node = null;
        Assert.Null(node.AsDecimal());
    }

    [Fact(DisplayName = "AsDecimal returns 0 for NullNode")]
    public void AsDecimalNullNode()
    {
        var node = new NullNode();
        Assert.Equal(0m, node.AsDecimal());
    }

    [Fact(DisplayName = "AsDecimal parses string containing number")]
    public void AsDecimalStringNode()
    {
        var node = new StringNode("123.45");
        Assert.Equal(123.45m, node.AsDecimal());
    }

    [Fact(DisplayName = "AsDecimal throws for non-numeric string")]
    public void AsDecimalThrowsForNonNumericString()
    {
        var node = new StringNode("abc");
        Assert.Throws<InvalidOperationException>(() => node.AsDecimal());
    }

    [Fact(DisplayName = "ToDictionary returns dictionary from MapNode")]
    public void ToDictionaryMapNode()
    {
        var parsed = TfVarsContent.Parse("""
            config = {
                a = "1"
                b = "2"
            }
            """);
        var dict = parsed!["config"].ToDictionary();
        Assert.NotNull(dict);
        Assert.Equal(2, dict!.Count);
        Assert.Equal("1", dict["a"].AsString());
        Assert.Equal("2", dict["b"].AsString());
    }

    [Fact(DisplayName = "ToDictionary returns null for NullNode")]
    public void ToDictionaryNullNode()
    {
        var node = new NullNode();
        Assert.Null(node.ToDictionary());
    }

    [Fact(DisplayName = "ToDictionary returns empty dict for null reference")]
    public void ToDictionaryNullReference()
    {
        TfVarsNode? node = null;
        var dict = node.ToDictionary();
        Assert.NotNull(dict);
        Assert.Empty(dict!);
    }

    [Fact(DisplayName = "AsListOfStrings returns list of string values")]
    public void AsListOfStringsListNode()
    {
        var parsed = TfVarsContent.Parse("""tags = ["a", "b", "c"]""");
        var list = parsed!["tags"].AsListOfStrings();
        Assert.NotNull(list);
        Assert.Equal(3, list!.Count);
        Assert.Equal("a", list[0]);
        Assert.Equal("b", list[1]);
        Assert.Equal("c", list[2]);
    }

    [Fact(DisplayName = "AsListOfStrings returns null for NullNode")]
    public void AsListOfStringsNullNode()
    {
        var node = new NullNode();
        Assert.Null(node.AsListOfStrings());
    }

    [Fact(DisplayName = "AsListOfStrings returns empty list for null reference")]
    public void AsListOfStringsNullReference()
    {
        TfVarsNode? node = null;
        var list = node.AsListOfStrings();
        Assert.NotNull(list);
        Assert.Empty(list!);
    }

    [Fact(DisplayName = "AsListOfStrings throws for MapNode")]
    public void AsListOfStringsThrowsForMap()
    {
        var node = new MapNode();
        Assert.Throws<InvalidOperationException>(() => node.AsListOfStrings());
    }
}
