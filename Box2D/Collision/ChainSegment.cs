using System.Numerics;

namespace Box2D.Collision;

public struct ChainSegment
{
    public Vector2 Ghost1;
    public Segment Segment;
    public Vector2 Ghost2;
    private int _chainId;
}