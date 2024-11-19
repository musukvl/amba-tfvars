using Amba.TfVars;
using Amba.TfVars.Extensions;
using Amba.TfVars.Model;

namespace Amba.TfVarsTests.Extensions;

public class MapNodeExtensionsTests
{
    [Fact(DisplayName = "MapNode ReorderKeys test")]
    public void MapNodeReorderKeysTest()
    {
        var input = """
                    vms = {
                        "dev_vm" = {
                            "dc" = "west"
                            description = "This is a dev VM"
                            "owner" = "Jane Doe"
                            "ip" = "192.168.1.12"
                            "labels" = ["dev", "west"]
                        }
                        "test-vm" = {
                            oncall_email = "oncall@gmail.com"
                            "ip" = "192.168.1.10"
                            "dc" = "east"
                            "owner" = "John Doe"
                        }
                        "prod_vm" = {
                            description = "This is a prod VM"
                            oncall_email = "oncall@gmail.com"
                            "owner" = "Jane Doe"
                            "dc" = "west"
                            "ip" = "192.168.1.11"
                        }
                    }
                    """;
        var tree = TfVarsContent.Parse(input);

        foreach (var tfVarsNode in tree["vms"])
        {
            var node = (MapPairNode)tfVarsNode;
            ((MapNode)node.Value!).ReorderKeys("ip", "description", "dc");
        }

        var serialized = TfVarsContent.Serialize(tree);
        var expected = """
                       vms = {
                           "dev_vm" = {
                               "ip" = "192.168.1.12"
                               description = "This is a dev VM"
                               "dc" = "west"
                               "owner" = "Jane Doe"
                               "labels" = ["dev", "west"]
                           }
                           "test-vm" = {
                               "ip" = "192.168.1.10"
                               "dc" = "east"
                               oncall_email = "oncall@gmail.com"
                               "owner" = "John Doe"
                           }
                           "prod_vm" = {
                               "ip" = "192.168.1.11"
                               description = "This is a prod VM"
                               "dc" = "west"
                               oncall_email = "oncall@gmail.com"
                               "owner" = "Jane Doe"
                           }
                       }
                       """;
        TestUtils.CompareLines(expected, serialized);
    }


}