namespace Box2D.Collision;

public readonly unsafe struct TreeRayCastCallbackFcn(delegate*<RayCastInput*, int, ulong, void*, float> ptr)
{
    private readonly delegate*<RayCastInput*, int, ulong, void*, float> _ptr = ptr;

    public static implicit operator TreeRayCastCallbackFcn(delegate*<RayCastInput*, int, ulong, void*, float> ptr) => new TreeRayCastCallbackFcn(ptr);

    public static implicit operator delegate*<RayCastInput*, int, ulong, void*, float>(TreeRayCastCallbackFcn callback) => callback._ptr;
    
    public float Invoke(RayCastInput* input, int proxyId, ulong userData, void* context) => _ptr(input, proxyId, userData, context);
}