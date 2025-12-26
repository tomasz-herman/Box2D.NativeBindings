using System.Numerics;
using Box2D.Id;

namespace Box2D.Types.Events;

public struct ContactHitEvent
{
    public ShapeId ShapeIdA;
    public ShapeId ShapeIdB;
    public Vector2 Point;
    public Vector2 Normal;
    public float ApproachSpeed;
}