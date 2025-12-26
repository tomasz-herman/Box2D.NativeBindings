using System.Numerics;

namespace Box2D.Collision;

public struct DistanceOutput
{
    public Vector2 PointA;
    public Vector2 PointB;
    public Vector2 Normal;
    public float Distance;
    public int Iterations;
    public int SimplexCount;
}