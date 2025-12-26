using System.Numerics;
using System.Runtime.InteropServices;

namespace Box2D.Types;

public struct ExplosionDef
{
    public ulong MaskBits;
    public Vector2 Position;
    public float Radius;
    public float Falloff;
    public float ImpulsePerLength;
    
    [DllImport("box2d", EntryPoint = "b2DefaultExplosionDef")]
    public static extern ExplosionDef Default();
}