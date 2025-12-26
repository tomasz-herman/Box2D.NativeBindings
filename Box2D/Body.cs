using System.Numerics;
using System.Runtime.InteropServices;
using Box2D.Collision;
using Box2D.Id;
using Box2D.Math;
using Box2D.Types;
using Box2D.Types.Bodies;

namespace Box2D;

public unsafe class Body
{
    private readonly BodyId _id;
    public BodyId Id => _id;

    private bool _disposed;

    public Body(WorldId worldId, ref BodyDef def)
    {
        _id = CreateBody(worldId, ref def);
    }

    private void DestroyBody()
    {
        DestroyBody(_id);
    }

    public bool IsValid()
    {
        return Body_IsValid(_id);
    }

    public new BodyType GetType()
    {
        return Body_GetType(_id);
    }

    public void SetType(BodyType type)
    {
        Body_SetType(_id, type);
    }

    public void SetName(string name)
    {
        var ptr = Marshal.StringToHGlobalAnsi(name);
        try
        {
            Body_SetName(_id, (byte*)ptr);
        }
        finally
        {
            Marshal.FreeHGlobal(ptr);
        }
    }

    public string? GetName()
    {
        return Marshal.PtrToStringAnsi((IntPtr)Body_GetName(_id));
    }

    public void SetUserData(void* userData)
    {
        Body_SetUserData(_id, userData);
    }

    public void* GetUserData()
    {
        return Body_GetUserData(_id);
    }

    public Vector2 GetPosition()
    {
        return Body_GetPosition(_id);
    }

    public Rotation GetRotation()
    {
        return Body_GetRotation(_id);
    }

    public Transform GetTransform()
    {
        return Body_GetTransform(_id);
    }

    public void SetTransform(Vector2 position, Rotation rotation)
    {
        Body_SetTransform(_id, position, rotation);
    }

    public Vector2 GetLocalPoint(Vector2 worldPoint)
    {
        return Body_GetLocalPoint(_id, worldPoint);
    }

    public Vector2 GetWorldPoint(Vector2 localPoint)
    {
        return Body_GetWorldPoint(_id, localPoint);
    }

    public Vector2 GetLocalVector(Vector2 worldVector)
    {
        return Body_GetLocalVector(_id, worldVector);
    }

    public Vector2 GetWorldVector(Vector2 localVector)
    {
        return Body_GetWorldVector(_id, localVector);
    }

    public Vector2 GetLinearVelocity()
    {
        return Body_GetLinearVelocity(_id);
    }

    public float GetAngularVelocity()
    {
        return Body_GetAngularVelocity(_id);
    }

    public void SetLinearVelocity(Vector2 linearVelocity)
    {
        Body_SetLinearVelocity(_id, linearVelocity);
    }

    public void SetAngularVelocity(float angularVelocity)
    {
        Body_SetAngularVelocity(_id, angularVelocity);
    }

    public void SetTargetTransform(Transform target, float timeStep, bool wake)
    {
        Body_SetTargetTransform(_id, target, timeStep, wake);
    }

    public Vector2 GetLocalPointVelocity(Vector2 localPoint)
    {
        return Body_GetLocalPointVelocity(_id, localPoint);
    }

    public Vector2 GetWorldPointVelocity(Vector2 worldPoint)
    {
        return Body_GetWorldPointVelocity(_id, worldPoint);
    }

    public void ApplyForce(Vector2 force, Vector2 point, bool wake)
    {
        Body_ApplyForce(_id, force, point, wake);
    }

    public void ApplyForceToCenter(Vector2 force, bool wake)
    {
        Body_ApplyForceToCenter(_id, force, wake);
    }

    public void ApplyTorque(float torque, bool wake)
    {
        Body_ApplyTorque(_id, torque, wake);
    }

    public void ClearForces()
    {
        Body_ClearForces(_id);
    }

    public void ApplyLinearImpulse(Vector2 impulse, Vector2 point, bool wake)
    {
        Body_ApplyLinearImpulse(_id, impulse, point, wake);
    }

    public void ApplyLinearImpulseToCenter(Vector2 impulse, bool wake)
    {
        Body_ApplyLinearImpulseToCenter(_id, impulse, wake);
    }

    public void ApplyAngularImpulse(float impulse, bool wake)
    {
        Body_ApplyAngularImpulse(_id, impulse, wake);
    }

    public float GetMass()
    {
        return Body_GetMass(_id);
    }

    public float GetRotationalInertia()
    {
        return Body_GetRotationalInertia(_id);
    }

    public Vector2 GetLocalCenterOfMass()
    {
        return Body_GetLocalCenterOfMass(_id);
    }

    public Vector2 GetWorldCenterOfMass()
    {
        return Body_GetWorldCenterOfMass(_id);
    }

    public void SetMassData(MassData massData)
    {
        Body_SetMassData(_id, massData);
    }

    public MassData GetMassData()
    {
        return Body_GetMassData(_id);
    }

    public void ApplyMassFromShapes()
    {
        Body_ApplyMassFromShapes(_id);
    }

    public void SetLinearDamping(float linearDamping)
    {
        Body_SetLinearDamping(_id, linearDamping);
    }

    public float GetLinearDamping()
    {
        return Body_GetLinearDamping(_id);
    }

    public void SetAngularDamping(float angularDamping)
    {
        Body_SetAngularDamping(_id, angularDamping);
    }

    public float GetAngularDamping()
    {
        return Body_GetAngularDamping(_id);
    }

    public void SetGravityScale(float gravityScale)
    {
        Body_SetGravityScale(_id, gravityScale);
    }

    public float GetGravityScale()
    {
        return Body_GetGravityScale(_id);
    }

    public bool IsAwake()
    {
        return Body_IsAwake(_id);
    }

    public void SetAwake(bool awake)
    {
        Body_SetAwake(_id, awake);
    }

    public void WakeTouching()
    {
        Body_WakeTouching(_id);
    }

    public void EnableSleep(bool enableSleep)
    {
        Body_EnableSleep(_id, enableSleep);
    }

    public bool IsSleepEnabled()
    {
        return Body_IsSleepEnabled(_id);
    }

    public void SetSleepThreshold(float sleepThreshold)
    {
        Body_SetSleepThreshold(_id, sleepThreshold);
    }

    public float GetSleepThreshold()
    {
        return Body_GetSleepThreshold(_id);
    }

    public bool IsEnabled()
    {
        return Body_IsEnabled(_id);
    }

    public void Disable()
    {
        Body_Disable(_id);
    }

    public void Enable()
    {
        Body_Enable(_id);
    }

    public void SetFixedRotation(bool flag)
    {
        Body_SetFixedRotation(_id, flag);
    }

    public bool IsFixedRotation()
    {
        return Body_IsFixedRotation(_id);
    }

    public void SetBullet(bool flag)
    {
        Body_SetBullet(_id, flag);
    }

    public bool IsBullet()
    {
        return Body_IsBullet(_id);
    }

    public void EnableContactEvents(bool flag)
    {
        Body_EnableContactEvents(_id, flag);
    }

    public void EnableHitEvents(bool flag)
    {
        Body_EnableHitEvents(_id, flag);
    }

    public WorldId GetWorld()
    {
        return Body_GetWorld(_id);
    }

    public int GetShapeCount()
    {
        return Body_GetShapeCount(_id);
    }

    public int GetShapes(ShapeId* shapeArray, int capacity)
    {
        return Body_GetShapes(_id, shapeArray, capacity);
    }

    public int GetJointCount()
    {
        return Body_GetJointCount(_id);
    }

    public int GetJoints(JointId* jointArray, int capacity)
    {
        return Body_GetJoints(_id, jointArray, capacity);
    }

    public int GetContactCapacity()
    {
        return Body_GetContactCapacity(_id);
    }

    public int GetContactData(ContactData* contactData, int capacity)
    {
        return Body_GetContactData(_id, contactData, capacity);
    }

    public Aabb ComputeAABB()
    {
        return Body_ComputeAABB(_id);
    }

    #region NativeFunctions

    [DllImport("box2d", EntryPoint = "b2CreateBody")]
    private static extern BodyId CreateBody(WorldId worldId, ref BodyDef def);

    [DllImport("box2d", EntryPoint = "b2DestroyBody")]
    private static extern void DestroyBody(BodyId bodyId);

    [DllImport("box2d", EntryPoint = "b2Body_IsValid")]
    [return: MarshalAs(UnmanagedType.U1)]
    private static extern bool Body_IsValid(BodyId id);

    [DllImport("box2d", EntryPoint = "b2Body_GetType")]
    private static extern BodyType Body_GetType(BodyId bodyId);

    [DllImport("box2d", EntryPoint = "b2Body_SetType")]
    private static extern void Body_SetType(BodyId bodyId, BodyType type);

    [DllImport("box2d", EntryPoint = "b2Body_SetName")]
    private static extern void Body_SetName(BodyId bodyId, byte* name);

    [DllImport("box2d", EntryPoint = "b2Body_GetName")]
    private static extern byte* Body_GetName(BodyId bodyId);

    [DllImport("box2d", EntryPoint = "b2Body_SetUserData")]
    private static extern void Body_SetUserData(BodyId bodyId, void* userData);

    [DllImport("box2d", EntryPoint = "b2Body_GetUserData")]
    private static extern void* Body_GetUserData(BodyId bodyId);

    [DllImport("box2d", EntryPoint = "b2Body_GetPosition")]
    private static extern Vector2 Body_GetPosition(BodyId bodyId);

    [DllImport("box2d", EntryPoint = "b2Body_GetRotation")]
    private static extern Rotation Body_GetRotation(BodyId bodyId);

    [DllImport("box2d", EntryPoint = "b2Body_GetTransform")]
    private static extern Transform Body_GetTransform(BodyId bodyId);

    [DllImport("box2d", EntryPoint = "b2Body_SetTransform")]
    private static extern void Body_SetTransform(BodyId bodyId, Vector2 position, Rotation rotation);

    [DllImport("box2d", EntryPoint = "b2Body_GetLocalPoint")]
    private static extern Vector2 Body_GetLocalPoint(BodyId bodyId, Vector2 worldPoint);

    [DllImport("box2d", EntryPoint = "b2Body_GetWorldPoint")]
    private static extern Vector2 Body_GetWorldPoint(BodyId bodyId, Vector2 localPoint);

    [DllImport("box2d", EntryPoint = "b2Body_GetLocalVector")]
    private static extern Vector2 Body_GetLocalVector(BodyId bodyId, Vector2 worldVector);

    [DllImport("box2d", EntryPoint = "b2Body_GetWorldVector")]
    private static extern Vector2 Body_GetWorldVector(BodyId bodyId, Vector2 localVector);

    [DllImport("box2d", EntryPoint = "b2Body_GetLinearVelocity")]
    private static extern Vector2 Body_GetLinearVelocity(BodyId bodyId);

    [DllImport("box2d", EntryPoint = "b2Body_GetAngularVelocity")]
    private static extern float Body_GetAngularVelocity(BodyId bodyId);

    [DllImport("box2d", EntryPoint = "b2Body_SetLinearVelocity")]
    private static extern void Body_SetLinearVelocity(BodyId bodyId, Vector2 linearVelocity);

    [DllImport("box2d", EntryPoint = "b2Body_SetAngularVelocity")]
    private static extern void Body_SetAngularVelocity(BodyId bodyId, float angularVelocity);

    [DllImport("box2d", EntryPoint = "b2Body_SetTargetTransform")]
    private static extern void Body_SetTargetTransform(BodyId bodyId, Transform target, float timeStep,
        [MarshalAs(UnmanagedType.U1)] bool wake);

    [DllImport("box2d", EntryPoint = "b2Body_GetLocalPointVelocity")]
    private static extern Vector2 Body_GetLocalPointVelocity(BodyId bodyId, Vector2 localPoint);

    [DllImport("box2d", EntryPoint = "b2Body_GetWorldPointVelocity")]
    private static extern Vector2 Body_GetWorldPointVelocity(BodyId bodyId, Vector2 worldPoint);

    [DllImport("box2d", EntryPoint = "b2Body_ApplyForce")]
    private static extern void Body_ApplyForce(BodyId bodyId, Vector2 force, Vector2 point,
        [MarshalAs(UnmanagedType.U1)] bool wake);

    [DllImport("box2d", EntryPoint = "b2Body_ApplyForceToCenter")]
    private static extern void Body_ApplyForceToCenter(BodyId bodyId, Vector2 force,
        [MarshalAs(UnmanagedType.U1)] bool wake);

    [DllImport("box2d", EntryPoint = "b2Body_ApplyTorque")]
    private static extern void Body_ApplyTorque(BodyId bodyId, float torque, [MarshalAs(UnmanagedType.U1)] bool wake);

    [DllImport("box2d", EntryPoint = "b2Body_ClearForces")]
    private static extern void Body_ClearForces(BodyId bodyId);

    [DllImport("box2d", EntryPoint = "b2Body_ApplyLinearImpulse")]
    private static extern void Body_ApplyLinearImpulse(BodyId bodyId, Vector2 impulse, Vector2 point,
        [MarshalAs(UnmanagedType.U1)] bool wake);

    [DllImport("box2d", EntryPoint = "b2Body_ApplyLinearImpulseToCenter")]
    private static extern void Body_ApplyLinearImpulseToCenter(BodyId bodyId, Vector2 impulse,
        [MarshalAs(UnmanagedType.U1)] bool wake);

    [DllImport("box2d", EntryPoint = "b2Body_ApplyAngularImpulse")]
    private static extern void Body_ApplyAngularImpulse(BodyId bodyId, float impulse,
        [MarshalAs(UnmanagedType.U1)] bool wake);

    [DllImport("box2d", EntryPoint = "b2Body_GetMass")]
    private static extern float Body_GetMass(BodyId bodyId);

    [DllImport("box2d", EntryPoint = "b2Body_GetRotationalInertia")]
    private static extern float Body_GetRotationalInertia(BodyId bodyId);

    [DllImport("box2d", EntryPoint = "b2Body_GetLocalCenterOfMass")]
    private static extern Vector2 Body_GetLocalCenterOfMass(BodyId bodyId);

    [DllImport("box2d", EntryPoint = "b2Body_GetWorldCenterOfMass")]
    private static extern Vector2 Body_GetWorldCenterOfMass(BodyId bodyId);

    [DllImport("box2d", EntryPoint = "b2Body_SetMassData")]
    private static extern void Body_SetMassData(BodyId bodyId, MassData massData);

    [DllImport("box2d", EntryPoint = "b2Body_GetMassData")]
    private static extern MassData Body_GetMassData(BodyId bodyId);

    [DllImport("box2d", EntryPoint = "b2Body_ApplyMassFromShapes")]
    private static extern void Body_ApplyMassFromShapes(BodyId bodyId);

    [DllImport("box2d", EntryPoint = "b2Body_SetLinearDamping")]
    private static extern void Body_SetLinearDamping(BodyId bodyId, float linearDamping);

    [DllImport("box2d", EntryPoint = "b2Body_GetLinearDamping")]
    private static extern float Body_GetLinearDamping(BodyId bodyId);

    [DllImport("box2d", EntryPoint = "b2Body_SetAngularDamping")]
    private static extern void Body_SetAngularDamping(BodyId bodyId, float angularDamping);

    [DllImport("box2d", EntryPoint = "b2Body_GetAngularDamping")]
    private static extern float Body_GetAngularDamping(BodyId bodyId);

    [DllImport("box2d", EntryPoint = "b2Body_SetGravityScale")]
    private static extern void Body_SetGravityScale(BodyId bodyId, float gravityScale);

    [DllImport("box2d", EntryPoint = "b2Body_GetGravityScale")]
    private static extern float Body_GetGravityScale(BodyId bodyId);

    [DllImport("box2d", EntryPoint = "b2Body_IsAwake")]
    [return: MarshalAs(UnmanagedType.U1)]
    private static extern bool Body_IsAwake(BodyId bodyId);

    [DllImport("box2d", EntryPoint = "b2Body_SetAwake")]
    private static extern void Body_SetAwake(BodyId bodyId, [MarshalAs(UnmanagedType.U1)] bool awake);

    [DllImport("box2d", EntryPoint = "b2Body_WakeTouching")]
    private static extern void Body_WakeTouching(BodyId bodyId);

    [DllImport("box2d", EntryPoint = "b2Body_EnableSleep")]
    private static extern void Body_EnableSleep(BodyId bodyId, [MarshalAs(UnmanagedType.U1)] bool enableSleep);

    [DllImport("box2d", EntryPoint = "b2Body_IsSleepEnabled")]
    [return: MarshalAs(UnmanagedType.U1)]
    private static extern bool Body_IsSleepEnabled(BodyId bodyId);

    [DllImport("box2d", EntryPoint = "b2Body_SetSleepThreshold")]
    private static extern void Body_SetSleepThreshold(BodyId bodyId, float sleepThreshold);

    [DllImport("box2d", EntryPoint = "b2Body_GetSleepThreshold")]
    private static extern float Body_GetSleepThreshold(BodyId bodyId);

    [DllImport("box2d", EntryPoint = "b2Body_IsEnabled")]
    [return: MarshalAs(UnmanagedType.U1)]
    private static extern bool Body_IsEnabled(BodyId bodyId);

    [DllImport("box2d", EntryPoint = "b2Body_Disable")]
    private static extern void Body_Disable(BodyId bodyId);

    [DllImport("box2d", EntryPoint = "b2Body_Enable")]
    private static extern void Body_Enable(BodyId bodyId);

    [DllImport("box2d", EntryPoint = "b2Body_SetFixedRotation")]
    private static extern void Body_SetFixedRotation(BodyId bodyId, [MarshalAs(UnmanagedType.U1)] bool flag);

    [DllImport("box2d", EntryPoint = "b2Body_IsFixedRotation")]
    [return: MarshalAs(UnmanagedType.U1)]
    private static extern bool Body_IsFixedRotation(BodyId bodyId);

    [DllImport("box2d", EntryPoint = "b2Body_SetBullet")]
    private static extern void Body_SetBullet(BodyId bodyId, [MarshalAs(UnmanagedType.U1)] bool flag);

    [DllImport("box2d", EntryPoint = "b2Body_IsBullet")]
    [return: MarshalAs(UnmanagedType.U1)]
    private static extern bool Body_IsBullet(BodyId bodyId);

    [DllImport("box2d", EntryPoint = "b2Body_EnableContactEvents")]
    private static extern void Body_EnableContactEvents(BodyId bodyId, [MarshalAs(UnmanagedType.U1)] bool flag);

    [DllImport("box2d", EntryPoint = "b2Body_EnableHitEvents")]
    private static extern void Body_EnableHitEvents(BodyId bodyId, [MarshalAs(UnmanagedType.U1)] bool flag);

    [DllImport("box2d", EntryPoint = "b2Body_GetWorld")]
    private static extern WorldId Body_GetWorld(BodyId bodyId);

    [DllImport("box2d", EntryPoint = "b2Body_GetShapeCount")]
    private static extern int Body_GetShapeCount(BodyId bodyId);

    [DllImport("box2d", EntryPoint = "b2Body_GetShapes")]
    private static extern int Body_GetShapes(BodyId bodyId, ShapeId* shapeArray, int capacity);

    [DllImport("box2d", EntryPoint = "b2Body_GetJointCount")]
    private static extern int Body_GetJointCount(BodyId bodyId);

    [DllImport("box2d", EntryPoint = "b2Body_GetJoints")]
    private static extern int Body_GetJoints(BodyId bodyId, JointId* jointArray, int capacity);

    [DllImport("box2d", EntryPoint = "b2Body_GetContactCapacity")]
    private static extern int Body_GetContactCapacity(BodyId bodyId);

    [DllImport("box2d", EntryPoint = "b2Body_GetContactData")]
    private static extern int Body_GetContactData(BodyId bodyId, ContactData* contactData, int capacity);

    [DllImport("box2d", EntryPoint = "b2Body_ComputeAABB")]
    private static extern Aabb Body_ComputeAABB(BodyId bodyId);

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
            DestroyBody(_id);
        }

        _disposed = true;
    }

    ~Body() => Dispose(false);

    #endregion
}