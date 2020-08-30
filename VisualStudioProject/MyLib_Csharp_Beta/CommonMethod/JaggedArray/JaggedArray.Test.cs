using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.CommonMethod
{
    public static partial class JaggedArray
    {


        public static void Test()
        {
            int[,] rectArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            rectArray.GetType().Println();
            rectArray.Printlnln();

            int[][] jaggedArray = rectArray.ToJagged();

            jaggedArray.GetType().Println();
            jaggedArray.Println();

        }


    }
}
