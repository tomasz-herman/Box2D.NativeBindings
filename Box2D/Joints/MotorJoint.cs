using System.Numerics;
using System.Runtime.InteropServices;
using Box2D.Id;
using Box2D.Types.Joints;

namespace Box2D.Joints;

public unsafe class MotorJoint : Joint
{
    public MotorJoint(WorldId worldId, ref MotorJointDef def) : base(CreateMotorJoint(worldId, ref def))
    {
    }

    public void SetLinearVelocity(Vector2 velocity)
    {
        MotorJoint_SetLinearVelocity(_id, velocity);
    }

    public Vector2 GetLinearVelocity()
    {
        return MotorJoint_GetLinearVelocity(_id);
    }

    public void SetAngularVelocity(float velocity)
    {
        MotorJoint_SetAngularVelocity(_id, velocity);
    }

    public float GetAngularVelocity()
    {
        return MotorJoint_GetAngularVelocity(_id);
    }

    public void SetMaxVelocityForce(float maxForce)
    {
        MotorJoint_SetMaxVelocityForce(_id, maxForce);
    }

    public float GetMaxVelocityForce()
    {
        return MotorJoint_GetMaxVelocityForce(_id);
    }

    public void SetMaxVelocityTorque(float maxTorque)
    {
        MotorJoint_SetMaxVelocityTorque(_id, maxTorque);
    }

    public float GetMaxVelocityTorque()
    {
        return MotorJoint_GetMaxVelocityTorque(_id);
    }

    public void SetLinearHertz(float hertz)
    {
        MotorJoint_SetLinearHertz(_id, hertz);
    }

    public float GetLinearHertz()
    {
        return MotorJoint_GetLinearHertz(_id);
    }

    public void SetLinearDampingRatio(float damping)
    {
        MotorJoint_SetLinearDampingRatio(_id, damping);
    }

    public float GetLinearDampingRatio()
    {
        return MotorJoint_GetLinearDampingRatio(_id);
    }

    public void SetAngularHertz(float hertz)
    {
        MotorJoint_SetAngularHertz(_id, hertz);
    }

    public float GetAngularHertz()
    {
        return MotorJoint_GetAngularHertz(_id);
    }

    public void SetAngularDampingRatio(float damping)
    {
        MotorJoint_SetAngularDampingRatio(_id, damping);
    }

    public float GetAngularDampingRatio()
    {
        return MotorJoint_GetAngularDampingRatio(_id);
    }

    public void SetMaxForce(float maxForce)
    {
        MotorJoint_SetMaxForce(_id, maxForce);
    }

    public float GetMaxForce()
    {
        return MotorJoint_GetMaxForce(_id);
    }

    public void SetMaxTorque(float maxTorque)
    {
        MotorJoint_SetMaxTorque(_id, maxTorque);
    }

    public float GetMaxTorque()
    {
        return MotorJoint_GetMaxTorque(_id);
    }

    #region NativeFunctions

    [DllImport("box2d", EntryPoint = "b2CreateMotorJoint")]
    private static extern JointId CreateMotorJoint(WorldId worldId, ref MotorJointDef def);

    [DllImport("box2d", EntryPoint = "b2MotorJoint_SetLinearVelocity")]
    private static extern void MotorJoint_SetLinearVelocity(JointId jointId, Vector2 velocity);

    [DllImport("box2d", EntryPoint = "b2MotorJoint_GetLinearVelocity")]
    private static extern Vector2 MotorJoint_GetLinearVelocity(JointId jointId);

    [DllImport("box2d", EntryPoint = "b2MotorJoint_SetAngularVelocity")]
    private static extern void MotorJoint_SetAngularVelocity(JointId jointId, float velocity);

    [DllImport("box2d", EntryPoint = "b2MotorJoint_GetAngularVelocity")]
    private static extern float MotorJoint_GetAngularVelocity(JointId jointId);

    [DllImport("box2d", EntryPoint = "b2MotorJoint_SetMaxVelocityForce")]
    private static extern void MotorJoint_SetMaxVelocityForce(JointId jointId, float maxForce);

    [DllImport("box2d", EntryPoint = "b2MotorJoint_GetMaxVelocityForce")]
    private static extern float MotorJoint_GetMaxVelocityForce(JointId jointId);

    [DllImport("box2d", EntryPoint = "b2MotorJoint_SetMaxVelocityTorque")]
    private static extern void MotorJoint_SetMaxVelocityTorque(JointId jointId, float maxTorque);

    [DllImport("box2d", EntryPoint = "b2MotorJoint_GetMaxVelocityTorque")]
    private static extern float MotorJoint_GetMaxVelocityTorque(JointId jointId);

    [DllImport("box2d", EntryPoint = "b2MotorJoint_SetLinearHertz")]
    private static extern void MotorJoint_SetLinearHertz(JointId jointId, float hertz);

    [DllImport("box2d", EntryPoint = "b2MotorJoint_GetLinearHertz")]
    private static extern float MotorJoint_GetLinearHertz(JointId jointId);

    [DllImport("box2d", EntryPoint = "b2MotorJoint_SetLinearDampingRatio")]
    private static extern void MotorJoint_SetLinearDampingRatio(JointId jointId, float damping);

    [DllImport("box2d", EntryPoint = "b2MotorJoint_GetLinearDampingRatio")]
    private static extern float MotorJoint_GetLinearDampingRatio(JointId jointId);

    [DllImport("box2d", EntryPoint = "b2MotorJoint_SetAngularHertz")]
    private static extern void MotorJoint_SetAngularHertz(JointId jointId, float hertz);

    [DllImport("box2d", EntryPoint = "b2MotorJoint_GetAngularHertz")]
    private static extern float MotorJoint_GetAngularHertz(JointId jointId);

    [DllImport("box2d", EntryPoint = "b2MotorJoint_SetAngularDampingRatio")]
    private static extern void MotorJoint_SetAngularDampingRatio(JointId jointId, float damping);

    [DllImport("box2d", EntryPoint = "b2MotorJoint_GetAngularDampingRatio")]
    private static extern float MotorJoint_GetAngularDampingRatio(JointId jointId);

    [DllImport("box2d", EntryPoint = "b2MotorJoint_SetMaxForce")]
    private static extern void MotorJoint_SetMaxForce(JointId jointId, float maxForce);

    [DllImport("box2d", EntryPoint = "b2MotorJoint_GetMaxForce")]
    private static extern float MotorJoint_GetMaxForce(JointId jointId);

    [DllImport("box2d", EntryPoint = "b2MotorJoint_SetMaxTorque")]
    private static extern void MotorJoint_SetMaxTorque(JointId jointId, float maxTorque);

    [DllImport("box2d", EntryPoint = "b2MotorJoint_GetMaxTorque")]
    private static extern float MotorJoint_GetMaxTorque(JointId jointId);

    #endregion
}
