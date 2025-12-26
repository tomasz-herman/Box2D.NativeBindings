using System.Numerics;
using System.Runtime.InteropServices;
using Box2D.Collision;
using Box2D.Id;
using Box2D.Types;
using Box2D.Types.Callbacks;
using Box2D.Types.Events;
using Box2D.Types.Shapes;

namespace Box2D;

public unsafe class World : IDisposable
{
    private readonly WorldId _id;
    public WorldId Id => _id;

    private bool _disposed;

    public World(ref WorldDef worldDef)
    {
        _id = CreateWorld(ref worldDef);
    }

    public bool IsValid()
    {
        return World_IsValid(_id);
    }

    public void Step(float timeStep = 1.0f / 60.0f, int subStepCount = 4)
    {
        World_Step(_id, timeStep, subStepCount);
    }

    public void Draw(ref DebugDraw draw)
    {
        World_Draw(_id, ref draw);
    }

    public BodyEvents GetBodyEvents()
    {
        return World_GetBodyEvents(_id);
    }

    public SensorEvents GetSensorEvents()
    {
        return World_GetSensorEvents(_id);
    }

    public ContactEvents GetContactEvents()
    {
        return World_GetContactEvents(_id);
    }

    public JointEvents GetJointEvents()
    {
        return World_GetJointEvents(_id);
    }

    public TreeStats CastRay(Vector2 origin, Vector2 translation,
        QueryFilter filter,
        CastResultFcn fcn, void* context)
    {
        return World_CastRay(_id, origin, translation, filter, fcn, context);
    }

    public RayResult CastRayClosest(Vector2 origin, Vector2 translation,
        QueryFilter filter)
    {
        return World_CastRayClosest(_id, origin, translation, filter);
    }

    public TreeStats CastShape(ref ShapeProxy proxy, Vector2 translation,
        QueryFilter filter,
        CastResultFcn fcn, void* context)
    {
        return World_CastShape(_id, ref proxy, translation, filter, fcn, context);
    }

    public float CastMover(ref Capsule mover, Vector2 translation,
        QueryFilter filter)
    {
        return World_CastMover(_id, ref mover, translation, filter);
    }

    public void CollideMover(ref Capsule mover, QueryFilter filter,
        PlaneResultFcn fcn,
        void* context)
    {
        World_CollideMover(_id, ref mover, filter, fcn, context);
    }

    public void EnableSleeping(bool flag)
    {
        World_EnableSleeping(_id, flag);
    }

    public bool IsSleepingEnabled()
    {
        return World_IsSleepingEnabled(_id);
    }

    public void EnableContinuous(bool flag)
    {
        World_EnableContinuous(_id, flag);
    }

    public bool IsContinuousEnabled()
    {
        return World_IsContinuousEnabled(_id);
    }

    public void SetRestitutionThreshold(float value)
    {
        World_SetRestitutionThreshold(_id, value);
    }

    public float GetRestitutionThreshold()
    {
        return World_GetRestitutionThreshold(_id);
    }

    public void SetHitEventThreshold(float value)
    {
        World_SetHitEventThreshold(_id, value);
    }

    public float GetHitEventThreshold()
    {
        return World_GetHitEventThreshold(_id);
    }

    public void SetCustomFilterCallback(CustomFilterFcn fcn, void* context)
    {
        World_SetCustomFilterCallback(_id, fcn, context);
    }

    public void SetPreSolveCallback(PreSolveFcn fcn, void* context)
    {
        World_SetPreSolveCallback(_id, fcn, context);
    }

    public void SetGravity(Vector2 gravity)
    {
        World_SetGravity(_id, gravity);
    }

    public Vector2 GetGravity()
    {
        return World_GetGravity(_id);
    }

    public void Explode(ref ExplosionDef explosionDef)
    {
        World_Explode(_id, ref explosionDef);
    }

    public void SetContactTuning(float hertz, float dampingRatio, float pushSpeed)
    {
        World_SetContactTuning(_id, hertz, dampingRatio, pushSpeed);
    }

    public void SetMaximumLinearSpeed(float maximumLinearSpeed)
    {
        World_SetMaximumLinearSpeed(_id, maximumLinearSpeed);
    }

    public float GetMaximumLinearSpeed()
    {
        return World_GetMaximumLinearSpeed(_id);
    }

    public void EnableWarmStarting(bool flag)
    {
        World_EnableWarmStarting(_id, flag);
    }

    public bool IsWarmStartingEnabled()
    {
        return World_IsWarmStartingEnabled(_id);
    }

    public int GetAwakeBodyCount()
    {
        return World_GetAwakeBodyCount(_id);
    }

    public Profile GetProfile()
    {
        return World_GetProfile(_id);
    }

    public Counters GetCounters()
    {
        return World_GetCounters(_id);
    }

    public void SetUserData(void* userData)
    {
        World_SetUserData(_id, userData);
    }

    public void* GetUserData()
    {
        return World_GetUserData(_id);
    }

    public void SetFrictionCallback(FrictionCallback callback)
    {
        World_SetFrictionCallback(_id, callback);
    }

    public void SetRestitutionCallback(RestitutionCallback callback)
    {
        World_SetRestitutionCallback(_id, callback);
    }

    public void DumpMemoryStats()
    {
        World_DumpMemoryStats(_id);
    }

    public void RebuildStaticTree()
    {
        World_RebuildStaticTree(_id);
    }

    public void EnableSpeculative(bool flag)
    {
        World_EnableSpeculative(_id, flag);
    }

    #region NativeFunctions
    [DllImport("box2d", EntryPoint = "b2CreateWorld")]
    private static extern WorldId CreateWorld(ref WorldDef def);

    [DllImport("box2d", EntryPoint = "b2DestroyWorld")]
    private static extern void DestroyWorld(WorldId id);

    [DllImport("box2d", EntryPoint = "b2World_IsValid")]
    [return: MarshalAs(UnmanagedType.U1)]
    private static extern bool World_IsValid(WorldId id);

    [DllImport("box2d", EntryPoint = "b2World_Step")]
    private static extern void World_Step(WorldId id, float timeStep, int subStepCount);

    [DllImport("box2d", EntryPoint = "b2World_Step")]
    private static extern void World_Draw(WorldId id, ref DebugDraw draw);

    [DllImport("box2d", EntryPoint = "b2World_GetBodyEvents")]
    private static extern BodyEvents World_GetBodyEvents(WorldId id);

    [DllImport("box2d", EntryPoint = "b2World_GetSensorEvents")]
    private static extern SensorEvents World_GetSensorEvents(WorldId id);

    [DllImport("box2d", EntryPoint = "b2World_GetContactEvents")]
    private static extern ContactEvents World_GetContactEvents(WorldId id);

    [DllImport("box2d", EntryPoint = "b2World_GetJointEvents")]
    private static extern JointEvents World_GetJointEvents(WorldId id);

    [DllImport("box2d", EntryPoint = "b2World_CastRay")]
    private static extern TreeStats World_CastRay(WorldId worldId, Vector2 origin, Vector2 translation,
        QueryFilter filter,
        CastResultFcn fcn, void* context);

    [DllImport("box2d", EntryPoint = "b2World_CastRayClosest")]
    private static extern RayResult World_CastRayClosest(WorldId worldId, Vector2 origin, Vector2 translation,
        QueryFilter filter);

    [DllImport("box2d", EntryPoint = "b2World_CastShape")]
    private static extern TreeStats World_CastShape(WorldId worldId, ref ShapeProxy proxy, Vector2 translation,
        QueryFilter filter,
        CastResultFcn fcn, void* context);

    [DllImport("box2d", EntryPoint = "b2World_CastMover")]
    private static extern float World_CastMover(WorldId worldId, ref Capsule mover, Vector2 translation,
        QueryFilter filter);

    [DllImport("box2d", EntryPoint = "b2World_CollideMover")]
    private static extern void World_CollideMover(WorldId worldId, ref Capsule mover, QueryFilter filter,
        PlaneResultFcn fcn,
        void* context);

    [DllImport("box2d", EntryPoint = "b2World_EnableSleeping")]
    private static extern void World_EnableSleeping(WorldId worldId, [MarshalAs(UnmanagedType.U1)] bool flag);

    [DllImport("box2d", EntryPoint = "b2World_IsSleepingEnabled")]
    [return: MarshalAs(UnmanagedType.U1)]
    private static extern bool World_IsSleepingEnabled(WorldId worldId);

    [DllImport("box2d", EntryPoint = "b2World_EnableContinuous")]
    private static extern void World_EnableContinuous(WorldId worldId, [MarshalAs(UnmanagedType.U1)] bool flag);

    [DllImport("box2d", EntryPoint = "b2World_IsContinuousEnabled")]
    [return: MarshalAs(UnmanagedType.U1)]
    private static extern bool World_IsContinuousEnabled(WorldId worldId);

    [DllImport("box2d", EntryPoint = "b2World_SetRestitutionThreshold")]
    private static extern void World_SetRestitutionThreshold(WorldId worldId, float value);

    [DllImport("box2d", EntryPoint = "b2World_GetRestitutionThreshold")]
    private static extern float World_GetRestitutionThreshold(WorldId worldId);

    [DllImport("box2d", EntryPoint = "b2World_SetHitEventThreshold")]
    private static extern void World_SetHitEventThreshold(WorldId worldId, float value);

    [DllImport("box2d", EntryPoint = "b2World_GetHitEventThreshold")]
    private static extern float World_GetHitEventThreshold(WorldId worldId);

    [DllImport("box2d", EntryPoint = "b2World_SetCustomFilterCallback")]
    private static extern void World_SetCustomFilterCallback(WorldId worldId, CustomFilterFcn fcn, void* context);

    [DllImport("box2d", EntryPoint = "b2World_SetPreSolveCallback")]
    private static extern void World_SetPreSolveCallback(WorldId worldId, PreSolveFcn fcn, void* context);

    [DllImport("box2d", EntryPoint = "b2World_SetGravity")]
    private static extern void World_SetGravity(WorldId worldId, Vector2 gravity);

    [DllImport("box2d", EntryPoint = "b2World_GetGravity")]
    private static extern Vector2 World_GetGravity(WorldId worldId);

    [DllImport("box2d", EntryPoint = "b2World_Explode")]
    private static extern void World_Explode(WorldId worldId, ref ExplosionDef explosionDef);

    [DllImport("box2d", EntryPoint = "b2World_SetContactTuning")]
    private static extern void World_SetContactTuning(WorldId worldId, float hertz, float dampingRatio,
        float pushSpeed);

    [DllImport("box2d", EntryPoint = "b2World_SetMaximumLinearSpeed")]
    private static extern void World_SetMaximumLinearSpeed(WorldId worldId, float maximumLinearSpeed);

    [DllImport("box2d", EntryPoint = "b2World_GetMaximumLinearSpeed")]
    private static extern float World_GetMaximumLinearSpeed(WorldId worldId);

    [DllImport("box2d", EntryPoint = "b2World_EnableWarmStarting")]
    private static extern void World_EnableWarmStarting(WorldId worldId, [MarshalAs(UnmanagedType.U1)] bool flag);

    [DllImport("box2d", EntryPoint = "b2World_IsWarmStartingEnabled")]
    [return: MarshalAs(UnmanagedType.U1)]
    private static extern bool World_IsWarmStartingEnabled(WorldId worldId);

    [DllImport("box2d", EntryPoint = "b2World_GetAwakeBodyCount")]
    private static extern int World_GetAwakeBodyCount(WorldId worldId);

    [DllImport("box2d", EntryPoint = "b2World_GetProfile")]
    private static extern Profile World_GetProfile(WorldId worldId);

    [DllImport("box2d", EntryPoint = "b2World_GetCounters")]
    private static extern Counters World_GetCounters(WorldId worldId);

    [DllImport("box2d", EntryPoint = "b2World_SetUserData")]
    private static extern void World_SetUserData(WorldId worldId, void* userData);

    [DllImport("box2d", EntryPoint = "b2World_GetUserData")]
    private static extern void* World_GetUserData(WorldId worldId);

    [DllImport("box2d", EntryPoint = "b2World_SetFrictionCallback")]
    private static extern void World_SetFrictionCallback(WorldId worldId, FrictionCallback callback);

    [DllImport("box2d", EntryPoint = "b2World_SetRestitutionCallback")]
    private static extern void World_SetRestitutionCallback(WorldId worldId, RestitutionCallback callback);

    [DllImport("box2d", EntryPoint = "b2World_DumpMemoryStats")]
    private static extern void World_DumpMemoryStats(WorldId worldId);

    [DllImport("box2d", EntryPoint = "b2World_RebuildStaticTree")]
    private static extern void World_RebuildStaticTree(WorldId worldId);

    [DllImport("box2d", EntryPoint = "b2World_EnableSpeculative")]
    private static extern void World_EnableSpeculative(WorldId worldId, [MarshalAs(UnmanagedType.U1)] bool flag);

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
            DestroyWorld(_id);
        }

        _disposed = true;
    }

    ~World() => Dispose(false);
    #endregion
}