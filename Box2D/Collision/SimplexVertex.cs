using System.Numerics;

namespace Box2D.Collision;

public struct SimplexVertex
{
    public Vector2 WA;
    public Vector2 WB;
    public Vector2 W;
    public float A;
    public int IndexA;
    public int IndexB;
}