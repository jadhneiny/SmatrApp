namespace ShopeManagementApp.Common.Utilities;

public class AsyncRef<T>
{
    public T Value { get; set; }

    public AsyncRef(T value)
    {
        Value = value;
    }
}
