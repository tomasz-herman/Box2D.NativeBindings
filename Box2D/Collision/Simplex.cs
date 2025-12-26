using System.Runtime.InteropServices;

namespace Box2D.Collision;

public unsafe struct Simplex
{
    public SimplexVertex V1, V2, V3;
    public int Count;

    [DllImport("box2d", EntryPoint = "b2ShapeDistance")]
    public static extern DistanceOutput ShapeDistance(ref DistanceInput input, ref SimplexCache cache,
        Simplex[]? simplexes = null, int simplexCapacity = 0);
}