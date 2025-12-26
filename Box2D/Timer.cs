using System.Runtime.InteropServices;

namespace Box2D;

public unsafe struct Timer
{
    private ulong _start;

    public static Timer Create()
    {
        return new Timer { _start = GetTicks() };
    }

    public float GetMilliseconds()
    {
        return GetMilliseconds(_start);
    }

    public float GetMillisecondsAndReset()
    {
        fixed (ulong* ptr = &_start)
        {
            return GetMillisecondsAndReset(ptr);
        }
    }
    
    [DllImport("box2d", EntryPoint = "b2GetTicks")]
    public static extern ulong GetTicks();

    [DllImport("box2d", EntryPoint = "b2GetMilliseconds")]
    public static extern float GetMilliseconds(ulong ticks);

    [DllImport("box2d", EntryPoint = "b2GetMillisecondsAndReset")]
    public static extern float GetMillisecondsAndReset(ulong* ticks);
}
