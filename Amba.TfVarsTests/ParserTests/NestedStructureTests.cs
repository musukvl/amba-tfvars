using Amba.TfVars;
using Amba.TfVars.Extensions;
using Amba.TfVars.Model;

namespace Amba.TfVarsTests.ParserTests;

public class NestedStructureTests
{
    [Fact(DisplayName = "Parse deeply nested map")]
    public void DeeplyNestedMap()
    {
        var parsed = TfVarsContent.Parse("""
            config = {
                level1 = {
                    level2 = {
                        level3 = {
                            value = "deep"
                        }
                    }
                }
            }
            """);
        Assert.Equal("deep", parsed!["config"]["level1"]["level2"]["level3"]["value"].AsString());
    }

    [Fact(DisplayName = "Parse list of maps")]
    public void ListOfMaps()
    {
        var parsed = TfVarsContent.Parse("""
            users = [
                {
                    name = "Alice"
                    age  = 30
                },
                {
                    name = "Bob"
                    age  = 25
                }
            ]
            """);
        var users = parsed!["users"].AsListNode()!;
        Assert.Equal(2, users.Count);
        Assert.Equal("Alice", users.ChildMap(0)!["name"].AsString());
        Assert.Equal(25, (int)users.ChildMap(1)!["age"]!);
    }

    [Fact(DisplayName = "Parse map containing list")]
    public void MapContainingList()
    {
        var parsed = TfVarsContent.Parse("""
            server = {
                name  = "web"
                ports = [80, 443, 8080]
            }
            """);
        var ports = parsed!["server"]["ports"].AsListNode()!;
        Assert.Equal(3, ports.Count);
        Assert.Equal(80, (int)ports.ChildAt(0));
        Assert.Equal(443, (int)ports.ChildAt(1));
        Assert.Equal(8080, (int)ports.ChildAt(2));
    }

    [Fact(DisplayName = "Parse multiple variables")]
    public void MultipleVariables()
    {
        var parsed = TfVarsContent.Parse("""
            name    = "app"
            version = "1.0"
            count   = 3
            enabled = true
            """);
        Assert.Equal("app", parsed!["name"].AsString());
        Assert.Equal("1.0", parsed["version"].AsString());
        Assert.Equal(3, (int)parsed["count"]!);
        Assert.True((bool)parsed["enabled"]!);
    }

    [Fact(DisplayName = "Parse empty map")]
    public void EmptyMap()
    {
        var parsed = TfVarsContent.Parse("config = {}");
        var map = parsed!["config"].AsMapNode();
        Assert.NotNull(map);
        Assert.Empty(map!.Pairs);
    }

    [Fact(DisplayName = "Parse empty list")]
    public void EmptyList()
    {
        var parsed = TfVarsContent.Parse("items = []");
        var list = parsed!["items"].AsListNode();
        Assert.NotNull(list);
        Assert.Empty(list!.Values);
    }

    [Fact(DisplayName = "Nested structure roundtrip serialization")]
    public void NestedRoundtrip()
    {
        const string input = """
            config = {
                db = {
                    host = "localhost"
                    port = 5432
                }
                tags = ["a", "b"]
            }
            """;
        var parsed = TfVarsContent.Parse(input);
        var serialized = TfVarsContent.Serialize(parsed);
        var reparsed = TfVarsContent.Parse(serialized);
        Assert.Equal("localhost", reparsed!["config"]["db"]["host"].AsString());
        Assert.Equal(5432, (int)reparsed["config"]["db"]["port"]!);
    }

    [Fact(DisplayName = "Parse list with nested lists")]
    public void ListWithNestedLists()
    {
        var parsed = TfVarsContent.Parse("""
            matrix = [
                [1, 2, 3],
                [4, 5, 6]
            ]
            """);
        var matrix = parsed!["matrix"].AsListNode()!;
        Assert.Equal(2, matrix.Count);
        var row1 = matrix.ChildAt(0).AsListNode()!;
        Assert.Equal(3, row1.Count);
        Assert.Equal(1, (int)row1.ChildAt(0));
    }

    [Fact(DisplayName = "Parse null variable")]
    public void NullVariable()
    {
        var parsed = TfVarsContent.Parse("value = null");
        Assert.IsType<NullNode>(parsed!["value"]);
    }
}
