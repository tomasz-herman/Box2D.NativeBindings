using System.Numerics;
using System.Runtime.InteropServices;
using Box2D.Types.Callbacks;

namespace Box2D.Types;

public unsafe struct WorldDef
{
	public Vector2 Gravity;
	public float RestitutionThreshold;
	public float HitEventThreshold;
	public float ContactHertz;
	public float ContactDampingRatio;
	public float ContactSpeed;
	public float MaximumLinearSpeed;
	public FrictionCallback FrictionCallback;
	public RestitutionCallback RestitutionCallback;
	[MarshalAs(UnmanagedType.U1)] 
	public bool EnableSleep;
	[MarshalAs(UnmanagedType.U1)] 
	public bool EnableContinuous;
	public int WorkerCount;
	public EnqueueTaskCallback EnqueueTask;
	public FinishTaskCallback FinishTask;
	public void* UserTaskContext;
	public void* UserData;
	public int InternalValue;

	[DllImport("box2d", EntryPoint = "b2DefaultWorldDef")]
	public static extern WorldDef Default();
}