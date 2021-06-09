using MyLib_Csharp_Beta.CommonMethod;
using MyLib_Csharp_Beta.ProgrammingPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.Algorithm
{
    public partial class NQueen
    {
        public static void Test()
        {
            ApplyFunction.ApplyFunc(ele => Printing.Println(ele),
                SolveNQueen(4),
                SolveNQueen(5),
                SolveNQueen(6),
                SolveNQueen(7),
                SolveNQueen(8),
                SolveNQueen(9),
                SolveNQueen(10),
                SolveNQueen(11),
                SolveNQueen(12)
            );
        }

    }
}
