using Amba.TfVars;
using Amba.TfVars.Extensions;
using Amba.TfVars.Model;

namespace Amba.TfVarsTests.Extensions;

public class MapNodeExtensionsAddAfterTests
{
    [Fact(DisplayName = "AddAfter inserts after specified key")]
    public void AddAfterInsertsAfterKey()
    {
        var map = new MapNode();
        map.Add("a", new StringNode("1"));
        map.Add("c", new StringNode("3"));
        map.AddAfter("a", "b", new StringNode("2"));

        var keys = map.Pairs.Select(p => p.Key).ToList();
        Assert.Equal(["a", "b", "c"], keys);
    }

    [Fact(DisplayName = "AddAfter with string value overload")]
    public void AddAfterStringOverload()
    {
        var map = new MapNode();
        map.Add("a", new StringNode("1"));
        map.AddAfter("a", "b", "2");

        Assert.Equal(2, map.Pairs.Count);
        Assert.Equal("2", map["b"].AsString());
    }

    [Fact(DisplayName = "AddAfter adds to end when key not found")]
    public void AddAfterKeyNotFoundAddsLast()
    {
        var map = new MapNode();
        map.Add("a", new StringNode("1"));
        map.AddAfter("nonexistent", "b", new StringNode("2"));

        var keys = map.Pairs.Select(p => p.Key).ToList();
        Assert.Equal(["a", "b"], keys);
    }

    [Fact(DisplayName = "AddAfter on empty map adds first")]
    public void AddAfterEmptyMap()
    {
        var map = new MapNode();
        map.AddAfter("any", "first", new StringNode("1"));

        Assert.Single(map.Pairs);
        Assert.Equal("first", map.Pairs.First!.Value.Key);
    }

    [Fact(DisplayName = "ChildMap returns nested map")]
    public void ChildMapReturnsNestedMap()
    {
        var parsed = TfVarsContent.Parse("""
            config = {
                db = {
                    host = "localhost"
                }
            }
            """);
        var config = parsed!["config"].AsMapNode()!;
        var db = config.ChildMap("db");
        Assert.NotNull(db);
        Assert.Equal("localhost", db!["host"].AsString());
    }

    [Fact(DisplayName = "ChildMap returns null for missing key")]
    public void ChildMapMissingKey()
    {
        var map = new MapNode();
        Assert.Null(map.ChildMap("missing"));
    }

    [Fact(DisplayName = "ChildMaps enumerates all child maps")]
    public void ChildMapsEnumeratesAll()
    {
        var parsed = TfVarsContent.Parse("""
            servers = {
                web = {
                    port = 80
                }
                api = {
                    port = 8080
                }
            }
            """);
        var servers = parsed!["servers"].AsMapNode()!;
        var maps = servers.ChildMaps().ToList();
        Assert.Equal(2, maps.Count);
    }

    [Fact(DisplayName = "Values enumerates all pair values")]
    public void ValuesEnumeratesAll()
    {
        var map = new MapNode();
        map.Add("a", new StringNode("1"));
        map.Add("b", new NumberNode(2));
        var values = map.Values().ToList();
        Assert.Equal(2, values.Count);
    }

    [Fact(DisplayName = "FindNode finds matching node in LinkedList")]
    public void FindNodeFindsMatch()
    {
        var list = new LinkedList<int>();
        list.AddLast(1);
        list.AddLast(2);
        list.AddLast(3);
        var found = list.FindNode(x => x == 2);
        Assert.NotNull(found);
        Assert.Equal(2, found!.Value);
    }

    [Fact(DisplayName = "FindNode returns null when no match")]
    public void FindNodeNoMatch()
    {
        var list = new LinkedList<int>();
        list.AddLast(1);
        list.AddLast(2);
        var found = list.FindNode(x => x == 99);
        Assert.Null(found);
    }

    [Fact(DisplayName = "ReorderKeys with partial key list")]
    public void ReorderKeysPartialList()
    {
        var map = new MapNode();
        map.Add("c", new StringNode("3"));
        map.Add("b", new StringNode("2"));
        map.Add("a", new StringNode("1"));
        map.ReorderKeys("a");

        var keys = map.Pairs.Select(p => p.Key).ToList();
        Assert.Equal("a", keys[0]);
        Assert.Equal(3, keys.Count);
    }

    [Fact(DisplayName = "ReorderKeys with non-existent key is safe")]
    public void ReorderKeysNonExistentKey()
    {
        var map = new MapNode();
        map.Add("a", new StringNode("1"));
        map.Add("b", new StringNode("2"));
        map.ReorderKeys("nonexistent", "a");

        var keys = map.Pairs.Select(p => p.Key).ToList();
        Assert.Equal("a", keys[0]);
    }
}
