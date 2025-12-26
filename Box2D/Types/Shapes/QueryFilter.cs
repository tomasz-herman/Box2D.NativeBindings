using System.Runtime.InteropServices;

namespace Box2D.Types.Shapes;

public struct QueryFilter
{
    public ulong CategoryBits;
    public ulong MaskBits;
    
    [DllImport("box2d", EntryPoint = "b2DefaultQueryFilter")]
    public static extern QueryFilter Default();
}