using System.Numerics;
using Box2D.Id;

namespace Box2D.Types.Callbacks;

public readonly unsafe struct CastResultFcn(delegate*<ShapeId, Vector2, Vector2, float, void*, float> ptr)
{
    private readonly delegate*<ShapeId, Vector2, Vector2, float, void*, float> _ptr = ptr;

    public static implicit operator CastResultFcn(delegate*<ShapeId, Vector2, Vector2, float, void*, float> ptr) => new CastResultFcn(ptr);

    public static implicit operator delegate*<ShapeId, Vector2, Vector2, float, void*, float>(CastResultFcn callback) => callback._ptr;
    
    public float Invoke(ShapeId shapeId, Vector2 point, Vector2 normal, float fraction, void* context) => _ptr(shapeId, point, normal, fraction, context);
}