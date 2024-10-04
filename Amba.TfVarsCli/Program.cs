// See https://aka.ms/new-console-template for more information

using Amba.TfVars;
using Antlr4.Runtime;

var input = File.ReadAllText("input.tfvars");

var inputStream = new AntlrInputStream(input);
var lexer = new TfVarsLexer(inputStream);
var tokenStream = new CommonTokenStream(lexer);
var parser = new TfVarsParser(tokenStream);

var tree = parser.file_();
var visitor = new ExtendedVisitor(tokenStream);
var result = visitor.Visit(tree);

var tfVarsStr = TfVarsContent.Serialize(result);
Console.WriteLine(tfVarsStr);
