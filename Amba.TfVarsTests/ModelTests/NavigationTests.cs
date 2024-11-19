using Amba.TfVars;
using Amba.TfVars.Extensions;
using Amba.TfVars.Model;

namespace Amba.TfVarsTests.ModelTests;

public class NavigationTests
{
    const string Varfile = """
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

    [Fact(DisplayName = "Navigation by value structure. Acts as tree of dictionaries and lists.")]
    public void CheckNavigation()
    {

        var parsed = TfVarsContent.Parse(Varfile);
        Assert.Equal(25, (int)parsed["users"][1]["meta"]["age"]);
    }

    [Fact(DisplayName = "Navigation by Node structure. Acts as tree of nodes.")]
    public void CheckNavigationByNode()
    {
        var root = TfVarsContent.Parse(Varfile);
        var age = root
            .Child("users").Value
            .AsList().ChildAt(1)
            .AsMap().Child("meta").Value
            .AsMap().Child("age").Value
            .AsNumber().Value;
        Assert.Equal(25, age);
    }
}