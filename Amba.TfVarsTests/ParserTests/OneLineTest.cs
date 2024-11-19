using Amba.TfVars;
using Amba.TfVars.Extensions;
using Amba.TfVars.Model;

namespace Amba.TfVarsTests.ParserTests;

public class OneLineTest
{

    [Fact(DisplayName = "Variable with one line map")]
    public void TestVariableWithOneLineMap()
    {
        const string input = $@"""
                             address = {{ street = ""123 Main St."", city = ""Springfield"" }}
                             """;
        var root = TfVarsContent.Parse(input);
        var addressMap = root.Child("address").Value.AsMap();
        Assert.NotNull(addressMap);
        Assert.True(addressMap.OneLine);
    }


    [Fact(DisplayName = "Map inside of map")]
    public void TestOneLineMapInsideOfMap()
    {
        const string input = $@"""
                             user = {{
                                address = {{ street = ""123 Main St."", city = ""Springfield"" }}
                             }}        
                             """;
        var root = TfVarsContent.Parse(input);
        var userMap = root.Child("user").Value.AsMap();
        Assert.NotNull(userMap);
        Assert.False(userMap.OneLine);
        Assert.True(userMap.Child("address").Value.AsMap().OneLine);

        Assert.NotNull(root);
    }

    [Fact(DisplayName = "Variable with list of one line map and multiple lines map")]
    public void TestVariableWithListOfOneLineMapAndMultipleLinesMap()
    {
        const string input = $@"""
                             users = [
                                {{ address = {{ street = ""123 Main St."", city = ""Springfield"" }} }},
                                {{ address = {{ 
                                    street = ""456 Main St."", 
                                    city = ""Springfield"" 
                                }} }}
                             ]
                             """;
        var root = TfVarsContent.Parse(input);
        var usersList = root.Child("users").Value.AsList();
        Assert.NotNull(usersList);
        Assert.Equal(2, usersList.Children().Count());
        Assert.True(usersList.ChildAt(0).AsMap().OneLine);
        Assert.False(usersList.ChildAt(1).AsMap().OneLine);
    }

    [Fact(DisplayName = "Variable with oneline list")]
    public void TestVariableWithOneLineList()
    {
        const string input = $@"""
                             users = [""John Doe"", ""Jane Doe""]
                             """;
        var root = TfVarsContent.Parse(input);
        var usersList = root.Child("users").Value.AsList();
        Assert.NotNull(usersList);
        Assert.True(usersList.OneLine);
    }

    [Fact(DisplayName = "Variable with multiline list")]
    public void TestVariableWithMultilineList()
    {
        const string input = $@"""
                             users = [
                                1,
                                2.2
                             ]
                             """;
        var root = TfVarsContent.Parse(input);
        var usersList = root.Child("users").Value.AsList();
        Assert.NotNull(usersList);
        Assert.False(usersList.OneLine);
    }

}