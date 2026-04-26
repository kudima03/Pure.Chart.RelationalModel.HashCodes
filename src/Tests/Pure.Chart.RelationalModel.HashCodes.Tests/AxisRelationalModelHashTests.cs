using System.Collections;
using Pure.Chart.RelationalModel.Abstractions;
using Pure.HashCodes;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;
using Pure.Primitives.Random.String;
using Guid = Pure.Primitives.Guid.Guid;

namespace Pure.Chart.RelationalModel.HashCodes.Tests;

public sealed record AxisRelationalModelHashTests
{
    private readonly byte[] _typePrefix =
    [
        247,
        25,
        157,
        1,
        50,
        254,
        158,
        125,
        188,
        66,
        0,
        101,
        214,
        150,
        50,
        194,
    ];

    [Fact]
    public void ProduceCorrectHashFromModel()
    {
        IGuid id = new Guid();
        IString legend = new RandomString();

        IAxisRelationalModel model = new AxisRelationalModel(id, legend);

        AxisRelationalModelHash expected = new AxisRelationalModelHash(model);
        AxisRelationalModelHash actual = new AxisRelationalModelHash(model);

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromValues()
    {
        IGuid id = new Guid();
        IString legend = new RandomString();

        IAxisRelationalModel model = new AxisRelationalModel(id, legend);

        AxisRelationalModelHash expected = new AxisRelationalModelHash(model);
        AxisRelationalModelHash actual = new AxisRelationalModelHash(id, legend);

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHash()
    {
        IGuid id = new Guid();
        IString legend = new RandomString();

        IAxisRelationalModel model = new AxisRelationalModel(id, legend);

        AxisRelationalModelHash expected = new AxisRelationalModelHash(model);
        AxisRelationalModelHash actual = new AxisRelationalModelHash(
            new DeterminedHash(id),
            legend
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromLegendHash()
    {
        IGuid id = new Guid();
        IString legend = new RandomString();

        IAxisRelationalModel model = new AxisRelationalModel(id, legend);

        AxisRelationalModelHash expected = new AxisRelationalModelHash(model);
        AxisRelationalModelHash actual = new AxisRelationalModelHash(
            id,
            new DeterminedHash(legend)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashLegendHash()
    {
        IGuid id = new Guid();
        IString legend = new RandomString();

        IAxisRelationalModel model = new AxisRelationalModel(id, legend);

        AxisRelationalModelHash expected = new AxisRelationalModelHash(model);
        AxisRelationalModelHash actual = new AxisRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(legend)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void EnumeratesAsUntyped()
    {
        IGuid id = new Guid();
        IString legend = new RandomString();

        IAxisRelationalModel model = new AxisRelationalModel(id, legend);

        IEnumerable hashEnumerable = new AxisRelationalModelHash(model);

        IEnumerator<byte> expectedHash = new DeterminedHash(
            _typePrefix.Concat(new DeterminedHash(id)).Concat(new DeterminedHash(legend))
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
        IString legend = new RandomString();

        IAxisRelationalModel model = new AxisRelationalModel(id, legend);

        IEnumerable<byte> expectedHash = new DeterminedHash(
            _typePrefix.Concat(new DeterminedHash(id)).Concat(new DeterminedHash(legend))
        );

        Assert.Equal(expectedHash, new AxisRelationalModelHash(model));
    }
}
