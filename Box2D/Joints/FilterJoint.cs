using System.Runtime.InteropServices;
using Box2D.Id;
using Box2D.Types.Joints;

namespace Box2D.Joints;

public unsafe class FilterJoint : Joint
{
    public FilterJoint(WorldId worldId, ref FilterJointDef def) : base(CreateFilterJoint(worldId, ref def))
    {
    }

    #region NativeFunctions

    [DllImport("box2d", EntryPoint = "b2CreateFilterJoint")]
    private static extern JointId CreateFilterJoint(WorldId worldId, ref FilterJointDef def);

    #endregion
}
