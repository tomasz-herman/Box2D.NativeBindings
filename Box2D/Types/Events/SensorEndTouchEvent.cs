using Box2D.Id;

namespace Box2D.Types.Events;

public struct SensorEndTouchEvent
{
    public ShapeId SensorShapeId;
    public ShapeId VisitorShapeId;
}