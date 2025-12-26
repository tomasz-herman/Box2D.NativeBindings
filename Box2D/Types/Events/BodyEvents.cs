namespace Box2D.Types.Events;

public unsafe struct BodyEvents
{
    public BodyMoveEvent* MoveEvents;
    public int MoveCount;
}