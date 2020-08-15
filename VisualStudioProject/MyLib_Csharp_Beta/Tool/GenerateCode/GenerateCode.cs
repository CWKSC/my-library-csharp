using MyLib_Csharp_Beta.ProgrammingPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.Tool
{
    public static partial class GenerateCode
    {

        public static string Generate(string template, string[] set1, string[] set2)
        {
            StringBuilder stringBuilder = new StringBuilder();
            set1.Loop((set1_ele, _) =>
                set2.Loop((set2_ele, _) =>
                    stringBuilder.Append(
                        template.Replace("<1>", set1_ele)
                                .Replace("<2>", set2_ele))
                )
            );
            return stringBuilder.ToString();
        }

        public static string Generate(string template, params string[][] set)
        {
            StringBuilder stringBuilder = new StringBuilder();
            set.Loop((ele, _) =>
            {
                //stringBuilder.Append(template.Replace("<1>", ele[i]));
            });
            return "";
        }



    }
}
