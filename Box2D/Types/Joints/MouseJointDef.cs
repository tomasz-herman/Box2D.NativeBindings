using System.Numerics;
using System.Runtime.InteropServices;
using Box2D.Id;

namespace Box2D.Types.Joints;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct MouseJointDef
{
    public BodyId BodyIdA;
    public BodyId BodyIdB;
    public Vector2 Target;
    public float Hertz;
    public float DampingRatio;
    public float MaxForce;
    [MarshalAs(UnmanagedType.U1)]
    public bool CollideConnected;
    public void* UserData;
    public int InternalValue;

    [DllImport("box2d", EntryPoint = "b2DefaultMouseJointDef")]
    public static extern MouseJointDef Default();
}