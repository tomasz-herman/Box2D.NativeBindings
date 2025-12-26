using System.Numerics;
using System.Runtime.InteropServices;
using Box2D.Id;

namespace Box2D.Types.Joints;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct DistanceJointDef
{
    public BodyId BodyIdA;
    public BodyId BodyIdB;
    public Vector2 LocalAnchorA;
    public Vector2 LocalAnchorB;
    public float Length;
    [MarshalAs(UnmanagedType.U1)]
    public bool EnableSpring;
    public float Hertz;
    public float DampingRatio;
    [MarshalAs(UnmanagedType.U1)]
    public bool EnableLimit;
    public float MinLength;
    public float MaxLength;
    [MarshalAs(UnmanagedType.U1)]
    public bool EnableMotor;
    public float MaxMotorForce;
    public float MotorSpeed;
    [MarshalAs(UnmanagedType.U1)]
    public bool CollideConnected;
    public void* UserData;
    public int InternalValue;

    [DllImport("box2d", EntryPoint = "b2DefaultDistanceJointDef")]
    public static extern DistanceJointDef Default();
}