using Box2D.Collision;
using Box2D.Id;

namespace Box2D.Types;

public struct ContactData
{
    public ShapeId ShapeIdA;
    public ShapeId ShapeIdB;
    public Manifold Manifold;
}