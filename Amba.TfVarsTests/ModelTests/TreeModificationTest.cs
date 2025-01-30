using Amba.TfVars;
using Amba.TfVars.Extensions;
using Amba.TfVars.Model;

namespace Amba.TfVarsTests.ModelTests;

public class TreeModificationTests
{
    const string Varfile = """
                           users = { 
                               "john" = {
                                   name = "John"
                                   email = "x@x.com"
                                   meta = {
                                       age = 30
                                   }                    
                               },
                               "jane" = {
                                   name = "Jane"
                                   email = "jane@x.com"
                                   meta = {
                                       age = 25
                                   }
                               }
                            }
                           """;

    [Fact(DisplayName = "Move Users to separate collection.")]
    public void CheckTreeTransformation()
    {
        var parsed = TfVarsContent.Parse(Varfile);
        
        var users = parsed["users"].AsMapNode();
        var youngUsers = new MapNode();
        var oldUsers = new MapNode();
        foreach (var userPair in users.Pairs)
        {
            if (userPair.Value["meta"]["age"].AsNumberNode().Value < 30)
            {
                youngUsers.Add(userPair.Key, userPair.Value);
            }
            else
            {
                oldUsers.Add(userPair.Key, userPair.Value);
            }
        }
        var keys = users.Pairs.Select(x => x.Key).ToList();
        foreach (var key in keys)
        {
            users.Remove(key);
        }
        
        users.Add("young", youngUsers);
        users.Add("old", oldUsers);

        var serialized = TfVarsContent.Serialize(parsed);
        var expected = """
                       users = {
                           young = {
                               jane = {
                                   name = "Jane"
                                   email = "jane@x.com"
                                   meta = {
                                       age = 25
                                   }
                               }
                           }
                           old = {
                               john = {
                                   name = "John"
                                   email = "x@x.com"
                                   meta = {
                                       age = 30
                                   }
                               }
                           }
                       }
                       """;
        TestUtils.CompareLines(expected, serialized);
    }
 
}