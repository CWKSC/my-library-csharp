using MyLib_Csharp_Beta.Math;
using System;
using System.Collections.Generic;
using System.Text;

namespace Useless_Backup_Testing.Math
{
    public static partial class PowerX
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

    }
}
