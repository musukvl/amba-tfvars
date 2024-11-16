using Amba.TfVars;
using Amba.TfVars.Extensions;
using Amba.TfVars.Model;

namespace Amba.TfVarsTests.ParserTests;

public class CommentsTests
{

    [Fact]
    public void TestMapCommentBefore()
    {
        const string input = """
                             user = {
                                 # phone number
                                 # should be not empty
                                 phone = "123456789" # John's phone number
                             }
                             """;
        var root = TfVarsContent.Parse(input);
        var user = (MapNode)root["user"]!;
        var phone = user.Child("phone");
        Assert.NotNull(phone as MapPairNode);
        Assert.Equal(2, phone.CommentsBefore.Length);

    }

    [Fact]
    public void CheckMapTwoKeysComments()
    {
        const string input = """
                             map = {
                               # key1 comment
                               "key1" = "value1", # value1 comment
                               key2 = "value2"                              
                             }
                             """;

        var varfile = TfVarsContent.Parse(input);
        var map = (MapNode)varfile["map"]!;
        var key = map.Child("key1");
        Assert.Single(key.CommentsBefore);
    }

    [Fact]
    public void TestVariableComment()
    {
        const string input = """
                             # variable comment
                             variable = "value" # value comment
                             """;
        var varfile = TfVarsContent.Parse(input);
        var variable = varfile.Child("variable")!;
        Assert.Single(variable.CommentsBefore);

    }

    [Fact]
    public void TestVariableComments()
    {
        const string input = """
                             # variable comment
                             variable = "value" # value comment
                             x = "test"
                             """;
        var varfile = TfVarsContent.Parse(input);
        var variable = varfile.Child("variable")!;
        Assert.Single(variable.CommentsBefore);
        Assert.NotNull(variable.Value.AsValue().CommentAfter);
        var x = varfile.Child("x")!;
        Assert.Empty(x.CommentsBefore);
    }

    [Fact]
    public void TestVariableAndMultilineComments()
    {
        const string input = """
                             /* variable comment */
                             variable = "value" /* value comment */
                             x = "test" # value comment
                             """;
        var varfile = TfVarsContent.Parse(input);
        var variable = varfile.Child("variable")!;
        Assert.Single(variable.CommentsBefore);

        var x = varfile.Child("x")!;
        Assert.Empty(x.CommentsBefore);
    }
}