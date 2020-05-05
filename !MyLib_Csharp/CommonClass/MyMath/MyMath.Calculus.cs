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
            // Differential x^4 (x = 3)
            // Answer is 4x^3, 4(3)^3 = 108

            Console.WriteLine("[ Differential x^4 (x = 3) ]");
            Console.WriteLine("Answer is 4x^3, 4(3)^3 = 108");
            Console.WriteLine();


            Console.WriteLine("[Diff_Forward]");
            double Differential_x_pow_4__3 = Diff_Forward(x => x * x * x * x, 3);
            Console.WriteLine("Use default(1e-3) step");
            Console.WriteLine("Answer : " + Differential_x_pow_4__3);
            Console.WriteLine("Delta : " + (Differential_x_pow_4__3 - 108));
            Console.WriteLine();

            Differential_x_pow_4__3 = Diff_Forward(x => x * x * x * x, 3, 1e-6);
            Console.WriteLine("Use 1e-6 step");
            Console.WriteLine("Answer : " + Differential_x_pow_4__3);
            Console.WriteLine("Delta : " + (Differential_x_pow_4__3 - 108));
            Console.WriteLine();


            Console.WriteLine("[Diff_Backward]");
            Differential_x_pow_4__3 = Diff_Backward(x => x * x * x * x, 3);
            Console.WriteLine("Use default(1e-3) step");
            Console.WriteLine("Answer : " + Differential_x_pow_4__3);
            Console.WriteLine("Delta : " + (Differential_x_pow_4__3 - 108));
            Console.WriteLine();

            Differential_x_pow_4__3 = Diff_Backward(x => x * x * x * x, 3, 1e-6);
            Console.WriteLine("Use 1e-6 step");
            Console.WriteLine("Answer : " + Differential_x_pow_4__3);
            Console.WriteLine("Delta : " + (Differential_x_pow_4__3 - 108));
            Console.WriteLine();


            Console.WriteLine("[Diff_Midden]");
            Differential_x_pow_4__3 = Diff_Midden(x => x * x * x * x, 3);
            Console.WriteLine("Use default(1e-3) step");
            Console.WriteLine("Answer : " + Differential_x_pow_4__3);
            Console.WriteLine("Delta : " + (Differential_x_pow_4__3 - 108));
            Console.WriteLine();

            Differential_x_pow_4__3 = Diff_Midden(x => x * x * x * x, 3, 1e-6);
            Console.WriteLine("Use 1e-6 step");
            Console.WriteLine("Answer : " + Differential_x_pow_4__3);
            Console.WriteLine("Delta : " + (Differential_x_pow_4__3 - 108));
            Console.WriteLine();


            Console.WriteLine("[Diff_FivePointStencil]");
            Differential_x_pow_4__3 = Diff_FivePointStencil(x => x * x * x * x, 3);
            Console.WriteLine("Use default(1e-3) step");
            Console.WriteLine("Answer : " + Differential_x_pow_4__3);
            Console.WriteLine("Delta : " + (Differential_x_pow_4__3 - 108));
            Console.WriteLine();

            Differential_x_pow_4__3 = Diff_FivePointStencil(x => x * x * x * x, 3, 1e-6);
            Console.WriteLine("Use 1e-6 step");
            Console.WriteLine("Answer : " + Differential_x_pow_4__3);
            Console.WriteLine("Delta : " + (Differential_x_pow_4__3 - 108));
            Console.WriteLine();

            Console.WriteLine();

            // Integral 3x^2 dx (4 to 10)
            // Answer is x^3, then (10)^3 - (4)^3 = 936

            Console.WriteLine("[ Integral 3x^2 dx (4 to 10) ]");
            Console.WriteLine("Answer is x^3, then (10)^3 - (4)^3 = 936");
            Console.WriteLine();

            Console.WriteLine("[Integral]");
            double Integral_3x_pow_2__4_10 = Integral(4, 10, x => 3*x*x);
            Console.WriteLine("Use default(1e-3) step");
            Console.WriteLine("Answer : " + Integral_3x_pow_2__4_10);
            Console.WriteLine("Delta : " + (Integral_3x_pow_2__4_10 - 936));
            Console.WriteLine();

            Integral_3x_pow_2__4_10 = Integral(4, 10, x => 3 * x * x, 1e-6);
            Console.WriteLine("Use 1e-6 step");
            Console.WriteLine("Answer : " + Integral_3x_pow_2__4_10);
            Console.WriteLine("Delta : " + (Integral_3x_pow_2__4_10 - 936));
            Console.WriteLine();


            Console.WriteLine("[Integral_Sum_By_Trapezoidal]");
            Integral_3x_pow_2__4_10 = Integral_Sum_By_Trapezoidal(x => 3 * x * x, 4, 10);
            Console.WriteLine("Use default(1e-3) step");
            Console.WriteLine("Answer : " + Integral_3x_pow_2__4_10);
            Console.WriteLine("Delta : " + (Integral_3x_pow_2__4_10 - 936));
            Console.WriteLine();

            Integral_3x_pow_2__4_10 = Integral_Sum_By_Trapezoidal(x => 3 * x * x, 4, 10, 1e-6);
            Console.WriteLine("Use 1e-6 step");
            Console.WriteLine("Answer : " + Integral_3x_pow_2__4_10);
            Console.WriteLine("Delta : " + (Integral_3x_pow_2__4_10 - 936));
            Console.WriteLine();


            Console.WriteLine("[Integral_Sum_By_Trapezoidal]");
            Integral_3x_pow_2__4_10 = Integral_TrapezoidalRule(x => 3 * x * x, 4, 10);
            Console.WriteLine("Answer : " + Integral_3x_pow_2__4_10);
            Console.WriteLine("Delta : " + (Integral_3x_pow_2__4_10 - 936));
            Console.WriteLine();

            Console.WriteLine("[Integral_SimpsonRule]");
            Integral_3x_pow_2__4_10 = Integral_SimpsonRule(x => 3 * x * x, 4, 10);
            Console.WriteLine("Answer : " + Integral_3x_pow_2__4_10);
            Console.WriteLine("Delta : " + (Integral_3x_pow_2__4_10 - 936));
            Console.WriteLine();

            Console.WriteLine("[Integral_BooleRule]");
            Integral_3x_pow_2__4_10 = Integral_BooleRule(x => 3 * x * x, 4, 10);
            Console.WriteLine("Answer : " + Integral_3x_pow_2__4_10);
            Console.WriteLine("Delta : " + (Integral_3x_pow_2__4_10 - 936));
            Console.WriteLine();
        }

        public static double Diff_Forward(Func<double, double> f, double x, double deltaX = 1e-7) => (f(x + deltaX) - f(x)) / deltaX ;

        public static double Diff_Backward(Func<double, double> f, double x, double deltaX = 1e-7) => (f(x) - f(x - deltaX)) / deltaX;

        public static double Diff_Midden(Func<double, double> f, double x, double deltaX = 1e-7) => (f(x + deltaX) - f(x - deltaX)) / (2 * deltaX);


        public static double Diff_FivePointStencil(Func<double, double> f, double x, double deltaX = 1e-7) => 
            (-f(x + 2 * deltaX) + 8 * f(x + deltaX) - 8 * f(x - deltaX) + f(x - 2 * deltaX)) / (12 * deltaX);




        public static double Integral(double lower, double upper,
            Func<double, double> f, double step = 1e-3)
        {
            double sum = 0;
            for (double i = lower; i <= upper; i += step)
            {
                sum += f(i) * step;
            }
            return sum;
        }

        public static double Integral(double lower, double upper,
            Func<double, object[], double> f, object[] args = null,
            double step = 1e-3)
        {
            double sum = 0;
            for (double i = lower; i <= upper; i += step)
            {
                sum += f(i, args) * step;
            }
            return sum;
        }

        public static double Integral<T>(Func<double, T, double> f, T otherParameter, 
            double lower, double upper, double step = 1e-3)
        {
            double sum = 0;
            for (double i = lower; i <= upper; i += step)
            {
                sum += f(i, otherParameter) * step;
            }
            return sum;
        }



        public static double Integral_Sum_By_Trapezoidal(Func<double, double> f,
            double lower, double upper, double step = 1e-3)
        {
            double sum = 0;
            for (double i = lower; i <= upper; i += step)
            {
                sum += (f(i) + f(i + step)) * step;
            }
            return sum / 2;
        }
        public static double Integral_Sum_By_Trapezoidal<T>(Func<double, T, double> f, T otherParameter,
            double lower, double upper, double step = 1e-3)
        {
            double sum = 0;
            for (double i = lower; i <= upper; i += step)
            {
                sum += (f(i, otherParameter) + f(i + step, otherParameter)) * step;
            }
            return sum / 2;
        }




        public static double Integral_TrapezoidalRule(Func<double, double> f,
            double lower, double upper) => (upper - lower) * (f(lower) + f(upper)) / 2;



        public static double Integral_SimpsonRule(Func<double, double> f, 
            double lower, double upper) =>
            (upper - lower) / 6 * (f(lower) + 4 * f((lower + upper) / 2) + f(upper));


        public static double Integral_BooleRule(Func<double, double> f,
           double lower, double upper)
        {
            double h = (upper - lower) / 4;
            return (2 * h / 45) * (7 * f(lower) + 32 * f(lower + h) + 12 * f(lower + 2 * h) + 32 * f(lower + 3 * h) + 7 * f(upper));
        }



    }
}
