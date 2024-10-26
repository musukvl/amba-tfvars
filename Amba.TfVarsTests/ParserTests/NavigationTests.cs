using Amba.TfVars;

namespace Amba.TfVarsTests.ParserTests;

public class NavigationTests
{
    [Fact]
    public void CheckNavigation()
    {
        const string varfile = """
                               users = [ 
                                   {
                                       name = "John"
                                       email = "x@x.com"
                                       meta = {
                                           age = 30
                                       }                    
                                   },
                                   {
                                       name = "Jane"
                                       email = "jane@x.com"
                                       meta = {
                                           age = 25
                                       }
                                   }
                                ]
                               """;
        var parsed = TfVarsContent.Parse(varfile);
        Assert.Equal(25, (int)parsed["users"][1]["meta"]["age"]);
    }
}