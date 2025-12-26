using System.Numerics;
using Box2D.Id;

namespace Box2D.Types.Callbacks;

public readonly unsafe struct PreSolveFcn(delegate*<ShapeId, ShapeId, Vector2, Vector2, void*, bool> ptr)
{
    private readonly delegate*<ShapeId, ShapeId, Vector2, Vector2, void*, bool> _ptr = ptr;

    public static implicit operator PreSolveFcn(delegate*<ShapeId, ShapeId, Vector2, Vector2, void*, bool> ptr) => new PreSolveFcn(ptr);

    public static implicit operator delegate*<ShapeId, ShapeId, Vector2, Vector2, void*, bool>(PreSolveFcn callback) => callback._ptr;
    
    public bool Invoke(ShapeId shapeIdA, ShapeId shapeIdB, Vector2 point, Vector2 normal, void* context) => _ptr(shapeIdA, shapeIdB, point, normal, context);
}