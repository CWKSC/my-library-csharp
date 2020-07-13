using System;
using System.Collections.Generic;
using System.Text;

using static MyLib_Csharp_Beta.CommonMethod.MyPrint;

namespace MyLib_Csharp_Beta.ProgrammingPattern
{
    public static partial class JoinFunction
    {
        private static readonly Action<int> PrintI = (int i) => i.Print();

        public static void Test()
        {
            (1, 5).JoinFunc(i => i.Print(), _ => ", ".Print()).ln();
            (1, 5).JoinFunc(PrintI, _ => ", ".Print()).ln();
            (1, 5).JoinFunc(i => i.Print(), ", ").ln();
            (1, 5).JoinFunc(PrintI, ", ").lnln();

            3.JoinFunc(i => i.Print(), _ => ", ".Print()).ln();
            3.JoinFunc(PrintI, _ => ", ".Print()).ln();
            3.JoinFunc(i => i.Print(), ", ").ln();
            3.JoinFunc(PrintI, ", ").lnln();

            int[] array = { 12, 34, 56, 78, 910 };
            array.JoinFunc(PrintI, ", ");
        }
        /* Output :
        1, 2, 3, 4, 5
        1, 2, 3, 4, 5
        1, 2, 3, 4, 5
        1, 2, 3, 4, 5

        0, 1, 2
        0, 1, 2
        0, 1, 2
        0, 1, 2

        12, 34, 56, 78, 910
        */

    }
}
