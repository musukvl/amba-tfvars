using Amba.TfVars;

namespace Amba.TfVarsTests.ModelTests;

public class IterationTests
{
    [Fact]
    public void CheckIteration()
    {
        const string varfile = """
                                  users = [ 
                                      {
                                          name = "John"
                                          email = "john@x.com"
                                       },
                                       {
                                           name = "Jane"
                                           email = "jane@x.com" 
                                       }
                                   ]   
                               """;
        var parsed = TfVarsContent.Parse(varfile);
        var usersCount = 0;
 
        foreach (var user in parsed["users"])
        {
            usersCount++;
        }
        Assert.Equal(2, usersCount);
    }
}