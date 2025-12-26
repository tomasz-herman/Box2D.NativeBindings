using System.Numerics;
using System.Runtime.InteropServices;
using Box2D.Id;

namespace Box2D.Types.Joints;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct WeldJointDef
{
    public BodyId BodyIdA;
    public BodyId BodyIdB;
    public Vector2 LocalAnchorA;
    public Vector2 LocalAnchorB;
    public float ReferenceAngle;
    public float LinearHertz;
    public float AngularHertz;
    public float LinearDampingRatio;
    public float AngularDampingRatio;
    [MarshalAs(UnmanagedType.U1)]
    public bool CollideConnected;
    public void* UserData;
    public int InternalValue;

    [DllImport("box2d", EntryPoint = "b2DefaultWeldJointDef")]
    public static extern WeldJointDef Default();
}