using Amba.TfVars;
using Amba.TfVars.Model;
using Amba.TfVars.Serializer;

namespace Amba.TfVarsTests.SerializerTests;

public class SerializerOptionsTests
{
    [Fact(DisplayName = "Default serializer options")]
    public void DefaultOptions()
    {
        var options = SerializerOptions.Default;
        Assert.True(options.Indent);
        Assert.Equal(4, options.IndentSize);
        Assert.False(options.IncludeListTrailingComma);
    }

    [Fact(DisplayName = "IncludeListTrailingComma removes commas between list items")]
    public void IncludeListTrailingCommaRemovesCommas()
    {
        var root = new TfVarsRoot(new Dictionary<string, TfVarsNode>
        {
            ["tags"] = new ListNode(new StringNode("a"), new StringNode("b"))
        });
        var withCommas = TfVarsContent.Serialize(root);
        var withoutCommas = TfVarsContent.Serialize(root, new SerializerOptions { IncludeListTrailingComma = true });
        Assert.Contains(",", withCommas);
        Assert.DoesNotContain(",", withoutCommas);
    }

    [Fact(DisplayName = "Serialize with custom indent size")]
    public void CustomIndentSize()
    {
        var root = new TfVarsRoot(new Dictionary<string, TfVarsNode>
        {
            ["config"] = new MapNode()
                .Add("key", new StringNode("value"))
        });
        var options = new SerializerOptions { IndentSize = 2 };
        var result = TfVarsContent.Serialize(root, options);
        Assert.Contains("  key", result);
        Assert.DoesNotContain("    key", result);
    }

    [Fact(DisplayName = "Serialize with no indent")]
    public void NoIndent()
    {
        var root = new TfVarsRoot(new Dictionary<string, TfVarsNode>
        {
            ["config"] = new MapNode()
                .Add("key", new StringNode("value"))
        });
        var options = new SerializerOptions { Indent = false };
        var result = TfVarsContent.Serialize(root, options);
        Assert.DoesNotContain("    ", result);
    }
}
