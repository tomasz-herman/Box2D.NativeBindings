namespace Box2D.Id;

public struct ChainId
{
    private int _index;
    private ushort _world;
    private ushort _generation;

    public static implicit operator ChainId(ulong id) => new()
        { _index = (int)(id >> 32), _world = (ushort)(id >> 16), _generation = (ushort)id };

    public static implicit operator ulong(ChainId id) =>
        ((ulong)id._index << 32) | (ulong)id._world << 16 | id._generation;
}