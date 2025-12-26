using System.Runtime.InteropServices;
using Box2D.Id;
using Box2D.Types.Joints;

namespace Box2D.Joints;

public unsafe class DistanceJoint : Joint
{
    public DistanceJoint(WorldId worldId, ref DistanceJointDef def) : base(CreateDistanceJoint(worldId, ref def))
    {
    }

    public void SetLength(float length)
    {
        DistanceJoint_SetLength(_id, length);
    }

    public float GetLength()
    {
        return DistanceJoint_GetLength(_id);
    }

    public void EnableSpring(bool enableSpring)
    {
        DistanceJoint_EnableSpring(_id, enableSpring);
    }

    public bool IsSpringEnabled()
    {
        return DistanceJoint_IsSpringEnabled(_id);
    }

    public void SetSpringHertz(float hertz)
    {
        DistanceJoint_SetSpringHertz(_id, hertz);
    }

    public void SetSpringDampingRatio(float dampingRatio)
    {
        DistanceJoint_SetSpringDampingRatio(_id, dampingRatio);
    }

    public float GetSpringHertz()
    {
        return DistanceJoint_GetSpringHertz(_id);
    }

    public float GetSpringDampingRatio()
    {
        return DistanceJoint_GetSpringDampingRatio(_id);
    }

    public void EnableLimit(bool enableLimit)
    {
        DistanceJoint_EnableLimit(_id, enableLimit);
    }

    public bool IsLimitEnabled()
    {
        return DistanceJoint_IsLimitEnabled(_id);
    }

    public void SetLengthRange(float minLength, float maxLength)
    {
        DistanceJoint_SetLengthRange(_id, minLength, maxLength);
    }

    public float GetMinLength()
    {
        return DistanceJoint_GetMinLength(_id);
    }

    public float GetMaxLength()
    {
        return DistanceJoint_GetMaxLength(_id);
    }

    public float GetCurrentLength()
    {
        return DistanceJoint_GetCurrentLength(_id);
    }

    public void EnableMotor(bool enableMotor)
    {
        DistanceJoint_EnableMotor(_id, enableMotor);
    }

    public bool IsMotorEnabled()
    {
        return DistanceJoint_IsMotorEnabled(_id);
    }

    public void SetMotorSpeed(float motorSpeed)
    {
        DistanceJoint_SetMotorSpeed(_id, motorSpeed);
    }

    public float GetMotorSpeed()
    {
        return DistanceJoint_GetMotorSpeed(_id);
    }

    public void SetMaxMotorForce(float force)
    {
        DistanceJoint_SetMaxMotorForce(_id, force);
    }

    public float GetMaxMotorForce()
    {
        return DistanceJoint_GetMaxMotorForce(_id);
    }

    public float GetMotorForce()
    {
        return DistanceJoint_GetMotorForce(_id);
    }

    #region NativeFunctions

    [DllImport("box2d", EntryPoint = "b2CreateDistanceJoint")]
    private static extern JointId CreateDistanceJoint(WorldId worldId, ref DistanceJointDef def);

    [DllImport("box2d", EntryPoint = "b2DistanceJoint_SetLength")]
    private static extern void DistanceJoint_SetLength(JointId jointId, float length);

    [DllImport("box2d", EntryPoint = "b2DistanceJoint_GetLength")]
    private static extern float DistanceJoint_GetLength(JointId jointId);

    [DllImport("box2d", EntryPoint = "b2DistanceJoint_EnableSpring")]
    private static extern void DistanceJoint_EnableSpring(JointId jointId, [MarshalAs(UnmanagedType.U1)] bool enableSpring);

    [DllImport("box2d", EntryPoint = "b2DistanceJoint_IsSpringEnabled")]
    [return: MarshalAs(UnmanagedType.U1)]
    private static extern bool DistanceJoint_IsSpringEnabled(JointId jointId);

    [DllImport("box2d", EntryPoint = "b2DistanceJoint_SetSpringHertz")]
    private static extern void DistanceJoint_SetSpringHertz(JointId jointId, float hertz);

    [DllImport("box2d", EntryPoint = "b2DistanceJoint_SetSpringDampingRatio")]
    private static extern void DistanceJoint_SetSpringDampingRatio(JointId jointId, float dampingRatio);

    [DllImport("box2d", EntryPoint = "b2DistanceJoint_GetSpringHertz")]
    private static extern float DistanceJoint_GetSpringHertz(JointId jointId);

    [DllImport("box2d", EntryPoint = "b2DistanceJoint_GetSpringDampingRatio")]
    private static extern float DistanceJoint_GetSpringDampingRatio(JointId jointId);

    [DllImport("box2d", EntryPoint = "b2DistanceJoint_EnableLimit")]
    private static extern void DistanceJoint_EnableLimit(JointId jointId, [MarshalAs(UnmanagedType.U1)] bool enableLimit);

    [DllImport("box2d", EntryPoint = "b2DistanceJoint_IsLimitEnabled")]
    [return: MarshalAs(UnmanagedType.U1)]
    private static extern bool DistanceJoint_IsLimitEnabled(JointId jointId);

    [DllImport("box2d", EntryPoint = "b2DistanceJoint_SetLengthRange")]
    private static extern void DistanceJoint_SetLengthRange(JointId jointId, float minLength, float maxLength);

    [DllImport("box2d", EntryPoint = "b2DistanceJoint_GetMinLength")]
    private static extern float DistanceJoint_GetMinLength(JointId jointId);

    [DllImport("box2d", EntryPoint = "b2DistanceJoint_GetMaxLength")]
    private static extern float DistanceJoint_GetMaxLength(JointId jointId);

    [DllImport("box2d", EntryPoint = "b2DistanceJoint_GetCurrentLength")]
    private static extern float DistanceJoint_GetCurrentLength(JointId jointId);

    [DllImport("box2d", EntryPoint = "b2DistanceJoint_EnableMotor")]
    private static extern void DistanceJoint_EnableMotor(JointId jointId, [MarshalAs(UnmanagedType.U1)] bool enableMotor);

    [DllImport("box2d", EntryPoint = "b2DistanceJoint_IsMotorEnabled")]
    [return: MarshalAs(UnmanagedType.U1)]
    private static extern bool DistanceJoint_IsMotorEnabled(JointId jointId);

    [DllImport("box2d", EntryPoint = "b2DistanceJoint_SetMotorSpeed")]
    private static extern void DistanceJoint_SetMotorSpeed(JointId jointId, float motorSpeed);

    [DllImport("box2d", EntryPoint = "b2DistanceJoint_GetMotorSpeed")]
    private static extern float DistanceJoint_GetMotorSpeed(JointId jointId);

    [DllImport("box2d", EntryPoint = "b2DistanceJoint_SetMaxMotorForce")]
    private static extern void DistanceJoint_SetMaxMotorForce(JointId jointId, float force);

    [DllImport("box2d", EntryPoint = "b2DistanceJoint_GetMaxMotorForce")]
    private static extern float DistanceJoint_GetMaxMotorForce(JointId jointId);

    [DllImport("box2d", EntryPoint = "b2DistanceJoint_GetMotorForce")]
    private static extern float DistanceJoint_GetMotorForce(JointId jointId);

    #endregion
}
