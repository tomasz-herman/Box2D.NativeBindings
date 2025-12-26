using System.Runtime.InteropServices;
using Box2D.Id;
using Box2D.Types.Shapes;

namespace Box2D;

public unsafe class ChainShape : IDisposable
{
    private readonly ChainId _id;
    private bool _disposed;

    public ChainShape(BodyId bodyId, ref ChainDef def)
    {
        _id = CreateChain(bodyId, ref def);
    }

    public bool IsValid()
    {
        return Chain_IsValid(_id);
    }

    public WorldId GetWorld()
    {
        return Chain_GetWorld(_id);
    }

    public int GetSegmentCount()
    {
        return Chain_GetSegmentCount(_id);
    }

    public int GetSegments(ShapeId* segmentArray, int capacity)
    {
        return Chain_GetSegments(_id, segmentArray, capacity);
    }

    public int GetSurfaceMaterialCount()
    {
        return Chain_GetSurfaceMaterialCount(_id);
    }

    public void SetSurfaceMaterial(ref SurfaceMaterial material, int materialIndex)
    {
        Chain_SetSurfaceMaterial(_id, ref material, materialIndex);
    }

    public SurfaceMaterial GetSurfaceMaterial(int materialIndex)
    {
        return Chain_GetSurfaceMaterial(_id, materialIndex);
    }

    #region NativeFunctions

    [DllImport("box2d", EntryPoint = "b2CreateChain")]
    private static extern ChainId CreateChain(BodyId bodyId, ref ChainDef def);

    [DllImport("box2d", EntryPoint = "b2DestroyChain")]
    private static extern void DestroyChain(ChainId chainId);

    [DllImport("box2d", EntryPoint = "b2Chain_GetWorld")]
    private static extern WorldId Chain_GetWorld(ChainId chainId);

    [DllImport("box2d", EntryPoint = "b2Chain_GetSegmentCount")]
    private static extern int Chain_GetSegmentCount(ChainId chainId);

    [DllImport("box2d", EntryPoint = "b2Chain_GetSegments")]
    private static extern int Chain_GetSegments(ChainId chainId, ShapeId* segmentArray, int capacity);

    [DllImport("box2d", EntryPoint = "b2Chain_GetSurfaceMaterialCount")]
    private static extern int Chain_GetSurfaceMaterialCount(ChainId chainId);

    [DllImport("box2d", EntryPoint = "b2Chain_SetSurfaceMaterial")]
    private static extern void Chain_SetSurfaceMaterial(ChainId chainId, ref SurfaceMaterial material, int materialIndex);

    [DllImport("box2d", EntryPoint = "b2Chain_GetSurfaceMaterial")]
    private static extern SurfaceMaterial Chain_GetSurfaceMaterial(ChainId chainId, int materialIndex);

    [DllImport("box2d", EntryPoint = "b2Chain_IsValid")]
    [return: MarshalAs(UnmanagedType.U1)]
    private static extern bool Chain_IsValid(ChainId id);

    #endregion

    #region DisposePattern

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool _)
    {
        if (_disposed)
        {
            return;
        }

        if (IsValid())
        {
            DestroyChain(_id);
        }

        _disposed = true;
    }

    ~ChainShape() => Dispose(false);

    #endregion
}
