using System.Runtime.InteropServices;
using Box2D.Id;
using Box2D.Math;

namespace Box2D.Types.Events;

public unsafe struct BodyMoveEvent
{
    public void* UserData;
    public Transform Transform;
    public BodyId BodyId;
    [MarshalAs(UnmanagedType.U1)]
    public bool FellAsleep;
}