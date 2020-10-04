using MyLib_Csharp_Beta.CommonMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.ProgrammingPattern
{
    public static partial class ApplyFunction
    {

        public static void Test()
        {
            ApplyFunc((Func<dynamic, dynamic>)Printing.Println,
                true,
                "1",
                2,
                0.3,
                '4',
                (5, 6),
                new string[] { "1", "2", "3"}
                // It won't work because it is calling Printing.Println<T>
                // instead of calling Print.Println<T[]>
                // This is the problem with this function, 
                // it cannot dynamically call other methods suitable for the value.
             ).ln();


            // But It one is work
            // And it will dynamically call other methods suitable for the value.
            ApplyFunc(ele => Printing.Println(ele),
                false,
                "42",
                98765432,
                0.123456789,
                '0',
                (1, 2.3, "4", '5'),
                ' ',
                new string[] { "a", "b", "c" },
                ' ',
                new int[,] { { 1, 2, 3 }, { 4, 5, 6}, { 7, 8, 9} },
                ' ',
                new int[][] { new[] { 4 }, new[] { 4, 5 }, new[] { 4, 5, 6 } }
             );;


        }

    }
}
