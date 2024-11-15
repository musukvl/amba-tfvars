using Amba.TfVars;

namespace Amba.TfVarsTests.ParserTests;

public class CommentsTests
{
    [Fact]
    public void CheckNullMapProperty()
    {
        const string input = """
                             user = {
                                 # single line comment before email
                                 email = "xx@gmail.com" # John's email
                                 # phone number
                                 # should be not empty
                                 phone = "123456789" # John's phone number
                             }
                             """;

        var varfile = TfVarsContent.Parse(input);
        Assert.NotNull(varfile);
    }
}