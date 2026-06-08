# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Commands

All `dotnet` commands must be run from the `./src` directory.

```bash
dotnet restore
dotnet build --no-restore -warnaserror
dotnet format --verify-no-changes             # check code style (CI enforces this)
dotnet format                                  # auto-fix code style
dotnet test --no-build --verbosity normal --logger trx --collect:"XPlat Code Coverage"
dotnet pack --configuration Release -p:PackageVersion=<version> --output .
```

CI runs mutation testing with Stryker at a 99 % break threshold — run `dotnet stryker --mutation-level Complete --break-at 99` locally if you change implementation logic.

## Architecture

This is an **implementation library** — four `sealed record` types, no interfaces defined here. All four implement `IDeterminedHash` from `Pure.HashCodes.Abstractions`, producing an enumerable byte sequence that uniquely identifies a chart entity.

**Types and their hashed fields:**
- `ChartRelationalModelHash` — Id, Title, Description, TypeId, XAxisId, YAxisId
- `ChartTypeRelationalModelHash` — Id, Name
- `AxisRelationalModelHash` — Id, Legend
- `ChartSeriesRelationalModelHash` — Id, ChartId, Legend, XAxisSource, YAxisSource

**Hashing pattern:** Each type holds a hard-coded 16-byte `TypePrefix` (a static readonly field) that is prepended to the concatenated field hashes before the final `DeterminedHash` is produced. This guarantees no cross-type hash collisions.

**Composable overloads:** Every field can independently be supplied as either a raw primitive (`IGuid` / `IString`) or a pre-computed `IDeterminedHash`. The constructors form an exhaustive combinatorial overload set; the innermost constructor (all `IDeterminedHash` arguments) is the canonical one — all others delegate into it via `new DeterminedHash(rawValue)`.

**Dependencies:**
- `Pure.Chart.RelationalModel.Abstractions` — entity interfaces consumed by the convenience `(IChartRelationalModel model)` constructors.
- `Pure.HashCodes` — provides `DeterminedHash`, which wraps `IGuid` / `IString` primitives and is used to produce the final hash from the concatenated byte sequence.

**Multi-targeting:** net7.0, net8.0, net9.0, net10.0. All types must remain AOT-compatible (`IsAotCompatible = true`).

**Package validation:** `EnablePackageValidation = true` with `PackageValidationBaselineVersion = 0.1.0-preview.2.0.0`. Breaking API changes fail the build.

**Publishing:** triggered by pushing a semver tag (matching `*.*.*`). The tag value becomes the `PackageVersion`.

## Code Style

Enforced via `.editorconfig` and `dotnet format --verify-no-changes` in CI:

- No `var` — always use explicit types.
- No expression-bodied methods, constructors, or operators; expression-bodied properties, indexers, accessors, and lambdas are required.
- `using` directives outside the namespace declaration.
- Private fields: `_camelCase` prefix (underscore + camelCase).
- Maximum line length: 90 characters.
- All warnings are treated as errors in CI (`-warnaserror`).

## Commit Messages

Do not mention Claude or AI assistance in commit messages.
