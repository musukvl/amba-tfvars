using Amba.TfVars;

namespace Amba.TfVarsTests.ParserTests;

public class ValueTests
{

    [Fact]
    public void CheckString()
    {
        const string varfile = """
                               email = "x@x.com"
                               """;

        var parsed = TfVarsContent.Parse(varfile);
        Assert.Equal("x@x.com", (string)parsed["email"]);
    }
}