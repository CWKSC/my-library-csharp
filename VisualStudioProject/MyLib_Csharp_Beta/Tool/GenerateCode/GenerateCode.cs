using MyLib_Csharp_Beta.CommonMethod;
using MyLib_Csharp_Beta.ProgrammingPattern;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public static void CombinationLoop(this int[] indexArray, Action<int[]> action)
        {
            int[] indexs = new int[indexArray.Length];
            while (true)
            {
                action(indexs);
                indexs[^1]++;
                for (int i = indexArray.Length - 1; i >= 0; i--)
                {
                    if (indexs[i] < indexArray[i]) break;
                    if (i == 0) return;
                    indexs[i] = 0;
                    indexs[i - 1]++;
                }
            };
        }

        public static string Generate(string template, params string[][] set)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int[] refer = new int[set.Length];
            refer.Map((ele, i) => set[i].Length);
            //set.Length.Loop(i => refer[i] = set[i].Length);
            //refer.Println();
            refer.CombinationLoop(indexs =>
            {
                string temp = template;
                indexs.Loop((ele, i) =>
                {
                    temp = temp.Replace($"<{i}>", set[i][ele]);
                });
                stringBuilder.Append(temp);
            });
            return stringBuilder.ToString();
        }



    }
}
