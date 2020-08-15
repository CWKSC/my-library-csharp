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
            string template = "<1> <2>\n";
            string[] set1 = { "1", "3", "5" };
            string[] set2 = { "a", "b", "c" };

            Generate(template, set1, set2).Println();
        }


    }
}
