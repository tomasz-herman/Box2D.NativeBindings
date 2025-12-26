namespace Box2D.Collision;

public unsafe struct SimplexCache
{
    public ushort Count;
    public fixed byte IndexA[3];
    public fixed byte IndexB[3];
}