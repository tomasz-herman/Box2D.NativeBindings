namespace Box2D.Base;

public unsafe struct FreeFcn(delegate*<void*, uint, void> ptr)
{
    private readonly delegate*<void*, uint, void> _ptr = ptr;

    public static implicit operator FreeFcn(delegate*<void*, uint, void> ptr) => new FreeFcn(ptr);

    public static implicit operator delegate*<void*, uint, void>(FreeFcn fcn) => fcn._ptr;
    
    public void Invoke(void* mem, uint size) => _ptr(mem, size);
}