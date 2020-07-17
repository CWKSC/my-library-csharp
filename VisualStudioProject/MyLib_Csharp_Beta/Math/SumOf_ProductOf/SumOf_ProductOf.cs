using MyLib_Csharp_Beta.CommonType;
using MyLib_Csharp_Beta.ProgrammingPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.Math
{
    public static partial class SumOf_ProductOf
    {

        public static double SumOf(this (int start, int end) args, MyFunc<int, double> f, MyFunc<int, bool> condition = null)
        {
            double sum = 0;
            args.Loop(i => sum += f.Invoke(i), condition);
            return sum;
        }

    }
}
