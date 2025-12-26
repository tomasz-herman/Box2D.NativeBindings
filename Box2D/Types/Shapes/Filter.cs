using System.Runtime.InteropServices;

namespace Box2D.Types.Shapes;

public struct Filter
{
    public ulong CategoryBits;
    public ulong MaskBits;
    public int GroupIndex;
    
    [DllImport("box2d", EntryPoint = "b2DefaultFilter")]
    public static extern Filter Default();
}