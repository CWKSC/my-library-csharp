using MyLib_Csharp_Beta.CommonMethod;
using MyLib_Csharp_Beta.ProgrammingPattern;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

using static MyLib_Csharp_Beta.ProgrammingPattern.Builder;

namespace MyLib_Csharp_Beta.Tool
{
    public static partial class TemplateGenerator
    {

        public static string Generate(string template, string[] set1, string[] set2) =>
            BuildString(builder =>
            {
                set1.Loop((set1_ele, _) =>
                    set2.Loop((set2_ele, _) =>
                        builder.Append(
                            template.Replace("<1>", set1_ele)
                                    .Replace("<2>", set2_ele))
                    )
                );
            });


        public static string Generate(string template, params string[][] set) =>
            BuildString(builder =>
            {
                int[] refer = set.GetRowLengthArray();
                refer.CombinationLoop(indexs =>
                {
                    string temp = template;
                    indexs.Loop((index, i) => temp = temp.Replace($"<{i}>", set[i][index]) );
                    builder.Append(temp);
                });
            });


        public static string GenerateByGroup(string template, params string[][][] groups) =>
            BuildString(builder =>
            {
                int[] refer = new int[groups.Length];
                refer.Map((ele, i) => groups[i][0].Length);
                refer.CombinationLoop(indexs =>
                {
                    string temp = template;
                    groups.Length.Loop(groupNum =>
                        groups[groupNum].Length.Loop(setNum => 
                            temp = temp.Replace($"<{groupNum}_{setNum}>", groups[groupNum][setNum][indexs[groupNum]])));
                    builder.Append(temp);
                });
            });


        public static string GenerateByName(string template, params (string name, string[] set)[] sets) =>
            BuildString(builder => 
            {
                int[] refer = new int[sets.Length];
                refer.Map((ele, i) => sets[i].set.Length);
                refer.CombinationLoop(indexs =>
                {
                    string temp = template;
                    indexs.Loop((index, i) => temp = temp.Replace($"<{sets[i].name}>", sets[i].set[index]));
                    builder.Append(temp);
                });
            });




    }
}
