# AGENTS.md

## Repository purpose
This repository contains a .NET parser/serializer for Terraform `.tfvars` files, plus a CLI and test suite.

## Solution structure
- `Amba.TfVars.slnx`  
  Main solution file (modern solution format).

- `Amba.TfVars/`  
  Core library package.
  - `TfVars.g4`: ANTLR grammar for tfvars parsing.
  - `Generated/`: generated ANTLR lexer/parser/visitor files.
  - `Model/`: AST/node model types (`MapNode`, `ListNode`, `VariableDefinitionNode`, etc.).
  - `Extensions/`: helper methods for tree navigation/modification.
  - `Serializer/`: tfvars serialization logic and options.
  - `ExtendedVisitor*.cs`: parse-tree visitor implementation that builds model nodes.

- `Amba.TfVarsCli/`  
  Console app that references the core library for manual/local usage.

- `Amba.TfVarsTests/`  
  xUnit test project (unit + e2e coverage).
  - `examples/`: tfvars fixtures used by e2e tests.

## Project-specific notes
- Target framework is `.NET 10` (`net10.0`) for all projects.
- Root `.editorconfig` sets analyzer severity to error for C# code; keep builds warning-free.
- Do not manually edit files in `Amba.TfVars/Generated/`; regenerate when grammar changes.
- Keep behavior changes covered by tests in `Amba.TfVarsTests`.

## Common commands
```bash
dotnet restore Amba.TfVars.slnx
dotnet build Amba.TfVars.slnx
dotnet test Amba.TfVars.slnx
```

## Packaging
- Core NuGet package is produced from `Amba.TfVars/Amba.TfVars.csproj` (`GeneratePackageOnBuild=true`).
