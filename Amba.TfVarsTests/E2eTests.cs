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
    
    private void CompareLines(string? expected, string? actual)
    {
        var expectedLines = expected.Split(Environment.NewLine);
        var actualLines = actual.Split(Environment.NewLine);
        for (var i = 0; i < expectedLines.Length; i++)
        {
            Assert.Equal(expectedLines[i].Trim(), actualLines[i].Trim());
        }
    }
}