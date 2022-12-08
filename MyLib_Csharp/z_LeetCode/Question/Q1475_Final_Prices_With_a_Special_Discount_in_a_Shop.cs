using MyLibCsharp.DataStructure.MonotonicStack;

namespace z_LeetCode.Question;

public class Q1475_Final_Prices_With_a_Special_Discount_in_a_Shop
{

    public static int[] FinalPrices(int[] data)
    {
        var monotonicStack = new MonotonicStackWithIndex<int>(true, true);
        var popsList = monotonicStack.PushRange(data);

        var result = data;
        popsList.Loop((ele, index, listIndex) =>
        {
            result[index] -= data[listIndex];
        });
        return result;
    }

}
