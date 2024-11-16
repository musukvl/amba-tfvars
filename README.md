﻿# Terraform TfVars files parser and serializer for DotNet C#


This is a simple parser and serializer for Terraform `.tfvars` files into a tree of nodes.
The main purpose is to provide a way to process and transform `.tfvars` files.
It is written in C# and it is based on the  [ANTLR4](https://www.antlr.org/) library.

## Usage

### Parsing

```csharp
var tfvarsNodes = TfVarsContent.Deserialize("key = value");
```

### Serializing

```csharp
var tfvarsString = TfVarsContent.Serialize(tfvarsNodes);
```

### Tree navigation

```csharp
const string varfile = """
                           users = [                                
                               {
                                   name = "Jane"
                                   email = "jane@x.com"
                                   meta = {
                                       age = 25
                                   }
                               }
                            ]
                       """;
var parsed = TfVarsContent.Parse(varfile);
Assert.Equal(25, (int)parsed["users"][0]["meta"]["age"]);

```

## Known limitations

- The parser doesn't do any validation on the content of the tfvars file.
- The serializer does code format which is not the same as `terraform fmt` does.
- The parser doesn't support multiline strings done with <<EOF syntax.


# Release notes

| Version | Description                                                                                        |
|---------|----------------------------------------------------------------------------------------------------|
| 1.3.0   | Support comments in for maps and variables.                                                        |
| 1.2.0   | MapNode ordering extension. Can be used to use order for all objects.                              |
| 1.1.2   | Add constructors for constructing tfvars configuration in c# code                                  |
| 1.1.0   | Base class has index operator for all nodes of parsed tree. The same as JToken in Newtonsoft.Json. |
| 1.0.0   | Initial version                                                                                    |

# License

Do whatever you want with this code. It is provided as is without any warranty.
