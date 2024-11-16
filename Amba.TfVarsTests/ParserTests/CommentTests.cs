﻿using Amba.TfVars;
using Amba.TfVars.Model;

namespace Amba.TfVarsTests.ParserTests;

public class CommentsTests
{

    [Fact]
    public void TestMapCommentBefore()
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
    public void CheckMapTwoKeysComments()
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

    [Fact]
    public void TestVariableComment()
    {
        const string input = """
                             # variable comment
                             variable = "value" # value comment
                             """;
        var varfile = TfVarsContent.Parse(input);
        var variable = (VariableDefinitionNode)varfile.Children("variable")!;
        Assert.Single(variable.CommentsBefore);
        Assert.Single(variable.CommentsAfter);

    }
    
    [Fact]
    public void TestVariableComments()
    {
        const string input = """
                             # variable comment
                             variable = "value" # value comment
                             x = "test"
                             """;
        var varfile = TfVarsContent.Parse(input);
        var variable = varfile.Children("variable")!;
        Assert.Single(variable.CommentsBefore);
        Assert.Single(variable.CommentsAfter);
        
        var x = varfile.Children("x")!;
        Assert.Empty(x.CommentsBefore);
        Assert.Empty(x.CommentsAfter);
    }
    
    [Fact]
    public void TestVariableAndMultilineComments()
    {
        const string input = """
                             /* variable comment */
                             variable = "value" /* value comment */
                             x = "test" # value comment
                             """;
        var varfile = TfVarsContent.Parse(input);
        var variable = varfile.Children("variable")!;
        Assert.Single(variable.CommentsBefore);
        Assert.Single(variable.CommentsAfter);
        
        var x = varfile.Children("x")!;
        Assert.Empty(x.CommentsBefore);
        Assert.Single(x.CommentsAfter);
    }
}