namespace Box2D.Types.Callbacks;

public readonly unsafe struct RestitutionCallback(delegate*<float, ulong, float, ulong, float> ptr)
{
    private readonly delegate*<float, ulong, float, ulong, float> _ptr = ptr;

    public static implicit operator RestitutionCallback(delegate*<float, ulong, float, ulong, float> ptr) => new RestitutionCallback(ptr);

    public static implicit operator delegate*<float, ulong, float, ulong, float>(RestitutionCallback callback) => callback._ptr;
    
    public float Invoke(float restitutionA, ulong userMaterialIdA, float restitutionB, ulong userMaterialIdB) => _ptr(restitutionA, userMaterialIdA, restitutionB, userMaterialIdB);
}