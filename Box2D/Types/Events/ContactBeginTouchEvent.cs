using Box2D.Collision;
using Box2D.Id;

namespace Box2D.Types.Events;

public struct ContactBeginTouchEvent
{
    public ShapeId ShapeIdA;
    public ShapeId ShapeIdB;
    public Manifold Manifold;
}