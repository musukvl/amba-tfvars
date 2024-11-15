using Amba.TfVars;

namespace Amba.TfVarsTests;

public class E2ETests
{
    [Theory]
    [InlineData("all_features.tfvars", "all_features.expected.tfvars")]
    public void CheckExamples(string inputFile, string expectedFile)
    {
        var input = File.ReadAllText("./examples/" + inputFile);
        var expected = File.ReadAllText("./examples/" + expectedFile).Trim();
        var tree = TfVarsContent.Parse(input);

        var tfVarsStr = TfVarsContent.Serialize(tree, identSize: 4).Trim();
        TestUtils.CompareLines(expected, tfVarsStr);
    }

    [Theory]
    [InlineData("microservices.tfvars", "microservices.expected.tfvars")]
    public void TransformMicroservicesConfig(string inputFile, string expectedFile)
    {
        var input = File.ReadAllText("./examples/" + inputFile);
        var expected = File.ReadAllText("./examples/" + expectedFile).Trim();
        var root = TfVarsContent.Parse(input);

        var tfVarsStr = TfVarsContent.Serialize(root, identSize: 4).Trim();
        TestUtils.CompareLines(expected, tfVarsStr);
    }

}