using Amba.TfVars;
using Amba.TfVars.Extensions;
using Amba.TfVars.Model;

namespace Amba.TfVarsTests.ModelTests;

public class TreeCreationTests
{
   

    [Fact(DisplayName = "Create tfvars from scratch.")]
    public void CheckTreeCreation()
    {
        var root = new TfVarsRoot();
        root["users"] = new MapNode()
            .Property("john", new MapNode()
                .Property("name", "John")
                .Property("email", "john@email.com")
                )
            .ParagraphProperty("jane", new MapNode()
                .Property("name", "Jane")
                .Property("email", "jane@email.com")
                .Property("tags", new ListNode("1", "2", "3").SetOneLine(true))
            );
        var serialized = TfVarsContent.Serialize(root);
        var expected = """
                       users = {
                            john = {
                                 name  = "John"
                                 email = "john@email.com"
                            }
                            
                            jane = {
                                 name  = "Jane"
                                 email = "jane@email.com"
                                 tags  = ["1", "2", "3"]
                            }
                       }
                       """;
        TestUtils.CompareLines(expected, serialized);
    }
 
}