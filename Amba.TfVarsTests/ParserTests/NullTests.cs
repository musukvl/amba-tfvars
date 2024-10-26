using Amba.TfVars;

namespace Amba.TfVarsTests.ParserTests;

public class NullTests
{
    [Fact]
    public void CheckNullVariable()
    {
        const string varfile = "email = null";

        var parsed = TfVarsContent.Parse(varfile);
        Assert.Null(parsed?["email"]);
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
        Assert.Null(varfile["user"]?["email"]);
    }
}