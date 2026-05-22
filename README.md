# Pure.Chart.RelationalModel.HashCodes

Deterministic hash code implementations for chart relational model entities — Chart, ChartType, Axis, and ChartSeries — in the **Pure** ecosystem.

[![.NET build & test](https://github.com/kudima03/Pure.Chart.RelationalModel.HashCodes/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Chart.RelationalModel.HashCodes/actions/workflows/build-and-test.yml)
[![Build and Deploy](https://github.com/kudima03/Pure.Chart.RelationalModel.HashCodes/actions/workflows/publish-nuget.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Chart.RelationalModel.HashCodes/actions/workflows/publish-nuget.yml)
[![NuGet](https://img.shields.io/nuget/v/Pure.Chart.RelationalModel.HashCodes)](https://www.nuget.org/packages/Pure.Chart.RelationalModel.HashCodes)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

## Overview

`Pure.Chart.RelationalModel.HashCodes` provides four sealed record types, each producing a deterministic byte-sequence hash for a chart domain entity. Every type implements `IDeterminedHash` and prepends a unique 16-byte type prefix before concatenating field hashes, ensuring no collisions across entity types.

Each field can independently be supplied either as a raw primitive (`IGuid` / `IString`) or a pre-computed `IDeterminedHash`, enabling partial hash reuse through functional composition.

## Hash Types

| Type | Hashed Fields |
|------|--------------|
| `ChartRelationalModelHash` | Id, Title, Description, TypeId, XAxisId, YAxisId |
| `ChartTypeRelationalModelHash` | Id, Name |
| `AxisRelationalModelHash` | Id, Legend |
| `ChartSeriesRelationalModelHash` | Id, ChartId, Legend, XAxisSource, YAxisSource |

All types are in the `Pure.Chart.RelationalModel.HashCodes` namespace.

## Design Principles

- **Deterministic** — identical inputs always produce identical byte sequences.
- **Type-safe** — each entity type carries a hard-coded 16-byte prefix, preventing cross-type hash collisions.
- **Composable** — any field can be replaced with a pre-computed `IDeterminedHash` without recomputing the others.
- **AOT-compatible** — safe for Native AOT publishing.

## Dependencies

- [`Pure.Chart.RelationalModel.Abstractions`](https://github.com/kudima03/Pure.Chart.RelationalModel.Abstractions/tree/0.1.0-preview.6.0.0) — interfaces for chart relational model entities (`IChartRelationalModel`, `IChartTypeRelationalModel`, `IAxisRelationalModel`, `IChartSeriesRelationalModel`)
- [`Pure.HashCodes`](https://github.com/kudima03/Pure.HashCodes/tree/2.1.0) — core `DeterminedHash` implementation that wraps `IGuid` / `IString` primitives into enumerable byte sequences

## Target Frameworks

- .NET 7
- .NET 8
- .NET 9
- .NET 10

## Installation

```bash
dotnet add package Pure.Chart.RelationalModel.HashCodes
```

## Usage

```csharp
// Hash an entire model in one call
IDeterminedHash hash = new ChartRelationalModelHash(chart);

// Or mix raw values with pre-computed hashes
IDeterminedHash hash = new ChartRelationalModelHash(
    idHash: precomputedIdHash,
    chart.Title,
    chart.Description,
    chart.TypeId,
    chart.XAxisId,
    chart.YAxisId
);

// Consume the byte sequence
byte[] bytes = hash.ToArray();
```
