using System.Numerics;
using System.Runtime.InteropServices;

namespace Box2D.Collision;

public struct ManifoldPoint
{
    public Vector2 Point;
    public Vector2 AnchorA;
    public Vector2 AnchorB;
    public float Separation;
    public float NormalImpulse;
    public float TangentImpulse;
    public float TotalNormalImpulse;
    public float NormalVelocity;
    public ushort Id;
    [MarshalAs(UnmanagedType.U1)]
    public bool Persisted;
}