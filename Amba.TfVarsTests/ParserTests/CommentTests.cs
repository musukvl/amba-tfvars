using Amba.TfVars;
using Amba.TfVars.Model;

namespace Amba.TfVarsTests.ParserTests;

public class CommentsTests
{

    [Fact]
    public void TestCommentBefore()
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
        var phone = user.Children("phone");
        Assert.NotNull(phone as MapPairNode);
        Assert.Equal(2, phone.CommentsBefore.Length);
        Assert.Single(phone.CommentsAfter);
    }

    [Fact]
    public void CheckNullMapProperty()
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
        var key = map.Children("key1");
        Assert.Single(key.CommentsBefore);
        Assert.Single(key.CommentsAfter);
    }
}