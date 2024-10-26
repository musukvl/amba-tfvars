using System.Net.Security;
using Amba.TfVars;
using Amba.TfVars.Model.Extensions;

public class ValueTests
{

    [Fact]
    public void CheckString()
    {
        var varfile = @"
        email = ""x@x.com""
        ";

        var parsed = TfVarsContent.Parse(varfile);
        Assert.Equal("x@x.com", (string)parsed["email"]);
    }



}