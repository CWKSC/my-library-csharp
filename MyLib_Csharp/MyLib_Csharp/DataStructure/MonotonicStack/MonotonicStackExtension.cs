namespace MyLibCsharp.DataStructure.MonotonicStack;

public static class MonotonicStackExtension
{

    public static void Loop<T>(this (List<(T value, int index)> list, int index)[] popsList, Action<T, int, int> action)
    {
        foreach (var (list, index) in popsList)
        {
            foreach (var ele in list)
            {
                action(ele.value, ele.index, index);
            }
        }
    }

}
