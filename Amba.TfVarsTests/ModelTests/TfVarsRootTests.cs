using Amba.TfVars;
using Amba.TfVars.Extensions;
using Amba.TfVars.Model;

namespace Amba.TfVarsTests.ModelTests;

public class TfVarsRootTests
{
    [Fact(DisplayName = "TfVarsRoot indexer get returns variable value")]
    public void IndexerGet()
    {
        var parsed = TfVarsContent.Parse("""name = "test" """);
        Assert.Equal("test", parsed!["name"].AsString());
    }

    [Fact(DisplayName = "TfVarsRoot indexer get returns null for missing variable")]
    public void IndexerGetMissing()
    {
        var parsed = TfVarsContent.Parse("""name = "test" """);
        Assert.Null(parsed!["missing"]);
    }

    [Fact(DisplayName = "TfVarsRoot indexer set creates new variable")]
    public void IndexerSetNew()
    {
        var root = new TfVarsRoot();
        root["name"] = new StringNode("test");
        Assert.Equal("test", root["name"].AsString());
        Assert.Contains("name", root.Variables.Keys);
    }

    [Fact(DisplayName = "TfVarsRoot indexer set replaces existing variable")]
    public void IndexerSetReplace()
    {
        var root = new TfVarsRoot();
        root["name"] = new StringNode("old");
        root["name"] = new StringNode("new");
        Assert.Equal("new", root["name"].AsString());
    }

    [Fact(DisplayName = "TfVarsRoot indexer with non-string key throws")]
    public void IndexerNonStringThrows()
    {
        var root = new TfVarsRoot();
        Assert.Throws<ArgumentException>(() => ((TfVarsNode)root)[42]);
    }

    [Fact(DisplayName = "TfVarsRoot indexer setter with non-string key throws")]
    public void IndexerSetterNonStringThrows()
    {
        var root = new TfVarsRoot();
        Assert.Throws<ArgumentException>(() => ((TfVarsNode)root)[42] = new StringNode("v"));
    }

    [Fact(DisplayName = "TfVarsRoot Child returns VariableDefinitionNode")]
    public void ChildReturnsVariable()
    {
        var parsed = TfVarsContent.Parse("""name = "test" """);
        var child = parsed!.Child("name");
        Assert.NotNull(child);
        Assert.Equal("name", child!.Name);
        Assert.Equal("test", child.Value.AsString());
    }

    [Fact(DisplayName = "TfVarsRoot Child returns null for missing")]
    public void ChildReturnsNullForMissing()
    {
        var root = new TfVarsRoot();
        Assert.Null(root.Child("missing"));
    }

    [Fact(DisplayName = "Parse returns null for empty input")]
    public void ParseEmptyReturnsNull()
    {
        Assert.Null(TfVarsContent.Parse(""));
        Assert.Null(TfVarsContent.Parse("  "));
        Assert.Null(TfVarsContent.Parse("\n"));
    }

    [Fact(DisplayName = "Serialize returns empty string for null node")]
    public void SerializeNullReturnsEmpty()
    {
        Assert.Equal(string.Empty, TfVarsContent.Serialize(null));
    }
}
