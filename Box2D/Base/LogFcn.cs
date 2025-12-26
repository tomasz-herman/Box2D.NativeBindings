namespace Box2D.Base;

public unsafe struct LogFcn(delegate*<byte*, void> ptr)
{
    private readonly delegate*<byte*, void> _ptr = ptr;

    public static implicit operator LogFcn(delegate*<byte*, void> ptr) => new LogFcn(ptr);

    public static implicit operator delegate*<byte*, void>(LogFcn fcn) => fcn._ptr;
    
    public void Invoke(byte* message) => _ptr(message);
}