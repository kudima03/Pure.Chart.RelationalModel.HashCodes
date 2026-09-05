# Changelog

All notable changes to Pure.Chart.RelationalModel.HashCodes are documented here.

Format follows [Keep a Changelog](https://keepachangelog.com/en/1.1.0/).

---

## [0.1.0-preview.2.0.0] — 2026-04-26

### Changed

- **`AxisRelationalModelHash`** no longer hashes a `chartId`. Its constructors
  are reduced to `(id, legend)` and the matching raw-primitive /
  pre-computed-hash overload combinations; the previous `chartId` /
  `chartIdHash` parameters have been removed from every overload.

## [0.1.0-preview.1.0.0] — 2026-04-19

### Changed

- **`SeriesRelationalModelHash`** renamed to **`ChartSeriesRelationalModelHash`**.
- Its model-based convenience constructor now takes
  `IChartSeriesRelationalModel` instead of `ISeriesRelationalModel`.

## [0.1.0-preview.0.2.0] — 2026-04-04

### Added

- Composable constructor overloads for `AxisRelationalModelHash`,
  `ChartRelationalModelHash`, `ChartTypeRelationalModelHash`, and
  `SeriesRelationalModelHash`: every hashed field can now independently be
  supplied as either a raw primitive (`IGuid` / `IString`) or a
  pre-computed `IDeterminedHash`, covering the full combinatorial set of
  overloads for each type.

## [0.1.0-preview.0.1.0] — 2026-03-23

### Added

- Initial release. Four `sealed record` types implementing `IDeterminedHash`
  from `Pure.HashCodes.Abstractions`, each producing a type-prefixed byte
  sequence that uniquely identifies a chart entity:
  - **`ChartRelationalModelHash`** — hashes Id, Title, Description, TypeId,
    XAxisId, YAxisId.
  - **`ChartTypeRelationalModelHash`** — hashes Id, Name.
  - **`AxisRelationalModelHash`** — hashes Id, ChartId, Legend.
  - **`SeriesRelationalModelHash`** — hashes Id, ChartId, Legend,
    XAxisSource, YAxisSource.
- Each type includes a convenience constructor accepting the matching
  `Pure.Chart.RelationalModel.Abstractions` entity interface (e.g.
  `IAxisRelationalModel`), alongside constructors taking raw primitives
  directly.
