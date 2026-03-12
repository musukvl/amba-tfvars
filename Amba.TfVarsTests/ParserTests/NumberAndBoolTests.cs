using Amba.TfVars;
using Amba.TfVars.Extensions;
using Amba.TfVars.Model;

namespace Amba.TfVarsTests.ParserTests;

public class NumberAndBoolTests
{
    [Fact(DisplayName = "Parse integer value")]
    public void ParseInteger()
    {
        var parsed = TfVarsContent.Parse("count = 42");
        Assert.Equal(42, (int)parsed!["count"]!);
    }

    [Fact(DisplayName = "Parse decimal value")]
    public void ParseDecimal()
    {
        var parsed = TfVarsContent.Parse("price = 19.99");
        Assert.Equal(19.99m, (decimal)parsed!["price"]!);
    }

    [Fact(DisplayName = "Parse negative number")]
    public void ParseNegativeNumber()
    {
        var parsed = TfVarsContent.Parse("offset = -5");
        Assert.Equal(-5, (int)parsed!["offset"]!);
    }

    [Fact(DisplayName = "Parse zero")]
    public void ParseZero()
    {
        var parsed = TfVarsContent.Parse("zero = 0");
        Assert.Equal(0, (int)parsed!["zero"]!);
    }

    [Fact(DisplayName = "Parse true boolean")]
    public void ParseTrue()
    {
        var parsed = TfVarsContent.Parse("enabled = true");
        Assert.True((bool)parsed!["enabled"]!);
    }

    [Fact(DisplayName = "Parse false boolean")]
    public void ParseFalse()
    {
        var parsed = TfVarsContent.Parse("enabled = false");
        Assert.False((bool)parsed!["enabled"]!);
    }

    [Fact(DisplayName = "Parse multiple value types in same file")]
    public void ParseMixedTypes()
    {
        var parsed = TfVarsContent.Parse("""
            name    = "app"
            count   = 3
            enabled = true
            ratio   = 0.75
            """);
        Assert.Equal("app", (string)parsed!["name"]!);
        Assert.Equal(3, (int)parsed["count"]!);
        Assert.True((bool)parsed["enabled"]!);
        Assert.Equal(0.75m, (decimal)parsed["ratio"]!);
    }

    [Fact(DisplayName = "Parse large number")]
    public void ParseLargeNumber()
    {
        var parsed = TfVarsContent.Parse("big = 999999999");
        Assert.Equal(999999999, (int)parsed!["big"]!);
    }

    [Fact(DisplayName = "NumberNode roundtrip serialization")]
    public void NumberRoundtrip()
    {
        const string input = "count = 42\n";
        var parsed = TfVarsContent.Parse(input);
        var serialized = TfVarsContent.Serialize(parsed);
        TestUtils.CompareLines(input, serialized);
    }

    [Fact(DisplayName = "BoolNode roundtrip serialization")]
    public void BoolRoundtrip()
    {
        const string input = "flag = true\n";
        var parsed = TfVarsContent.Parse(input);
        var serialized = TfVarsContent.Serialize(parsed);
        TestUtils.CompareLines(input, serialized);
    }
}
