namespace Box2D.Types.Events;

public unsafe struct ContactEvents
{
    public ContactBeginTouchEvent* BeginEvents;
    public ContactEndTouchEvent* EndEvents;
    public ContactHitEvent* HitEvents;
    public int BeginCount;
    public int EndCount;
    public int HitCount;
}