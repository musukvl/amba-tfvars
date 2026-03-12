using Amba.TfVars;
using Amba.TfVars.Extensions;
using Amba.TfVars.Model;

namespace Amba.TfVarsTests.Extensions;

public class TfVarsNodeExtensionTests
{
    [Fact(DisplayName = "AsMapNode returns MapNode for map")]
    public void AsMapNodeReturnsMap()
    {
        var parsed = TfVarsContent.Parse("m = { a = 1 }");
        var map = parsed!["m"].AsMapNode();
        Assert.NotNull(map);
        Assert.IsType<MapNode>(map);
    }

    [Fact(DisplayName = "AsMapNode returns null for NullNode")]
    public void AsMapNodeNullNode()
    {
        var node = new NullNode();
        Assert.Null(node.AsMapNode());
    }

    [Fact(DisplayName = "AsMapNode returns null for non-map node")]
    public void AsMapNodeNonMapNode()
    {
        var node = new StringNode("hello");
        Assert.Null(node.AsMapNode());
    }

    [Fact(DisplayName = "AsListNode returns ListNode for list")]
    public void AsListNodeReturnsList()
    {
        var parsed = TfVarsContent.Parse("""items = ["a", "b"]""");
        var list = parsed!["items"].AsListNode();
        Assert.NotNull(list);
        Assert.IsType<ListNode>(list);
    }

    [Fact(DisplayName = "AsListNode returns null for NullNode")]
    public void AsListNodeNullNode()
    {
        var node = new NullNode();
        Assert.Null(node.AsListNode());
    }

    [Fact(DisplayName = "AsBoolNode returns BoolNode for bool")]
    public void AsBoolNodeReturnsBool()
    {
        var parsed = TfVarsContent.Parse("flag = true");
        var boolNode = parsed!["flag"].AsBoolNode();
        Assert.NotNull(boolNode);
        Assert.True(boolNode!.Value);
    }

    [Fact(DisplayName = "AsBoolNode returns null for NullNode")]
    public void AsBoolNodeNullNode()
    {
        var node = new NullNode();
        Assert.Null(node.AsBoolNode());
    }

    [Fact(DisplayName = "AsStringNode returns StringNode")]
    public void AsStringNodeReturnsString()
    {
        var parsed = TfVarsContent.Parse("""name = "test" """);
        var str = parsed!["name"].AsStringNode();
        Assert.NotNull(str);
        Assert.Equal("test", str!.Value);
    }

    [Fact(DisplayName = "AsStringNode returns null for NullNode")]
    public void AsStringNodeNullNode()
    {
        var node = new NullNode();
        Assert.Null(node.AsStringNode());
    }

    [Fact(DisplayName = "AsNumberNode returns NumberNode")]
    public void AsNumberNodeReturnsNumber()
    {
        var parsed = TfVarsContent.Parse("count = 42");
        var num = parsed!["count"].AsNumberNode();
        Assert.NotNull(num);
        Assert.Equal(42m, num!.Value);
    }

    [Fact(DisplayName = "AsNumberNode returns null for NullNode")]
    public void AsNumberNodeNullNode()
    {
        var node = new NullNode();
        Assert.Null(node.AsNumberNode());
    }

    [Fact(DisplayName = "AsValueNode returns ValueNode")]
    public void AsValueNodeReturnsValue()
    {
        var node = new StringNode("test");
        var value = node.AsValueNode();
        Assert.NotNull(value);
    }

    [Fact(DisplayName = "AsValueNode returns null for non-value node")]
    public void AsValueNodeNonValueNode()
    {
        var node = new MapNode();
        Assert.Null(node.AsValueNode());
    }
}
