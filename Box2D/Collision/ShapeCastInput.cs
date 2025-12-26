using System.Numerics;
using System.Runtime.InteropServices;

namespace Box2D.Collision;

public struct ShapeCastInput
{
    public ShapeProxy Proxy;
    public Vector2 Translation;
    public float MaxFraction;
    [MarshalAs(UnmanagedType.U1)]
    public bool CanEncroach;
}