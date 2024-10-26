using System.Net.Security;
using Amba.TfVars;
using Amba.TfVars.Model.Extensions;

public class NullTests
{
    [Fact]
    public void CheckNullVariable()
    {
        var varfile = """
                      email = null
                              
                      """;

        var parsed = TfVarsContent.Parse(varfile);
        Assert.Null(parsed?["email"]);
    }

    [Fact]
    public void CheckNullMapProperty()
    {
        var input = """
                    
                             user = {
                                email = null 
                            }
                            
                    """;

        var varfile = TfVarsContent.Parse(input);
        Assert.NotNull(varfile);
        Assert.Null(varfile["user"]?["email"]);
    }
}