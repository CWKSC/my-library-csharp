using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.CommonMethod
{
    public static partial class MyString
    {
         
        public static void Test()
        {
            // AllAdd, AllAddFront //
            string[] OneToFive = { "1", "2", "3", "4", "5"};
            OneToFive.AllAdd("0").Println();
            OneToFive.AllAddFront("S").Printlnln();

            // Mix two string[] //
            string[] ABCD = { "a", "b", "c", "d" };
            string[] OneToFour = { "1", "2", "3", "4" };
            ABCD.Mix(OneToFour).Printlnln();

            /// ToUpperTriangular ///
            string[] OneToThree = { "1", "2", "3" };
            OneToThree.ToUpperTriangular().Printlnln();
            OneToThree.ToConcatUpperTriangular().Printlnln();
            OneToThree.ToConcatUpperTriangular_SeparateBy("*").Printlnln();

            string t = "T";
            t.ToUpperTriangular(5).Printlnln();
            t.ToConcatUpperTriangular_SeparateBy(5, "*").Printlnln();

        }
        /* Output:
        10, 20, 30, 40, 50
        S10, S20, S30, S40, S50

        a1, b2, c3, d4

        1
        1, 2
        1, 2, 3

        1, 12, 123

        1, 1*2, 1*2*3

        T
        T, T
        T, T, T
        T, T, T, T
        T, T, T, T, T

        T, T*T, T*T*T, T*T*T*T, T*T*T*T*T
        */

    }
}
