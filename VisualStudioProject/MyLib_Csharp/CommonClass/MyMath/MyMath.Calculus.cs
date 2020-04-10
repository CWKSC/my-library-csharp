using System;
using System.Collections.Generic;
using System.Text;

using static System.Math;

namespace MyLib_Csharp.CommonClass
{
    partial class MyMath
    {

        public static void CalculusTest()
        {

        }

        public double Diff_Forward(Func<double, double> f, double x, double deltaX = 1e-7) => (f(x + deltaX) - f(x)) / deltaX ;

        public double Diff_Backward(Func<double, double> f, double x, double deltaX = 1e-7) => (f(x) - f(x - deltaX)) / deltaX;

        public double Diff_Midden(Func<double, double> f, double x, double deltaX = 1e-7) => (f(x + deltaX) - f(x - deltaX)) / (2 * deltaX);


        public double Diff_FivePointStencil(Func<double, double> f, double x, double deltaX = 1e-7) => 
            (-f(x + 2 * deltaX) + 8 * f(x + deltaX) - 8 * f(x - deltaX) + f(x - 2 * deltaX)) / (12 * deltaX);




        public double Integral(Func<double, double> f, 
            double lower, double upper, double step = 1e-3)
        {
            double sum = 0;
            for (double i = lower; i <= upper; i += step)
            {
                sum += f(i) * step;
            }
            return sum;
        }

        public double Integral<T>(Func<double, T, double> f, T otherParameter, 
            double lower, double upper, double step = 1e-3)
        {
            double sum = 0;
            for (double i = lower; i <= upper; i += step)
            {
                sum += f(i, otherParameter) * step;
            }
            return sum;
        }


        public double Integral_SimpsonRule(Func<double, double> f, 
            double lower, double upper) =>
            (upper - lower) / 6 * (f(lower) + 4 * f((lower + upper) / 2) + f(upper));


        public double Integral_BooleRule(Func<double, double> f,
           double lower, double upper) =>
           (upper - lower) / 6 * (f(lower) + 4 * f((lower + upper) / 2) + f(upper));




    }
}
