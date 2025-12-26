using Box2D.Id;

namespace Box2D.Types.Callbacks;

public readonly unsafe struct CustomFilterFcn(delegate*<ShapeId, ShapeId, void*, bool> ptr)
{
    private readonly delegate*<ShapeId, ShapeId, void*, bool> _ptr = ptr;

    public static implicit operator CustomFilterFcn(delegate*<ShapeId, ShapeId, void*, bool> ptr) => new CustomFilterFcn(ptr);

    public static implicit operator delegate*<ShapeId, ShapeId, void*, bool>(CustomFilterFcn callback) => callback._ptr;
    
    public bool Invoke(ShapeId shapeA, ShapeId shapeB, void* context) => _ptr(shapeA, shapeB, context);
}