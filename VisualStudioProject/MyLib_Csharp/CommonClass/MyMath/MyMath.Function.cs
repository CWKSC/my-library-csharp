using System;
using System.Collections.Generic;
using System.Text;

using static System.Math;

namespace MyLib_Csharp.CommonClass
{
    public static partial class MyMath
    {


        public static void FunctionTest()
        {
            
            Tabling_Func(((Func<double, double>)Gamma).ToIntFunc(), 1, 10);

        }


        public static Func<int, T> ToIntFunc<T>(this Func<double, T> f) => x => f(x);


        /// <summary>
        /// [start, end]
        /// </summary>
        public static void Tabling_Func<T>(Func<int, T> f, int start, int end)
        {
            Console.Write(f(start));
            for (int i = start + 1; i <= end; i++)
            {
                Console.Write(", " + f(i));
            }
        }


        public static double Gamma(double z) => Integral(
            (t, z) => Pow(t, z - 1) / Exp(t),
            z, 0, 100);


        public static double XPow2_sub_0_5(double x)
        {
            return x * x - 0.5;
        }

        public static double XPow10_sub_1(double x)
        {
            return Pow(x, 10) - 1;
        }


    }
}
