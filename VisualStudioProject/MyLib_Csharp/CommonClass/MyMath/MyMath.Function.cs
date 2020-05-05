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

            Tabling_Func((x) => Gamma(x), 1, 10); ;

        }



        public static double SumOf(int start, int end,
            Func<int, double> f,
            Func<int, bool> condition = null) =>  SumOf(start, end, f.ToNoArgsLoopFunc(), null, condition);

        public static double SumOf(int start, int end, 
            Func<int, object[], double> f, object[] args = null, 
            Func<int, bool> condition = null)
        {
            double sum = 0;
            for(int i = start; i <= end; i++)
            {
                if (condition == null || condition(i))
                {
                    sum += f(i, args);
                }
            }
            return sum;
        }


        public static double ProductOf(int start, int end,
            Func<int, double> f,
            Func<int, bool> condition = null) => ProductOf(start, end, f.ToNoArgsLoopFunc(), null, condition);

        public static double ProductOf(int start, int end, 
            Func<int, object[], double> f, object[] args = null, 
            Func<int, bool> condition = null)
        {
            double productOf = 1;
            for (int i = start; i <= end; i++)
            {
                if (condition == null || condition(i))
                {
                    productOf *= f(i, args);
                }
            }
            return productOf;
        }




        /// <summary>
        /// [start, end]
        /// </summary>
        public static void Tabling_Func<T>(Func<int, T> f, int start, int end) => 
            (start, end).JoinPrint((i) => f(i).ToString(), " , ");


        public static double Gamma(double z) => Integral(0, 100,
            (t) => Pow(t, z - 1) / Exp(t));


        public static double XPow2_sub_0_5(double x) => x * x - 0.5;

        public static double XPow10_sub_1(double x) => Pow(x, 10) - 1;


    }
}
