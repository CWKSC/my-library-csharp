using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.CommonMethod
{
    public static partial class MyToString
    {

        public static void Test()
        {
            int[] array = { 1, 3, 5, 7, 9 };
            ("array = " + array.ToStr()).Println(); //array = 1, 3, 5, 7, 9

        }


    }
}
