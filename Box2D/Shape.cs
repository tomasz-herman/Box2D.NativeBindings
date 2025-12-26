using System.Numerics;
using System.Runtime.InteropServices;
using Box2D.Collision;
using Box2D.Id;
using Box2D.Types;
using Box2D.Types.Shapes;
using Box2D.Math;

namespace Box2D;

public unsafe class Shape : IDisposable
{
    private readonly ShapeId _id;
    private bool _disposed;

    // Constructors for creating different shape types
    public Shape(BodyId bodyId, ref ShapeDef def, ref Circle circle)
    {
        _id = CreateCircleShape(bodyId, ref def, ref circle);
    }

    public Shape(BodyId bodyId, ref ShapeDef def, ref Segment segment)
    {
        _id = CreateSegmentShape(bodyId, ref def, ref segment);
    }

    public Shape(BodyId bodyId, ref ShapeDef def, ref Capsule capsule)
    {
        _id = CreateCapsuleShape(bodyId, ref def, ref capsule);
    }

    public Shape(BodyId bodyId, ref ShapeDef def, ref Polygon polygon)
    {
        _id = CreatePolygonShape(bodyId, ref def, ref polygon);
    }

    // Constructor for existing shape (e.g. from events)
    public Shape(ShapeId id)
    {
        _id = id;
    }

    public bool IsValid()
    {
        return Shape_IsValid(_id);
    }

    public new ShapeType GetType()
    {
        return Shape_GetType(_id);
    }

    public BodyId GetBody()
    {
        return Shape_GetBody(_id);
    }

    public WorldId GetWorld()
    {
        return Shape_GetWorld(_id);
    }

    public bool IsSensor()
    {
        return Shape_IsSensor(_id);
    }

    public void SetUserData(void* userData)
    {
        Shape_SetUserData(_id, userData);
    }

    public void* GetUserData()
    {
        return Shape_GetUserData(_id);
    }

    public void SetDensity(float density, bool updateBodyMass)
    {
        Shape_SetDensity(_id, density, updateBodyMass);
    }

    public float GetDensity()
    {
        return Shape_GetDensity(_id);
    }

    public void SetFriction(float friction)
    {
        Shape_SetFriction(_id, friction);
    }

    public float GetFriction()
    {
        return Shape_GetFriction(_id);
    }

    public void SetRestitution(float restitution)
    {
        Shape_SetRestitution(_id, restitution);
    }

    public float GetRestitution()
    {
        return Shape_GetRestitution(_id);
    }

    public void SetUserMaterial(ulong material)
    {
        Shape_SetUserMaterial(_id, material);
    }

    public ulong GetUserMaterial()
    {
        return Shape_GetUserMaterial(_id);
    }

    public void SetSurfaceMaterial(ref SurfaceMaterial surfaceMaterial)
    {
        Shape_SetSurfaceMaterial(_id, ref surfaceMaterial);
    }

    public SurfaceMaterial GetSurfaceMaterial()
    {
        return Shape_GetSurfaceMaterial(_id);
    }

    public Filter GetFilter()
    {
        return Shape_GetFilter(_id);
    }

    public void SetFilter(Filter filter)
    {
        Shape_SetFilter(_id, filter);
    }

    public void EnableSensorEvents(bool flag)
    {
        Shape_EnableSensorEvents(_id, flag);
    }

    public bool AreSensorEventsEnabled()
    {
        return Shape_AreSensorEventsEnabled(_id);
    }

    public void EnableContactEvents(bool flag)
    {
        Shape_EnableContactEvents(_id, flag);
    }

    public bool AreContactEventsEnabled()
    {
        return Shape_AreContactEventsEnabled(_id);
    }

    public void EnablePreSolveEvents(bool flag)
    {
        Shape_EnablePreSolveEvents(_id, flag);
    }

    public bool ArePreSolveEventsEnabled()
    {
        return Shape_ArePreSolveEventsEnabled(_id);
    }

    public void EnableHitEvents(bool flag)
    {
        Shape_EnableHitEvents(_id, flag);
    }

    public bool AreHitEventsEnabled()
    {
        return Shape_AreHitEventsEnabled(_id);
    }

    public bool TestPoint(Vector2 point)
    {
        return Shape_TestPoint(_id, point);
    }

    public CastOutput RayCast(ref RayCastInput input)
    {
        return Shape_RayCast(_id, ref input);
    }

    public Circle GetCircle()
    {
        return Shape_GetCircle(_id);
    }

    public Segment GetSegment()
    {
        return Shape_GetSegment(_id);
    }

    public ChainSegment GetChainSegment()
    {
        return Shape_GetChainSegment(_id);
    }

    public Capsule GetCapsule()
    {
        return Shape_GetCapsule(_id);
    }

    public Polygon GetPolygon()
    {
        return Shape_GetPolygon(_id);
    }

    public void SetCircle(ref Circle circle)
    {
        Shape_SetCircle(_id, ref circle);
    }

    public void SetCapsule(ref Capsule capsule)
    {
        Shape_SetCapsule(_id, ref capsule);
    }

    public void SetSegment(ref Segment segment)
    {
        Shape_SetSegment(_id, ref segment);
    }

    public void SetPolygon(ref Polygon polygon)
    {
        Shape_SetPolygon(_id, ref polygon);
    }

    public ChainId GetParentChain()
    {
        return Shape_GetParentChain(_id);
    }

    public int GetContactCapacity()
    {
        return Shape_GetContactCapacity(_id);
    }

    public int GetContactData(ContactData* contactData, int capacity)
    {
        return Shape_GetContactData(_id, contactData, capacity);
    }

    public int GetSensorCapacity()
    {
        return Shape_GetSensorCapacity(_id);
    }

    public int GetSensorData(ShapeId* visitorIds, int capacity)
    {
        return Shape_GetSensorData(_id, visitorIds, capacity);
    }

    public Aabb GetAABB()
    {
        return Shape_GetAabb(_id);
    }

    public MassData ComputeMassData()
    {
        return Shape_ComputeMassData(_id);
    }

    public Vector2 GetClosestPoint(Vector2 target)
    {
        return Shape_GetClosestPoint(_id, target);
    }

    public void ApplyWind(Vector2 wind, float drag, float lift, bool wake)
    {
        Shape_ApplyWind(_id, wind, drag, lift, wake);
    }

    #region NativeFunctions

    [DllImport("box2d", EntryPoint = "b2CreateCircleShape")]
    private static extern ShapeId CreateCircleShape(BodyId bodyId, ref ShapeDef def, ref Circle circle);

    [DllImport("box2d", EntryPoint = "b2CreateSegmentShape")]
    private static extern ShapeId CreateSegmentShape(BodyId bodyId, ref ShapeDef def, ref Segment segment);

    [DllImport("box2d", EntryPoint = "b2CreateCapsuleShape")]
    private static extern ShapeId CreateCapsuleShape(BodyId bodyId, ref ShapeDef def, ref Capsule capsule);

    [DllImport("box2d", EntryPoint = "b2CreatePolygonShape")]
    private static extern ShapeId CreatePolygonShape(BodyId bodyId, ref ShapeDef def, ref Polygon polygon);

    [DllImport("box2d", EntryPoint = "b2DestroyShape")]
    private static extern void DestroyShape(ShapeId shapeId, [MarshalAs(UnmanagedType.U1)] bool updateBodyMass);

    [DllImport("box2d", EntryPoint = "b2Shape_IsValid")]
    [return: MarshalAs(UnmanagedType.U1)]
    private static extern bool Shape_IsValid(ShapeId id);

    [DllImport("box2d", EntryPoint = "b2Shape_GetType")]
    private static extern ShapeType Shape_GetType(ShapeId shapeId);

    [DllImport("box2d", EntryPoint = "b2Shape_GetBody")]
    private static extern BodyId Shape_GetBody(ShapeId shapeId);

    [DllImport("box2d", EntryPoint = "b2Shape_GetWorld")]
    private static extern WorldId Shape_GetWorld(ShapeId shapeId);

    [DllImport("box2d", EntryPoint = "b2Shape_IsSensor")]
    [return: MarshalAs(UnmanagedType.U1)]
    private static extern bool Shape_IsSensor(ShapeId shapeId);

    [DllImport("box2d", EntryPoint = "b2Shape_SetUserData")]
    private static extern void Shape_SetUserData(ShapeId shapeId, void* userData);

    [DllImport("box2d", EntryPoint = "b2Shape_GetUserData")]
    private static extern void* Shape_GetUserData(ShapeId shapeId);

    [DllImport("box2d", EntryPoint = "b2Shape_SetDensity")]
    private static extern void Shape_SetDensity(ShapeId shapeId, float density, [MarshalAs(UnmanagedType.U1)] bool updateBodyMass);

    [DllImport("box2d", EntryPoint = "b2Shape_GetDensity")]
    private static extern float Shape_GetDensity(ShapeId shapeId);

    [DllImport("box2d", EntryPoint = "b2Shape_SetFriction")]
    private static extern void Shape_SetFriction(ShapeId shapeId, float friction);

    [DllImport("box2d", EntryPoint = "b2Shape_GetFriction")]
    private static extern float Shape_GetFriction(ShapeId shapeId);

    [DllImport("box2d", EntryPoint = "b2Shape_SetRestitution")]
    private static extern void Shape_SetRestitution(ShapeId shapeId, float restitution);

    [DllImport("box2d", EntryPoint = "b2Shape_GetRestitution")]
    private static extern float Shape_GetRestitution(ShapeId shapeId);

    [DllImport("box2d", EntryPoint = "b2Shape_SetUserMaterial")]
    private static extern void Shape_SetUserMaterial(ShapeId shapeId, ulong material);

    [DllImport("box2d", EntryPoint = "b2Shape_GetUserMaterial")]
    private static extern ulong Shape_GetUserMaterial(ShapeId shapeId);

    [DllImport("box2d", EntryPoint = "b2Shape_SetSurfaceMaterial")]
    private static extern void Shape_SetSurfaceMaterial(ShapeId shapeId, ref SurfaceMaterial surfaceMaterial);

    [DllImport("box2d", EntryPoint = "b2Shape_GetSurfaceMaterial")]
    private static extern SurfaceMaterial Shape_GetSurfaceMaterial(ShapeId shapeId);

    [DllImport("box2d", EntryPoint = "b2Shape_GetFilter")]
    private static extern Filter Shape_GetFilter(ShapeId shapeId);

    [DllImport("box2d", EntryPoint = "b2Shape_SetFilter")]
    private static extern void Shape_SetFilter(ShapeId shapeId, Filter filter);

    [DllImport("box2d", EntryPoint = "b2Shape_EnableSensorEvents")]
    private static extern void Shape_EnableSensorEvents(ShapeId shapeId, [MarshalAs(UnmanagedType.U1)] bool flag);

    [DllImport("box2d", EntryPoint = "b2Shape_AreSensorEventsEnabled")]
    [return: MarshalAs(UnmanagedType.U1)]
    private static extern bool Shape_AreSensorEventsEnabled(ShapeId shapeId);

    [DllImport("box2d", EntryPoint = "b2Shape_EnableContactEvents")]
    private static extern void Shape_EnableContactEvents(ShapeId shapeId, [MarshalAs(UnmanagedType.U1)] bool flag);

    [DllImport("box2d", EntryPoint = "b2Shape_AreContactEventsEnabled")]
    [return: MarshalAs(UnmanagedType.U1)]
    private static extern bool Shape_AreContactEventsEnabled(ShapeId shapeId);

    [DllImport("box2d", EntryPoint = "b2Shape_EnablePreSolveEvents")]
    private static extern void Shape_EnablePreSolveEvents(ShapeId shapeId, [MarshalAs(UnmanagedType.U1)] bool flag);

    [DllImport("box2d", EntryPoint = "b2Shape_ArePreSolveEventsEnabled")]
    [return: MarshalAs(UnmanagedType.U1)]
    private static extern bool Shape_ArePreSolveEventsEnabled(ShapeId shapeId);

    [DllImport("box2d", EntryPoint = "b2Shape_EnableHitEvents")]
    private static extern void Shape_EnableHitEvents(ShapeId shapeId, [MarshalAs(UnmanagedType.U1)] bool flag);

    [DllImport("box2d", EntryPoint = "b2Shape_AreHitEventsEnabled")]
    [return: MarshalAs(UnmanagedType.U1)]
    private static extern bool Shape_AreHitEventsEnabled(ShapeId shapeId);

    [DllImport("box2d", EntryPoint = "b2Shape_TestPoint")]
    [return: MarshalAs(UnmanagedType.U1)]
    private static extern bool Shape_TestPoint(ShapeId shapeId, Vector2 point);

    [DllImport("box2d", EntryPoint = "b2Shape_RayCast")]
    private static extern CastOutput Shape_RayCast(ShapeId shapeId, ref RayCastInput input);

    [DllImport("box2d", EntryPoint = "b2Shape_GetCircle")]
    private static extern Circle Shape_GetCircle(ShapeId shapeId);

    [DllImport("box2d", EntryPoint = "b2Shape_GetSegment")]
    private static extern Segment Shape_GetSegment(ShapeId shapeId);

    [DllImport("box2d", EntryPoint = "b2Shape_GetChainSegment")]
    private static extern ChainSegment Shape_GetChainSegment(ShapeId shapeId);

    [DllImport("box2d", EntryPoint = "b2Shape_GetCapsule")]
    private static extern Capsule Shape_GetCapsule(ShapeId shapeId);

    [DllImport("box2d", EntryPoint = "b2Shape_GetPolygon")]
    private static extern Polygon Shape_GetPolygon(ShapeId shapeId);

    [DllImport("box2d", EntryPoint = "b2Shape_SetCircle")]
    private static extern void Shape_SetCircle(ShapeId shapeId, ref Circle circle);

    [DllImport("box2d", EntryPoint = "b2Shape_SetCapsule")]
    private static extern void Shape_SetCapsule(ShapeId shapeId, ref Capsule capsule);

    [DllImport("box2d", EntryPoint = "b2Shape_SetSegment")]
    private static extern void Shape_SetSegment(ShapeId shapeId, ref Segment segment);

    [DllImport("box2d", EntryPoint = "b2Shape_SetPolygon")]
    private static extern void Shape_SetPolygon(ShapeId shapeId, ref Polygon polygon);

    [DllImport("box2d", EntryPoint = "b2Shape_GetParentChain")]
    private static extern ChainId Shape_GetParentChain(ShapeId shapeId);

    [DllImport("box2d", EntryPoint = "b2Shape_GetContactCapacity")]
    private static extern int Shape_GetContactCapacity(ShapeId shapeId);

    [DllImport("box2d", EntryPoint = "b2Shape_GetContactData")]
    private static extern int Shape_GetContactData(ShapeId shapeId, ContactData* contactData, int capacity);

    [DllImport("box2d", EntryPoint = "b2Shape_GetSensorCapacity")]
    private static extern int Shape_GetSensorCapacity(ShapeId shapeId);

    [DllImport("box2d", EntryPoint = "b2Shape_GetSensorData")]
    private static extern int Shape_GetSensorData(ShapeId shapeId, ShapeId* visitorIds, int capacity);

    [DllImport("box2d", EntryPoint = "b2Shape_GetAABB")]
    private static extern Aabb Shape_GetAabb(ShapeId shapeId);

    [DllImport("box2d", EntryPoint = "b2Shape_ComputeMassData")]
    private static extern MassData Shape_ComputeMassData(ShapeId shapeId);

    [DllImport("box2d", EntryPoint = "b2Shape_GetClosestPoint")]
    private static extern Vector2 Shape_GetClosestPoint(ShapeId shapeId, Vector2 target);

    [DllImport("box2d", EntryPoint = "b2Shape_ApplyWind")]
    private static extern void Shape_ApplyWind(ShapeId shapeId, Vector2 wind, float drag, float lift, [MarshalAs(UnmanagedType.U1)] bool wake);

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
            DestroyShape(_id, false);
        }

        _disposed = true;
    }

    ~Shape() => Dispose(false);

    public void Destroy(bool updateBodyMass = true)
    {
        if (_disposed) return;
        if (IsValid())
        {
            DestroyShape(_id, updateBodyMass);
        }
        _disposed = true;
        GC.SuppressFinalize(this);
    }

    #endregion
}
