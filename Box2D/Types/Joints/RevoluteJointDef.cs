using System.Numerics;
using System.Runtime.InteropServices;
using Box2D.Id;

namespace Box2D.Types.Joints;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct RevoluteJointDef
{
    public BodyId BodyIdA;
    public BodyId BodyIdB;
    public Vector2 LocalAnchorA;
    public Vector2 LocalAnchorB;
    public float ReferenceAngle;
    public float TargetAngle;
    [MarshalAs(UnmanagedType.U1)]
    public bool EnableSpring;
    public float Hertz;
    public float DampingRatio;
    [MarshalAs(UnmanagedType.U1)]
    public bool EnableLimit;
    public float LowerAngle;
    public float UpperAngle;
    [MarshalAs(UnmanagedType.U1)]
    public bool EnableMotor;
    public float MaxMotorTorque;
    public float MotorSpeed;
    public float DrawSize;
    [MarshalAs(UnmanagedType.U1)]
    public bool CollideConnected;
    public void* UserData;
    public int InternalValue;

    [DllImport("box2d", EntryPoint = "b2DefaultRevoluteJointDef")]
    public static extern RevoluteJointDef Default();
}