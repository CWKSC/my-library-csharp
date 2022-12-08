using MyLibCsharp.General;

namespace MyLibCsharp.DataStructure.MonotonicStack;

public class MonotonicStackWithIndex<T> : MonotonicStack<(T value, int index)> where T : IComparable
{

    public MonotonicStackWithIndex(bool increasing = true, bool strict = true) :
        base(increasing, strict, (a, b) => a.value.CompareTo(b.value))
    {
    }

    public (List<(T value, int index)> list, int index)[] PushRange(params T[] items)
    {
        var itemWithIndex = items.ZipIndex();
        var result = PushRange(itemWithIndex);
        return result.ZipIndex();
    }

}
