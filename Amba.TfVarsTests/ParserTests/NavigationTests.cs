using System.Net.Security;
using Amba.TfVars;
using Amba.TfVars.Model.Extensions;

public class NavigationTests
{

    [Fact]
    public void CheckString()
    {
        var varfile = @"
        users = [ 
            {
                name = ""John""
                email = ""x@x.com""
                meta = {
                    age = 30
                }                    
            },
            {
                name = ""Jane""
                email = ""jane@x.com""
                meta = {
                    age = 25
                }
            }
         ]
        ";

        var parsed = TfVarsContent.Parse(varfile);
        Assert.Equal(25, (int)parsed["users"][1]["meta"]["age"]);
    }
}