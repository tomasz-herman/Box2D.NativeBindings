using System.Runtime.InteropServices;
using Box2D.Id;
using Box2D.Types.Joints;

namespace Box2D.Joints;

public unsafe class WeldJoint : Joint
{
    public WeldJoint(WorldId worldId, ref WeldJointDef def) : base(CreateWeldJoint(worldId, ref def))
    {
    }

    public void SetLinearHertz(float hertz)
    {
        WeldJoint_SetLinearHertz(_id, hertz);
    }

    public float GetLinearHertz()
    {
        return WeldJoint_GetLinearHertz(_id);
    }

    public void SetLinearDampingRatio(float dampingRatio)
    {
        WeldJoint_SetLinearDampingRatio(_id, dampingRatio);
    }

    public float GetLinearDampingRatio()
    {
        return WeldJoint_GetLinearDampingRatio(_id);
    }

    public void SetAngularHertz(float hertz)
    {
        WeldJoint_SetAngularHertz(_id, hertz);
    }

    public float GetAngularHertz()
    {
        return WeldJoint_GetAngularHertz(_id);
    }

    public void SetAngularDampingRatio(float dampingRatio)
    {
        WeldJoint_SetAngularDampingRatio(_id, dampingRatio);
    }

    public float GetAngularDampingRatio()
    {
        return WeldJoint_GetAngularDampingRatio(_id);
    }

    #region NativeFunctions

    [DllImport("box2d", EntryPoint = "b2CreateWeldJoint")]
    private static extern JointId CreateWeldJoint(WorldId worldId, ref WeldJointDef def);

    [DllImport("box2d", EntryPoint = "b2WeldJoint_SetLinearHertz")]
    private static extern void WeldJoint_SetLinearHertz(JointId jointId, float hertz);

    [DllImport("box2d", EntryPoint = "b2WeldJoint_GetLinearHertz")]
    private static extern float WeldJoint_GetLinearHertz(JointId jointId);

    [DllImport("box2d", EntryPoint = "b2WeldJoint_SetLinearDampingRatio")]
    private static extern void WeldJoint_SetLinearDampingRatio(JointId jointId, float dampingRatio);

    [DllImport("box2d", EntryPoint = "b2WeldJoint_GetLinearDampingRatio")]
    private static extern float WeldJoint_GetLinearDampingRatio(JointId jointId);

    [DllImport("box2d", EntryPoint = "b2WeldJoint_SetAngularHertz")]
    private static extern void WeldJoint_SetAngularHertz(JointId jointId, float hertz);

    [DllImport("box2d", EntryPoint = "b2WeldJoint_GetAngularHertz")]
    private static extern float WeldJoint_GetAngularHertz(JointId jointId);

    [DllImport("box2d", EntryPoint = "b2WeldJoint_SetAngularDampingRatio")]
    private static extern void WeldJoint_SetAngularDampingRatio(JointId jointId, float dampingRatio);

    [DllImport("box2d", EntryPoint = "b2WeldJoint_GetAngularDampingRatio")]
    private static extern float WeldJoint_GetAngularDampingRatio(JointId jointId);

    #endregion
}
