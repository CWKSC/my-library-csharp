
using static MyLib_Csharp_Beta.CommonMethod.Printing;

namespace MyLib_Csharp_Beta.Tool
{
    public class Monitor
    {

        public static void Test()
        {
            Monitor<int> monitor = new Monitor<int>(1);

            monitor.IsChange(2).Println(); // value change
            monitor.IsChange(2).Println();
            monitor.IsChange(2).Printlnln();

            monitor.IsChange(3).Println(); // value change
            monitor.IsChange(3).Println();
            monitor.IsChange(3).Printlnln();

            monitor.IsChange(4).Println(); // value change
            monitor.IsChange(4).Println();
            monitor.IsChange(4).Printlnln();

        }


    }
}
