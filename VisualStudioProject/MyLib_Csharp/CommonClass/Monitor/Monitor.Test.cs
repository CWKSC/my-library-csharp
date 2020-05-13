using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.CommonClass
{
    public class Monitor
    {

        public static void Test()
        {
            Monitor<int> monitor = new Monitor<int>();

            monitor.IsChange(1).Println();
            monitor.IsChange(1).Println();
            monitor.IsChange(1).Println();
            Console.WriteLine();
            monitor.IsChange(2).Println(); // value change
            monitor.IsChange(2).Println();
            monitor.IsChange(2).Println();
            Console.WriteLine();
            monitor.IsChange(3).Println(); // value change
            monitor.IsChange(3).Println();
            monitor.IsChange(3).Println();

        }


    }
}
