using Box2D.Id;

namespace Box2D.Types.Events;

public struct ContactEndTouchEvent
{
    public ShapeId ShapeIdA;
    public ShapeId ShapeIdB;
}