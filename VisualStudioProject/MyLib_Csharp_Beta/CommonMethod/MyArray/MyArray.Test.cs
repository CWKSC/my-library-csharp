using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.CommonMethod
{
    public static partial class MyArray
    {

        public static void Test()
        {
            int[] int1d = GenerateRandIntArray(10, 1, 10);
            int[,] int2d = GenerateRandInt2dArray(5, 4, 10, 20);

            int1d.Printlnln();
            int2d.Println();

        }


    }
}
