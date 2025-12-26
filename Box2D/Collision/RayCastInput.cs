using System.Numerics;
using System.Runtime.InteropServices;

namespace Box2D.Collision;

public unsafe struct RayCastInput
{
    public Vector2 Origin;
    public Vector2 Translation;
    public float MaxFraction;

    public bool IsValid()
    {
        return IsValid(ref this);
    }

    [DllImport("box2d", EntryPoint = "b2IsValidRay")]
    [return: MarshalAs(UnmanagedType.U1)]
    private static extern bool IsValid(ref RayCastInput input);
}