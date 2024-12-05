using Amba.TfVars;
using Amba.TfVars.Extensions;

namespace Amba.TfVarsTests.ParserTests;

public class NullTests
{
    [Fact]
    public void CheckStringVariable()
    {
        const string varfile = @"email = ""x@x.com""";

        var parsed = TfVarsContent.Parse(varfile);
        var value = parsed?["email"];
        Assert.Equal("x@x.com", value.AsString());
    }

    [Fact]
    public void CheckNullVariable()
    {
        const string varfile = "email = null";

        var parsed = TfVarsContent.Parse(varfile);
        var value = parsed?["email"].AsString();
        Assert.Null(value);
    }

    [Fact]
    public void CheckNullMapProperty()
    {
        const string input = """
                             user = {
                                 email = null 
                             }
                             """;

        var varfile = TfVarsContent.Parse(input);
        Assert.NotNull(varfile);
        Assert.Null(varfile["user"]?["email"].AsString());
    }
}