using System.Numerics;
using System.Runtime.InteropServices;

namespace Box2D.Types.Shapes;

public unsafe struct ChainDef
{
    public void* UserData;
    public Vector2* Points;
    public int Count;
    public SurfaceMaterial* Materials;
    public int MaterialsCount;
    public Filter Filter;
    [MarshalAs(UnmanagedType.U1)] 
    public bool IsLoop;
    [MarshalAs(UnmanagedType.U1)] 
    public bool EnableSensorEvents;
    private int _internalValue;
    
    [DllImport("box2d", EntryPoint = "b2DefaultChainDef")]
    public static extern ChainDef Default();
}