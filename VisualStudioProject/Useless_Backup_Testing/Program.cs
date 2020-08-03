using MyLib_Csharp_Beta.CommonMethod;
using MyLib_Csharp_Beta.Math;
using System;

namespace Useless_Backup_Testing
{
    class Program
    {
        public static double Power2_v2(int x)
        {
            int sumOf = 0;
            for (int i = 1; i <= x - 1; i++)
                sumOf += i;
            return x + 2 * sumOf;
        }



        public static double Power2(int x) =>
            x + ((int)(1, x - 1).SumOf(i => i) << 1);

        public static double Power3(int x) =>
            0.75 + 0.25 * x + 3 * (1, x - 1).SumOf(i => (i + 0.5) * (i + 0.5));


        // Recursion //

        public static double Power2_r(int x) =>
            x == 1 ? 1 : Power2_r(x - 1) + 2 * (x - 1) + 1;

        public static double Power3_r(int x) =>
            x == 1 ? 1 : Power3_r(x - 1) + 3 * (x - 0.5) * (x - 0.5) + 0.25;



        public static void Main(string[] args)
        {
            ("2^2  = " + Power2(2)).Println();
            ("4^2  = " + Power2(4)).Println();
            ("10^2 = " + Power2(10)).Println();
            ("42^2 = " + Power2(42)).Printlnln();

            ("2^3  = " + Power3(2)).Println();
            ("4^3  = " + Power3(4)).Println();
            ("10^3 = " + Power3(10)).Println();
            ("42^3 = " + Power3(42)).Printlnln();

            ("2^2  = " + Power2_v2(2)).Println();
            ("4^2  = " + Power2_v2(4)).Println();
            ("10^2 = " + Power2_v2(10)).Println();
            ("42^2 = " + Power2_v2(42)).Printlnln();

            //Looping.Test();
        }

    }
}
