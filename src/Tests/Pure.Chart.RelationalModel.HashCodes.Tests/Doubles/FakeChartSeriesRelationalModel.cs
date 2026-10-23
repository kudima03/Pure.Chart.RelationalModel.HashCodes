using Pure.Chart.RelationalModel.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;

namespace Pure.Chart.RelationalModel.HashCodes.Tests.Doubles;

internal sealed record FakeChartSeriesRelationalModel(
    IGuid Id,
    IGuid ChartId,
    IString Legend,
    IString XAxisSource,
    IString YAxisSource,
    IString LineType
) : IChartSeriesRelationalModel;
