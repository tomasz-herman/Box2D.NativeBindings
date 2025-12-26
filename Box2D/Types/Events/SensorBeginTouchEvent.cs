using Box2D.Id;

namespace Box2D.Types.Events;

public struct SensorBeginTouchEvent
{
    public ShapeId SensorShapeId;
    public ShapeId VisitorShapeId;
}