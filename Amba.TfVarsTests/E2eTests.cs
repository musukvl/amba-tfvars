using System.Text.RegularExpressions;
using Amba.TfVars;

namespace Amba.TfVarsTests;

public class E2eTests
{
    [Theory]
    [InlineData("all_features.tfvars", "all_features.expected.tfvars")]
    public void CheckExamples(string inputFile, string expectedFile)
    {
        var input = File.ReadAllText("./examples/" + inputFile);
        var expected = File.ReadAllText("./examples/" + expectedFile).Trim();
        var tree = TfVarsContent.Parse(input);
        
        var tfVarsStr = TfVarsContent.Serialize(tree, identSize:4).Trim();
        CompareLines(expected, tfVarsStr);
    }
    
    
    
    [Theory]
    [InlineData("microservices.tfvars", "microservices.expected.tfvars")]
    public void TransformMicroservicesConfig(string inputFile, string expectedFile)
    {
        var input = File.ReadAllText("./examples/" + inputFile);
        var expected = File.ReadAllText("./examples/" + expectedFile).Trim();
        var tree = TfVarsContent.Parse(input);
        var tfVarsStr = TfVarsContent.Serialize(tree, identSize:4).Trim();
        
        CompareLines(expected, tfVarsStr);
    }
    
    private void CompareLines(string expected, string actual)
    {
        var eolRegex = new Regex("\r\n|\r|\n", RegexOptions.Compiled);
        var expectedLines = eolRegex.Split(expected);
        var actualLines = eolRegex.Split(actual);
        for (var i = 0; i < expectedLines.Length; i++)
        {
            Assert.Equal(expectedLines[i].Trim(), actualLines[i].Trim());
        }
    }
}