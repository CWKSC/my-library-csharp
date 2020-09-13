using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.CommonMethod
{
    public static partial class MyString
    {
         
        public static void Test()
        {
            string[] OneToFive = { "1", "2", "3", "4", "5"};
            OneToFive.AllAdd("0").Println();
            OneToFive.AllAddFront("S").Printlnln();

            string[] ABCD = { "a", "b", "c", "d" };
            string[] OneToFour = { "1", "2", "3", "4" };
            ABCD.Mix(OneToFour).Printlnln();

            string[] OneToThree = { "1", "2", "3" };
            OneToThree.ToUpperTriangular().Printlnln();
            OneToThree.ToConcatUpperTriangular().Printlnln();
            OneToThree.ToConcatUpperTriangular_SeparateBy("*").Printlnln();

            string t = "T";
            t.ToUpperTriangular(5).Printlnln();
            t.ToConcatUpperTriangular_SeparateBy(5, "*").Printlnln();


        }

    }
}
