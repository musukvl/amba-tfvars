using Amba.TfVars;
using Amba.TfVars.Model;

namespace Amba.TfVarsTests.ModelTests;

public class TfVarsNodeOperatorTests
{
    [Fact(DisplayName = "Explicit cast to bool")]
    public void ExplicitBoolCast()
    {
        var node = new BoolNode(true);
        Assert.True((bool)(TfVarsNode)node);
    }

    [Fact(DisplayName = "Explicit cast to bool throws for non-BoolNode")]
    public void ExplicitBoolCastThrowsForString()
    {
        TfVarsNode node = new StringNode("test");
        Assert.Throws<InvalidCastException>(() => (bool)node);
    }

    [Fact(DisplayName = "Explicit cast to string")]
    public void ExplicitStringCast()
    {
        var node = new StringNode("hello");
        Assert.Equal("hello", (string)(TfVarsNode)node);
    }

    [Fact(DisplayName = "Explicit cast to string throws for non-StringNode")]
    public void ExplicitStringCastThrowsForNumber()
    {
        TfVarsNode node = new NumberNode(42);
        Assert.Throws<InvalidCastException>(() => (string)node);
    }

    [Fact(DisplayName = "Explicit cast to int")]
    public void ExplicitIntCast()
    {
        var node = new NumberNode(42);
        Assert.Equal(42, (int)(TfVarsNode)node);
    }

    [Fact(DisplayName = "Explicit cast to int throws for non-NumberNode")]
    public void ExplicitIntCastThrowsForBool()
    {
        TfVarsNode node = new BoolNode(true);
        Assert.Throws<InvalidCastException>(() => (int)node);
    }

    [Fact(DisplayName = "Explicit cast to decimal")]
    public void ExplicitDecimalCast()
    {
        var node = new NumberNode(19.99m);
        Assert.Equal(19.99m, (decimal)(TfVarsNode)node);
    }

    [Fact(DisplayName = "Implicit cast from string creates StringNode")]
    public void ImplicitStringToNode()
    {
        TfVarsNode node = "hello";
        Assert.IsType<StringNode>(node);
        Assert.Equal("hello", ((StringNode)node).Value);
    }

    [Fact(DisplayName = "Base indexer throws for unsupported types")]
    public void BaseIndexerThrows()
    {
        TfVarsNode node = new StringNode("test");
        Assert.Throws<InvalidOperationException>(() => node["key"]);
    }

    [Fact(DisplayName = "Base indexer setter throws for unsupported types")]
    public void BaseIndexerSetterThrows()
    {
        TfVarsNode node = new StringNode("test");
        Assert.Throws<InvalidOperationException>(() => node["key"] = new StringNode("val"));
    }

    [Fact(DisplayName = "Children returns empty for leaf nodes")]
    public void ChildrenEmptyForLeafNodes()
    {
        TfVarsNode node = new StringNode("test");
        Assert.Empty(node.Children());
    }
}
