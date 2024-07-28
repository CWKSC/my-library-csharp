using MyLibCsharp.Algorithm;

namespace z_LeetCode.Question;

public class Q739_Daily_Temperatures
{


    public int[] DailyTemperatures(int[] temperatures)
    {
        return NextGreaterElement.NextGreaterElementRight(temperatures);
    }


}
