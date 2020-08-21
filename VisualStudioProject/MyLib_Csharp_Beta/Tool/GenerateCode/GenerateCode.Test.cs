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
            string[] set0 = { "12", "34" };
            string[] set1 = { "xx", "yy", "zz" };
            string[] set2 = { "aa", "bb", "cc", "dd" };

            Generate(template, set0, set1, set2).Println();

            string template_group = "<0_0> <0_1> <1_0>\n";
            string[] group0_set0 = { "12", "34", "56" };
            string[] group0_set1 = { "xx", "yy", "zz" };
            string[] group1_set0 = { "aa", "bb", "cc", "dd" };
            string[][] group0 = { group0_set0, group0_set1 };
            string[][] group1 = { group1_set0 };

            GenerateByGroup(template_group, group0, group1); // not finish
        }


    }
}
