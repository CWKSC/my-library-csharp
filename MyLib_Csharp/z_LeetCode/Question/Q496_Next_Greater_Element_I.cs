using MyLibCsharp.DataStructure.MonotonicStack;

namespace z_LeetCode.Question;

public static class Q496_Next_Greater_Element_I
{

    public static int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        var monotonicStack = new MonotonicStackWithIndex<int>(false, true);
        var popsList = monotonicStack.PushRange(nums2);

        var dict = new Dictionary<int, int>();
        popsList.Loop((ele, index, listIndex) =>
        {
            dict[nums2[index]] = nums2[listIndex];
        });

        var result = Enumerable.Repeat(-1, nums1.Length).ToArray();
        for (var i = 0; i < nums1.Length; i++)
        {
            result[i] = dict.TryGetValue(nums1[i], out int value) ? value : -1;
        }
        return result;
    }

}
