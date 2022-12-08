namespace MyLibCsharp.DataStructure.MonotonicStack;

public class MonotonicStack<T> where T : IComparable
{
    readonly Stack<T> stack = new();
    readonly bool increasing;
    readonly bool strict;
    readonly Func<T, T, int>? customCompare;

    public MonotonicStack(bool increasing = true, bool strict = true, Func<T, T, int>? customCompare = null)
    {
        this.increasing = increasing;
        this.strict = strict;
        this.customCompare = customCompare;
    }

    public List<T> Push(T item)
    {
        var pops = new List<T>();
        while (stack.Count > 0)
        {
            var top = stack.First();
            var compareTo = customCompare != null ? customCompare(top, item) : top.CompareTo(item);
            var isPop = increasing ?
                strict ? compareTo >= 0 : compareTo > 0 :
                strict ? compareTo <= 0 : compareTo < 0;
            if (!isPop) break;
            pops.Add(stack.Pop());
        }
        stack.Push(item);
        return pops;
    }

    public List<List<T>> PushRange(params T[] items)
    {
        var result = new List<List<T>>();
        foreach (var item in items)
        {
            result.Add(Push(item));
        }
        return result;
    }

    public void Pop() => stack.Pop();

}
