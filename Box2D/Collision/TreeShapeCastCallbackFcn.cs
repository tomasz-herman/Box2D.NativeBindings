namespace Box2D.Collision;

public readonly unsafe struct TreeShapeCastCallbackFcn(delegate*<ShapeCastInput*, int, ulong, void*, float> ptr)
{
    private readonly delegate*<ShapeCastInput*, int, ulong, void*, float> _ptr = ptr;

    public static implicit operator TreeShapeCastCallbackFcn(delegate*<ShapeCastInput*, int, ulong, void*, float> ptr) => new TreeShapeCastCallbackFcn(ptr);

    public static implicit operator delegate*<ShapeCastInput*, int, ulong, void*, float>(TreeShapeCastCallbackFcn callback) => callback._ptr;
    
    public float Invoke(ShapeCastInput* input, int proxyId, ulong userData, void* context) => _ptr(input, proxyId, userData, context);
}