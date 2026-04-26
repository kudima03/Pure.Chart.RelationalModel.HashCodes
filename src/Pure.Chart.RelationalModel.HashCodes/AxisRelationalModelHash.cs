using System.Collections;
using Pure.Chart.RelationalModel.Abstractions;
using Pure.HashCodes;
using Pure.HashCodes.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;

namespace Pure.Chart.RelationalModel.HashCodes;

public sealed record AxisRelationalModelHash : IDeterminedHash
{
    private static readonly byte[] TypePrefix =
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

    private readonly IDeterminedHash _idHash;

    private readonly IDeterminedHash _legendHash;

    public AxisRelationalModelHash(IAxisRelationalModel model)
        : this(model.Id, model.Legend) { }

    public AxisRelationalModelHash(IGuid id, IString legend)
        : this(id, new DeterminedHash(legend)) { }

    public AxisRelationalModelHash(
        IDeterminedHash idHash,
        IString legend
    )
        : this(idHash, new DeterminedHash(legend)) { }

    public AxisRelationalModelHash(
        IGuid id,
        IDeterminedHash legendHash
    )
        : this(new DeterminedHash(id), legendHash) { }

    public AxisRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash legendHash
    )
    {
        _idHash = idHash;
        _legendHash = legendHash;
    }

    public IEnumerator<byte> GetEnumerator()
    {
        return new DeterminedHash(
            TypePrefix.Concat(_idHash).Concat(_legendHash)
        ).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
