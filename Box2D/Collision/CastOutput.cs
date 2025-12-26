using System.Numerics;
using System.Runtime.InteropServices;

namespace Box2D.Collision;

public struct CastOutput
{
    public Vector2 Normal;
    public Vector2 Point;
    public float Fraction;
    public int Iterations;
    [MarshalAs(UnmanagedType.U1)]
    public bool Hit;
}