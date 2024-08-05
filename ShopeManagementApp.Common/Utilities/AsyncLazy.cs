using System.Runtime.CompilerServices;

namespace ShopeManagementApp.Common.Utilities;

public class AsyncLazy<T> : Lazy<Task<T>>
{
    public TaskAwaiter<T> GetAwaiter() { return Value.GetAwaiter(); }
    public AsyncLazy(Func<T> valueFactory) : base(() => Task.Factory.StartNew(valueFactory)) { }
    public AsyncLazy(Func<Task<T>> valueFactory) : base(() => Task.Factory.StartNew(valueFactory).Unwrap()) { }
}
