using Amba.TfVars;
using Amba.TfVars.Extensions;
using Amba.TfVars.Model;

namespace Amba.TfVarsTests.Extensions;

public class ListExtensionsTests
{
    
    static string Input = """
                vms = [
                    {
                        name = "dev_vm"
                        "dc" = "west"
                        memory_gb = 4
                        description = "This is a dev VM"
                        "owner" = "Jane Doe"
                        "ip" = "192.168.1.12"
                        "labels" = ["dev", "west"]
                    },
                    {
                        name = "test-vm"
                        memory_gb = 8
                        oncall_email = "oncall@gmail.com"
                        "ip" = "192.168.1.10"
                        "dc" = "east"
                        "owner" = "John Doe"
                    },
                    {
                        name = "prod_vm"
                        memory_gb = 2
                        description = "This is a prod VM"
                        oncall_email = "oncall@gmail.com"
                        "owner" = "Jane Doe"
                        "dc" = "west"
                        "ip" = "192.168.1.11"
                    }
                ]
                """;
    
    [Fact(DisplayName = "Access list element by index")]
    public void AccessListElement()
    {
        var tree = TfVarsContent.Parse(Input);
        var ip = tree["vms"][1]["ip"].ToString();
        Assert.Equal("192.168.1.10", ip);
    }
    
}