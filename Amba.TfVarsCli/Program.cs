
using Amba.TfVars;
using Amba.TfVars.Model;
using Antlr4.Runtime;

var input = File.ReadAllText("input.tfvars");

var result = TfVarsContent.Parse(input);

var tfVarsStr = TfVarsContent.Serialize(result);
Console.WriteLine(tfVarsStr);
