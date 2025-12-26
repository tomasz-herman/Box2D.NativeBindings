using System.Numerics;
using System.Runtime.InteropServices;

namespace Box2D.Types.Bodies;

public unsafe struct BodyDef
{
    public BodyType Type;
    public Vector2 Position;
    public Vector2 Rotation;
    public Vector2 LinearVelocity;
    public float AngularVelocity;
    public float LinearDamping;
    public float AngularDamping;
    public float GravityScale;
    public float SleepThreshold;
    public byte* Name;
    public void* UserData;
    [MarshalAs(UnmanagedType.U1)] 
    public bool EnableSleep;
    [MarshalAs(UnmanagedType.U1)] 
    public bool IsAwake;
    [MarshalAs(UnmanagedType.U1)] 
    public bool FixedRotation;
    [MarshalAs(UnmanagedType.U1)] 
    public bool IsBullet;
    [MarshalAs(UnmanagedType.U1)] 
    public bool IsEnabled;
    [MarshalAs(UnmanagedType.U1)] 
    public bool AllowFastRotation;
    private int _internalValue;
    
    [DllImport("box2d", EntryPoint = "b2DefaultBodyDef")]
    public static extern BodyDef Default();
}