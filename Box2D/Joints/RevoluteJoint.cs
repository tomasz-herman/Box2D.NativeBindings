using System.Runtime.InteropServices;
using Box2D.Id;
using Box2D.Types.Joints;

namespace Box2D.Joints;

public unsafe class RevoluteJoint : Joint
{
    public RevoluteJoint(WorldId worldId, ref RevoluteJointDef def) : base(CreateRevoluteJoint(worldId, ref def))
    {
    }

    public void EnableSpring(bool enableSpring)
    {
        RevoluteJoint_EnableSpring(_id, enableSpring);
    }

    public bool IsSpringEnabled()
    {
        return RevoluteJoint_IsSpringEnabled(_id);
    }

    public void SetSpringHertz(float hertz)
    {
        RevoluteJoint_SetSpringHertz(_id, hertz);
    }

    public float GetSpringHertz()
    {
        return RevoluteJoint_GetSpringHertz(_id);
    }

    public void SetSpringDampingRatio(float dampingRatio)
    {
        RevoluteJoint_SetSpringDampingRatio(_id, dampingRatio);
    }

    public float GetSpringDampingRatio()
    {
        return RevoluteJoint_GetSpringDampingRatio(_id);
    }

    public void SetTargetAngle(float angle)
    {
        RevoluteJoint_SetTargetAngle(_id, angle);
    }

    public float GetTargetAngle()
    {
        return RevoluteJoint_GetTargetAngle(_id);
    }

    public float GetAngle()
    {
        return RevoluteJoint_GetAngle(_id);
    }

    public void EnableLimit(bool enableLimit)
    {
        RevoluteJoint_EnableLimit(_id, enableLimit);
    }

    public bool IsLimitEnabled()
    {
        return RevoluteJoint_IsLimitEnabled(_id);
    }

    public float GetLowerLimit()
    {
        return RevoluteJoint_GetLowerLimit(_id);
    }

    public float GetUpperLimit()
    {
        return RevoluteJoint_GetUpperLimit(_id);
    }

    public void SetLimits(float lower, float upper)
    {
        RevoluteJoint_SetLimits(_id, lower, upper);
    }

    public void EnableMotor(bool enableMotor)
    {
        RevoluteJoint_EnableMotor(_id, enableMotor);
    }

    public bool IsMotorEnabled()
    {
        return RevoluteJoint_IsMotorEnabled(_id);
    }

    public void SetMotorSpeed(float motorSpeed)
    {
        RevoluteJoint_SetMotorSpeed(_id, motorSpeed);
    }

    public float GetMotorSpeed()
    {
        return RevoluteJoint_GetMotorSpeed(_id);
    }

    public float GetMotorTorque()
    {
        return RevoluteJoint_GetMotorTorque(_id);
    }

    public void SetMaxMotorTorque(float torque)
    {
        RevoluteJoint_SetMaxMotorTorque(_id, torque);
    }

    public float GetMaxMotorTorque()
    {
        return RevoluteJoint_GetMaxMotorTorque(_id);
    }

    #region NativeFunctions

    [DllImport("box2d", EntryPoint = "b2CreateRevoluteJoint")]
    private static extern JointId CreateRevoluteJoint(WorldId worldId, ref RevoluteJointDef def);

    [DllImport("box2d", EntryPoint = "b2RevoluteJoint_EnableSpring")]
    private static extern void RevoluteJoint_EnableSpring(JointId jointId, [MarshalAs(UnmanagedType.U1)] bool enableSpring);

    [DllImport("box2d", EntryPoint = "b2RevoluteJoint_IsSpringEnabled")]
    [return: MarshalAs(UnmanagedType.U1)]
    private static extern bool RevoluteJoint_IsSpringEnabled(JointId jointId);

    [DllImport("box2d", EntryPoint = "b2RevoluteJoint_SetSpringHertz")]
    private static extern void RevoluteJoint_SetSpringHertz(JointId jointId, float hertz);

    [DllImport("box2d", EntryPoint = "b2RevoluteJoint_GetSpringHertz")]
    private static extern float RevoluteJoint_GetSpringHertz(JointId jointId);

    [DllImport("box2d", EntryPoint = "b2RevoluteJoint_SetSpringDampingRatio")]
    private static extern void RevoluteJoint_SetSpringDampingRatio(JointId jointId, float dampingRatio);

    [DllImport("box2d", EntryPoint = "b2RevoluteJoint_GetSpringDampingRatio")]
    private static extern float RevoluteJoint_GetSpringDampingRatio(JointId jointId);

    [DllImport("box2d", EntryPoint = "b2RevoluteJoint_SetTargetAngle")]
    private static extern void RevoluteJoint_SetTargetAngle(JointId jointId, float angle);

    [DllImport("box2d", EntryPoint = "b2RevoluteJoint_GetTargetAngle")]
    private static extern float RevoluteJoint_GetTargetAngle(JointId jointId);

    [DllImport("box2d", EntryPoint = "b2RevoluteJoint_GetAngle")]
    private static extern float RevoluteJoint_GetAngle(JointId jointId);

    [DllImport("box2d", EntryPoint = "b2RevoluteJoint_EnableLimit")]
    private static extern void RevoluteJoint_EnableLimit(JointId jointId, [MarshalAs(UnmanagedType.U1)] bool enableLimit);

    [DllImport("box2d", EntryPoint = "b2RevoluteJoint_IsLimitEnabled")]
    [return: MarshalAs(UnmanagedType.U1)]
    private static extern bool RevoluteJoint_IsLimitEnabled(JointId jointId);

    [DllImport("box2d", EntryPoint = "b2RevoluteJoint_GetLowerLimit")]
    private static extern float RevoluteJoint_GetLowerLimit(JointId jointId);

    [DllImport("box2d", EntryPoint = "b2RevoluteJoint_GetUpperLimit")]
    private static extern float RevoluteJoint_GetUpperLimit(JointId jointId);

    [DllImport("box2d", EntryPoint = "b2RevoluteJoint_SetLimits")]
    private static extern void RevoluteJoint_SetLimits(JointId jointId, float lower, float upper);

    [DllImport("box2d", EntryPoint = "b2RevoluteJoint_EnableMotor")]
    private static extern void RevoluteJoint_EnableMotor(JointId jointId, [MarshalAs(UnmanagedType.U1)] bool enableMotor);

    [DllImport("box2d", EntryPoint = "b2RevoluteJoint_IsMotorEnabled")]
    [return: MarshalAs(UnmanagedType.U1)]
    private static extern bool RevoluteJoint_IsMotorEnabled(JointId jointId);

    [DllImport("box2d", EntryPoint = "b2RevoluteJoint_SetMotorSpeed")]
    private static extern void RevoluteJoint_SetMotorSpeed(JointId jointId, float motorSpeed);

    [DllImport("box2d", EntryPoint = "b2RevoluteJoint_GetMotorSpeed")]
    private static extern float RevoluteJoint_GetMotorSpeed(JointId jointId);

    [DllImport("box2d", EntryPoint = "b2RevoluteJoint_GetMotorTorque")]
    private static extern float RevoluteJoint_GetMotorTorque(JointId jointId);

    [DllImport("box2d", EntryPoint = "b2RevoluteJoint_SetMaxMotorTorque")]
    private static extern void RevoluteJoint_SetMaxMotorTorque(JointId jointId, float torque);

    [DllImport("box2d", EntryPoint = "b2RevoluteJoint_GetMaxMotorTorque")]
    private static extern float RevoluteJoint_GetMaxMotorTorque(JointId jointId);

    #endregion
}
