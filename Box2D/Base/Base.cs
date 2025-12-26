using System.Runtime.InteropServices;

namespace Box2D.Base;

public static unsafe class Base
{
    [DllImport("box2d", EntryPoint = "b2SetAllocator")]
    public static extern void SetAllocator(AllocFcn allocFcn, FreeFcn freeFcn);

    [DllImport("box2d", EntryPoint = "b2GetByteCount")]
    public static extern int GetByteCount();

    [DllImport("box2d", EntryPoint = "b2SetAssertFcn")]
    public static extern void SetAssertFcn(AssertFcn assertFcn);

    [DllImport("box2d", EntryPoint = "b2SetLogFcn")]
    public static extern void SetLogFcn(LogFcn logFcn);

    [DllImport("box2d", EntryPoint = "b2Yield")]
    public static extern void Yield();
    
    [DllImport("box2d", EntryPoint = "b2Hash")]
    public static extern void Hash(uint hash, byte* data, int count);
}