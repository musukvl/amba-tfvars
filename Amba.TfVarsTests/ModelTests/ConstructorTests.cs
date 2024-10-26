using Amba.TfVars;
using Amba.TfVars.Model;

namespace Amba.TfVarsTests.ConstructorTests;

public class ConstructorTests
{
    [Fact]
    public void CheckFileRoot()
    {
        var varfile = new TfVarsRoot(
            new Dictionary<string, TfVarsNode>
            {
                { "email", new StringNode("x@x.com") }
            }
        );

        var serialized = TfVarsContent.Serialize(varfile);

        TestUtils.CompareLines("email = \"x@x.com\"", serialized);
    }

    [Fact]
    public void CheckAllTypes()
    {
        var varfile = new TfVarsRoot(
            new Dictionary<string, TfVarsNode>
            {
                {
                    "users", new ListNode(
                        new MapNode(new Dictionary<string, TfVarsNode>
                        {
                            { "name", new StringNode("Vasya") }
                        })
                    )
                }
            }
        );
        var serialized = TfVarsContent.Serialize(varfile);
        const string expected = """
                                users = [
                                    {
                                        name = "Vasya"
                                    },
                                ]
                                """;
        TestUtils.CompareLines(expected, serialized);
    }
}