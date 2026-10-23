using System.Collections;
using Pure.Chart.RelationalModel.Abstractions;
using Pure.Chart.RelationalModel.HashCodes.Tests.Doubles;
using Pure.HashCodes;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;
using Pure.Primitives.Random.String;
using Guid = Pure.Primitives.Guid.Guid;
using String = Pure.Primitives.String.String;

namespace Pure.Chart.RelationalModel.HashCodes.Tests;

public sealed record ChartSeriesRelationalModelHashTests
{
    private readonly byte[] _typePrefix =
    [
        243,
        25,
        157,
        1,
        93,
        28,
        13,
        115,
        186,
        164,
        140,
        177,
        255,
        182,
        231,
        87,
    ];

    [Fact]
    public void ProduceCorrectHashFromModel()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(model);

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromValues()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            new DeterminedHash(id),
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            id,
            new DeterminedHash(chartId),
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashChartIdHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(chartId),
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromLegendHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            id,
            chartId,
            new DeterminedHash(legend),
            xAxisSource,
            yAxisSource,
            lineType
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashLegendHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            new DeterminedHash(id),
            chartId,
            new DeterminedHash(legend),
            xAxisSource,
            yAxisSource,
            lineType
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHashLegendHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            id,
            new DeterminedHash(chartId),
            new DeterminedHash(legend),
            xAxisSource,
            yAxisSource,
            lineType
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashChartIdHashLegendHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(chartId),
            new DeterminedHash(legend),
            xAxisSource,
            yAxisSource,
            lineType
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromXAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            id,
            chartId,
            legend,
            new DeterminedHash(xAxisSource),
            yAxisSource,
            lineType
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashXAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            new DeterminedHash(id),
            chartId,
            legend,
            new DeterminedHash(xAxisSource),
            yAxisSource,
            lineType
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHashXAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            id,
            new DeterminedHash(chartId),
            legend,
            new DeterminedHash(xAxisSource),
            yAxisSource,
            lineType
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashChartIdHashXAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(chartId),
            legend,
            new DeterminedHash(xAxisSource),
            yAxisSource,
            lineType
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromLegendHashXAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            id,
            chartId,
            new DeterminedHash(legend),
            new DeterminedHash(xAxisSource),
            yAxisSource,
            lineType
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashLegendHashXAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            new DeterminedHash(id),
            chartId,
            new DeterminedHash(legend),
            new DeterminedHash(xAxisSource),
            yAxisSource,
            lineType
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHashLegendHashXAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            id,
            new DeterminedHash(chartId),
            new DeterminedHash(legend),
            new DeterminedHash(xAxisSource),
            yAxisSource,
            lineType
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashChartIdHashLegendHashXAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(chartId),
            new DeterminedHash(legend),
            new DeterminedHash(xAxisSource),
            yAxisSource,
            lineType
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            id,
            chartId,
            legend,
            xAxisSource,
            new DeterminedHash(yAxisSource),
            lineType
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            new DeterminedHash(id),
            chartId,
            legend,
            xAxisSource,
            new DeterminedHash(yAxisSource),
            lineType
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            id,
            new DeterminedHash(chartId),
            legend,
            xAxisSource,
            new DeterminedHash(yAxisSource),
            lineType
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashChartIdHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(chartId),
            legend,
            xAxisSource,
            new DeterminedHash(yAxisSource),
            lineType
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromLegendHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            id,
            chartId,
            new DeterminedHash(legend),
            xAxisSource,
            new DeterminedHash(yAxisSource),
            lineType
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashLegendHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            new DeterminedHash(id),
            chartId,
            new DeterminedHash(legend),
            xAxisSource,
            new DeterminedHash(yAxisSource),
            lineType
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHashLegendHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            id,
            new DeterminedHash(chartId),
            new DeterminedHash(legend),
            xAxisSource,
            new DeterminedHash(yAxisSource),
            lineType
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashChartIdHashLegendHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(chartId),
            new DeterminedHash(legend),
            xAxisSource,
            new DeterminedHash(yAxisSource),
            lineType
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromXAxisSourceHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            id,
            chartId,
            legend,
            new DeterminedHash(xAxisSource),
            new DeterminedHash(yAxisSource),
            lineType
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashXAxisSourceHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            new DeterminedHash(id),
            chartId,
            legend,
            new DeterminedHash(xAxisSource),
            new DeterminedHash(yAxisSource),
            lineType
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHashXAxisSourceHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            id,
            new DeterminedHash(chartId),
            legend,
            new DeterminedHash(xAxisSource),
            new DeterminedHash(yAxisSource),
            lineType
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashChartIdHashXAxisSourceHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(chartId),
            legend,
            new DeterminedHash(xAxisSource),
            new DeterminedHash(yAxisSource),
            lineType
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromLegendHashXAxisSourceHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            id,
            chartId,
            new DeterminedHash(legend),
            new DeterminedHash(xAxisSource),
            new DeterminedHash(yAxisSource),
            lineType
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashLegendHashXAxisSourceHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            new DeterminedHash(id),
            chartId,
            new DeterminedHash(legend),
            new DeterminedHash(xAxisSource),
            new DeterminedHash(yAxisSource),
            lineType
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHashLegendHashXAxisSourceHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            id,
            new DeterminedHash(chartId),
            new DeterminedHash(legend),
            new DeterminedHash(xAxisSource),
            new DeterminedHash(yAxisSource),
            lineType
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashChartIdHashLegendHashXAxisSourceHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(chartId),
            new DeterminedHash(legend),
            new DeterminedHash(xAxisSource),
            new DeterminedHash(yAxisSource),
            lineType
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            new DeterminedHash(lineType)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            new DeterminedHash(id),
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            new DeterminedHash(lineType)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            id,
            new DeterminedHash(chartId),
            legend,
            xAxisSource,
            yAxisSource,
            new DeterminedHash(lineType)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashChartIdHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(chartId),
            legend,
            xAxisSource,
            yAxisSource,
            new DeterminedHash(lineType)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromLegendHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            id,
            chartId,
            new DeterminedHash(legend),
            xAxisSource,
            yAxisSource,
            new DeterminedHash(lineType)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashLegendHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            new DeterminedHash(id),
            chartId,
            new DeterminedHash(legend),
            xAxisSource,
            yAxisSource,
            new DeterminedHash(lineType)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHashLegendHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            id,
            new DeterminedHash(chartId),
            new DeterminedHash(legend),
            xAxisSource,
            yAxisSource,
            new DeterminedHash(lineType)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashChartIdHashLegendHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(chartId),
            new DeterminedHash(legend),
            xAxisSource,
            yAxisSource,
            new DeterminedHash(lineType)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromXAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            id,
            chartId,
            legend,
            new DeterminedHash(xAxisSource),
            yAxisSource,
            new DeterminedHash(lineType)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashXAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            new DeterminedHash(id),
            chartId,
            legend,
            new DeterminedHash(xAxisSource),
            yAxisSource,
            new DeterminedHash(lineType)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHashXAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            id,
            new DeterminedHash(chartId),
            legend,
            new DeterminedHash(xAxisSource),
            yAxisSource,
            new DeterminedHash(lineType)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashChartIdHashXAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(chartId),
            legend,
            new DeterminedHash(xAxisSource),
            yAxisSource,
            new DeterminedHash(lineType)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromLegendHashXAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            id,
            chartId,
            new DeterminedHash(legend),
            new DeterminedHash(xAxisSource),
            yAxisSource,
            new DeterminedHash(lineType)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashLegendHashXAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            new DeterminedHash(id),
            chartId,
            new DeterminedHash(legend),
            new DeterminedHash(xAxisSource),
            yAxisSource,
            new DeterminedHash(lineType)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHashLegendHashXAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            id,
            new DeterminedHash(chartId),
            new DeterminedHash(legend),
            new DeterminedHash(xAxisSource),
            yAxisSource,
            new DeterminedHash(lineType)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashChartIdHashLegendHashXAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(chartId),
            new DeterminedHash(legend),
            new DeterminedHash(xAxisSource),
            yAxisSource,
            new DeterminedHash(lineType)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromYAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            id,
            chartId,
            legend,
            xAxisSource,
            new DeterminedHash(yAxisSource),
            new DeterminedHash(lineType)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashYAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            new DeterminedHash(id),
            chartId,
            legend,
            xAxisSource,
            new DeterminedHash(yAxisSource),
            new DeterminedHash(lineType)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHashYAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            id,
            new DeterminedHash(chartId),
            legend,
            xAxisSource,
            new DeterminedHash(yAxisSource),
            new DeterminedHash(lineType)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashChartIdHashYAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(chartId),
            legend,
            xAxisSource,
            new DeterminedHash(yAxisSource),
            new DeterminedHash(lineType)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromLegendHashYAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            id,
            chartId,
            new DeterminedHash(legend),
            xAxisSource,
            new DeterminedHash(yAxisSource),
            new DeterminedHash(lineType)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashLegendHashYAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            new DeterminedHash(id),
            chartId,
            new DeterminedHash(legend),
            xAxisSource,
            new DeterminedHash(yAxisSource),
            new DeterminedHash(lineType)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHashLegendHashYAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            id,
            new DeterminedHash(chartId),
            new DeterminedHash(legend),
            xAxisSource,
            new DeterminedHash(yAxisSource),
            new DeterminedHash(lineType)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashChartIdHashLegendHashYAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(chartId),
            new DeterminedHash(legend),
            xAxisSource,
            new DeterminedHash(yAxisSource),
            new DeterminedHash(lineType)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromXAxisSourceHashYAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            id,
            chartId,
            legend,
            new DeterminedHash(xAxisSource),
            new DeterminedHash(yAxisSource),
            new DeterminedHash(lineType)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashXAxisSourceHashYAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            new DeterminedHash(id),
            chartId,
            legend,
            new DeterminedHash(xAxisSource),
            new DeterminedHash(yAxisSource),
            new DeterminedHash(lineType)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHashXAxisSourceHashYAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            id,
            new DeterminedHash(chartId),
            legend,
            new DeterminedHash(xAxisSource),
            new DeterminedHash(yAxisSource),
            new DeterminedHash(lineType)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashChartIdHashXAxisSourceHashYAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(chartId),
            legend,
            new DeterminedHash(xAxisSource),
            new DeterminedHash(yAxisSource),
            new DeterminedHash(lineType)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromLegendHashXAxisSourceHashYAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            id,
            chartId,
            new DeterminedHash(legend),
            new DeterminedHash(xAxisSource),
            new DeterminedHash(yAxisSource),
            new DeterminedHash(lineType)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashLegendHashXAxisSourceHashYAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            new DeterminedHash(id),
            chartId,
            new DeterminedHash(legend),
            new DeterminedHash(xAxisSource),
            new DeterminedHash(yAxisSource),
            new DeterminedHash(lineType)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHashLegendHashXAxisSourceHashYAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            id,
            new DeterminedHash(chartId),
            new DeterminedHash(legend),
            new DeterminedHash(xAxisSource),
            new DeterminedHash(yAxisSource),
            new DeterminedHash(lineType)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromHashes()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRelationalModelHash expected = new ChartSeriesRelationalModelHash(
            model
        );
        ChartSeriesRelationalModelHash actual = new ChartSeriesRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(chartId),
            new DeterminedHash(legend),
            new DeterminedHash(xAxisSource),
            new DeterminedHash(yAxisSource),
            new DeterminedHash(lineType)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void EnumeratesAsUntyped()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        IEnumerable hashEnumerable = new ChartSeriesRelationalModelHash(model);

        IEnumerator<byte> expectedHash = new DeterminedHash(
            _typePrefix
                .Concat(new DeterminedHash(id))
                .Concat(new DeterminedHash(chartId))
                .Concat(new DeterminedHash(legend))
                .Concat(new DeterminedHash(xAxisSource))
                .Concat(new DeterminedHash(yAxisSource))
                .Concat(new DeterminedHash(lineType))
        ).GetEnumerator();

        bool equal = true;

        foreach (object item in hashEnumerable)
        {
            _ = expectedHash.MoveNext();
            if ((byte)item != expectedHash.Current)
            {
                equal = false;
                break;
            }
        }

        Assert.True(equal);
    }

    [Fact]
    public void ProducesCorrectHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRelationalModel model = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        IEnumerable<byte> expectedHash = new DeterminedHash(
            _typePrefix
                .Concat(new DeterminedHash(id))
                .Concat(new DeterminedHash(chartId))
                .Concat(new DeterminedHash(legend))
                .Concat(new DeterminedHash(xAxisSource))
                .Concat(new DeterminedHash(yAxisSource))
                .Concat(new DeterminedHash(lineType))
        );

        Assert.Equal(expectedHash, new ChartSeriesRelationalModelHash(model));
    }

    [Fact]
    public void ProduceDifferentHashesForDifferentLineTypes()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();

        IChartSeriesRelationalModel solid = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            new String("solid")
        );

        IChartSeriesRelationalModel dashed = new FakeChartSeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            new String("dashed")
        );

        Assert.False(
            new ChartSeriesRelationalModelHash(solid).SequenceEqual(
                new ChartSeriesRelationalModelHash(dashed)
            )
        );
    }
}
