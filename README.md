# TfVars files parser and serializer

This is a simple parser and serializer for Terraform tfvars files into a tree of nodes.
The main purpose is to provide a way to process and transform tfvars files.
It is written in C# and it is based on the `ANTLR4` library.

## Usage

### Parsing

```csharp
var tfvarsNodes = TfVarsContent.Deserialize("key = value");
```

### Serializing

```csharp
var tfvarsString = TfVarsContent.Serialize(tfvarsNodes, indentSize: 4);
```

## Known limitations

- The parser doesn't support comments.
- The parser doesn't do any validation on the content of the tfvars file.
- The serializer does formatting which is not the same as `terraform fmt` does.


# Release notes

| Version | Description     |
| ------- |-----------------|
| 1.0.0   | Initial version |

# License

Do whatever you want with this code. It is provided as is without any warranty.
