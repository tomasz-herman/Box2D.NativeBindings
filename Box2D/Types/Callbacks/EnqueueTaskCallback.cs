namespace Box2D.Types.Callbacks;

public readonly unsafe struct EnqueueTaskCallback(delegate*<TaskCallback, int, int, void*, void*, void*> ptr)
{
    private readonly delegate*<TaskCallback, int, int, void*, void*, void*> _ptr = ptr;

    public static implicit operator EnqueueTaskCallback(delegate*<TaskCallback, int, int, void*, void*, void*> ptr) => new EnqueueTaskCallback(ptr);

    public static implicit operator delegate*<TaskCallback, int, int, void*, void*, void*>(EnqueueTaskCallback callback) => callback._ptr;
    
    public void* Invoke(TaskCallback task, int itemCount, int minRange, void* taskContext, void* userContext) => _ptr(task, itemCount, minRange, taskContext, userContext);
}