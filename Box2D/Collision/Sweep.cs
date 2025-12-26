using System.Numerics;
using System.Runtime.InteropServices;
using Box2D.Math;

namespace Box2D.Collision;

public struct Sweep
{
    public Vector2 LocalCenter;
    public Vector2 C1;
    public Vector2 C2;
    public Rotation Q1;
    public Rotation Q2;
    
    [DllImport("box2d", EntryPoint = "b2GetSweepTransform")]
    public static extern Transform GetSweepTransform(ref Sweep sweep, float time);
}