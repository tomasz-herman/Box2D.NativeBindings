namespace Box2D.Types.Callbacks;

public readonly unsafe struct FrictionCallback(delegate*<float, ulong, float, ulong, float> ptr)
{
    private readonly delegate*<float, ulong, float, ulong, float> _ptr = ptr;

    public static implicit operator FrictionCallback(delegate*<float, ulong, float, ulong, float> ptr) => new FrictionCallback(ptr);

    public static implicit operator delegate*<float, ulong, float, ulong, float>(FrictionCallback callback) => callback._ptr;
    
    public float Invoke(float frictionA, ulong userMaterialIdA, float frictionB, ulong userMaterialIdB) => _ptr(frictionA, userMaterialIdA, frictionB, userMaterialIdB);
}