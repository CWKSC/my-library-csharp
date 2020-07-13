using System;
using System.Collections.Generic;
using System.Text;

using static MyLib_Csharp_Beta.CommonMethod.MyPrint;
using static MyLib_Csharp_Beta.ProgrammingPattern.ProgramStructure;

namespace MyLib_Csharp_Beta.ProgrammingPattern
{
    public static partial class JoinFunction
    {

        private static readonly Action<int> PrintI = i => i.Print();

        public static void Test()
        {
            // (int, int) JoinFunc(this (int, int) args, MyAction<int> work, MyAction<int> joinAction) //
            (1, 5).JoinFunc(i => i.Print(), _ => ", ".Print()).ln();
            (1, 5).JoinFunc(PrintI, _ => ", ".Print()).ln();
            (1, 5).JoinFunc(i => i.Print(), ", ").ln();
            (1, 5).JoinFunc(PrintI, ", ").lnln();

            // int JoinFunc(this int times, MyAction<int> work, MyAction<int> joinAction) //
            3.JoinFunc(i => i.Print(), _ => ", ".Print()).ln();
            3.JoinFunc(PrintI, _ => ", ".Print()).ln();
            3.JoinFunc(i => i.Print(), ", ").ln();
            3.JoinFunc(PrintI, ", ").lnln();

            // T[] JoinFunc<T>(this T[] array, MyAction<T, int> work, MyAction<T, int> joinAction) //
            int[] array = { 12, 34, 56, 78, 910 };
            array.JoinFunc((ele, _) => ele.Print(), (_, __) => ", ".Print()).ln();
            array.JoinFunc(PrintI, (_, __) => ", ".Print()).ln();
            array.JoinFunc((ele, _) => ele.Print(), ", ").ln();
            array.JoinFunc(PrintI, ", ").lnln();

            // Use Adapter //
            // If function not provide overloading function for adapt MyAction/MyFunc Type parameter //
            // You need to use Action/Func Adapter //
            (1, 5).JoinFunc(
                _a((int i) => i.Print()),
                _a(() => ", ".Print())
            ).ln();

            3.JoinFunc(
                _a((int i) => i.Print()), 
                _a(() => ", ".Print())
            ).ln();

            array.JoinFunc(
                _a((int i) => i.Print()),
                _a(() => ", ".Print())
            ).ln();

        }
        /* Output
        1, 2, 3, 4, 5
        1, 2, 3, 4, 5
        1, 2, 3, 4, 5
        1, 2, 3, 4, 5

        0, 1, 2
        0, 1, 2
        0, 1, 2
        0, 1, 2

        12, 34, 56, 78, 910
        12, 34, 56, 78, 910
        12, 34, 56, 78, 910
        12, 34, 56, 78, 910

        1, 2, 3, 4, 5
        0, 1, 2
        12, 34, 56, 78, 910
        */

    }
}
