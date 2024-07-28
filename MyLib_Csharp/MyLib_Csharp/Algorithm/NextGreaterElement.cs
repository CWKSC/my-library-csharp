using MyLibCsharp.DataStructure.MonotonicStack;

namespace MyLibCsharp.Algorithm;

public static class NextGreaterElement
{

    public enum LeftOrRight
    {
        Left, Right
    }

    public enum GreaterOrSmaller
    {
        Greater, Smaller
    }

    public static int[] NextElement(
        int[] array,
        bool strict = false,
        LeftOrRight direction = LeftOrRight.Left,
        GreaterOrSmaller greaterOrSmaller = GreaterOrSmaller.Greater)
    {
        var monotonicStack = new MonotonicStackWithIndex<int>(false, strict);
        var popsList = monotonicStack.PushRange(array);
        var distance = Enumerable.Repeat(0, array.Length).ToArray();
        popsList.Loop((ele, index, listIndex) =>
        {
            distance[index] = listIndex - index;
        });
        return distance;
    }

    public static int[] NextGreaterElementRight(int[] array, bool strict = false)
    {
        var monotonicStack = new MonotonicStackWithIndex<int>(false, strict);
        var popsList = monotonicStack.PushRange(array);
        var distance = Enumerable.Repeat(0, array.Length).ToArray();
        popsList.Loop((ele, index, listIndex) =>
        {
            distance[index] = listIndex - index;
        });
        return distance;
    }


}
