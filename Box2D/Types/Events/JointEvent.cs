using Box2D.Id;

namespace Box2D.Types.Events;

public unsafe struct JointEvent
{
    public JointId JointId;
    public void* UserData;
}