using Amba.TfVars;
using Amba.TfVars.Extensions;
using Amba.TfVars.Model;

namespace Amba.TfVarsTests.Extensions;

public class ListNodeExtensionsTests
{
    [Fact(DisplayName = "ChildMap returns map at index")]
    public void ChildMapReturnsMap()
    {
        var parsed = TfVarsContent.Parse("""
            items = [
                {
                    name = "first"
                },
                {
                    name = "second"
                }
            ]
            """);
        var list = parsed!["items"].AsListNode()!;
        var map = list.ChildMap(1);
        Assert.NotNull(map);
        Assert.Equal("second", map!["name"].AsString());
    }

    [Fact(DisplayName = "ChildMap returns null for out-of-bounds index")]
    public void ChildMapOutOfBounds()
    {
        var list = new ListNode();
        Assert.Null(list.ChildMap(0));
    }

    [Fact(DisplayName = "ChildMaps enumerates all maps in list")]
    public void ChildMapsEnumeratesAll()
    {
        var parsed = TfVarsContent.Parse("""
            items = [
                {
                    name = "a"
                },
                {
                    name = "b"
                }
            ]
            """);
        var list = parsed!["items"].AsListNode()!;
        var maps = list.ChildMaps().ToList();
        Assert.Equal(2, maps.Count);
    }

    [Fact(DisplayName = "ChildStrings enumerates all strings in list")]
    public void ChildStringsEnumeratesAll()
    {
        var parsed = TfVarsContent.Parse("""tags = ["dev", "test", "prod"]""");
        var list = parsed!["tags"].AsListNode()!;
        var strings = list.ChildStrings().ToList();
        Assert.Equal(3, strings.Count);
        Assert.Equal("dev", strings[0].Value);
        Assert.Equal("test", strings[1].Value);
        Assert.Equal("prod", strings[2].Value);
    }
}
