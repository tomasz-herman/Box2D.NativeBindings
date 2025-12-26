namespace Box2D.Types.Events;

public unsafe struct SensorEvents
{
    public SensorBeginTouchEvent* BeginEvents;
    public SensorBeginTouchEvent* EndEvents;
    public int BeginCount;
    public int EndCount;
}