using MyLib_Csharp_Beta.CommonMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.Tool
{
    public static partial class GenerateCode
    {



        public static void Test()
        {
            string template = "<0> <1> <2>\n";
            string[] set1 = { "12", "34" };
            string[] set2 = { "xx", "yy", "zz" };
            string[] set3 = { "aa", "bb", "cc", "dd" };

            Generate(template, set1, set2, set3).Println();
        }


    }
}
