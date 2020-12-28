using MyLib_Csharp_Beta.CommonMethod;
using MyLib_Csharp_Beta.ProgrammingPattern;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

using static MyLib_Csharp_Beta.CommonMethod.MyString;
using static MyLib_Csharp_Beta.ProgrammingPattern.Builder;

namespace MyLib_Csharp_Beta.Tool
{
    public static partial class TemplateGenerator
    {

        public static string[] Generate(this string template, string[] set1, string[] set2) =>
            BuildList<string>(list => {
                set1.Loop((set1_ele, _) =>
                    set2.Loop((set2_ele, __) =>
                        list.Add(
                            template.Replace("<1>", set1_ele)
                                    .Replace("<2>", set2_ele))
                    )
                );
            }).ToArray();



        public static string[] Generate(this string template, params string[][] set) =>
            BuildList<string>(list =>
            {
                int[] refer = set.GetRowLengthArray();
                refer.CombinationLoop(indexs =>
                {
                    string temp = template;
                    indexs.Loop((index, i) => temp = temp.Replace($"<{i}>", set[i][index]));
                    list.Add(temp);
                });
            }).ToArray();


        public static string[] GenerateByGroup(this string template, params string[][][] groups) =>
            BuildList<string>(list =>
            {
                int[] refer = new int[groups.Length];
                refer.Map((ele, i) => groups[i][0].Length);
                refer.CombinationLoop(indexs =>
                {
                    string temp = template;
                    groups.Length.Loop(groupNum =>
                        groups[groupNum].Length.Loop(setNum => 
                            temp = temp.Replace($"<{groupNum}_{setNum}>", groups[groupNum][setNum][indexs[groupNum]])));
                    list.Add(temp);
                });
            }).ToArray();


        public static string[] GenerateByName(this string template, params (string name, string[] set)[] sets) =>
            BuildList<string>(list =>
            {
                int[] refer = new int[sets.Length];
                refer.Map((ele, i) => sets[i].set.Length);
                refer.CombinationLoop(indexs =>
                {
                    string temp = template;
                    indexs.Loop((index, i) => temp = temp.Replace($"<{sets[i].name}>", sets[i].set[index]));
                    list.Add(temp);
                });
            }).ToArray();

        public static string[] GenerateByNameAndGroup(this string template, params (string name, string[] set)[][] groups) =>
            BuildList<string>(list =>
            {
                int[] refer = new int[groups.Length];
                refer.Map((ele, i) => groups[i][0].set.Length);
                refer.CombinationLoop(indexs =>
                {
                    string temp = template;
                    groups.Length.Loop(groupNum =>
                        groups[groupNum].Length.Loop(setNum =>
                            temp = temp.Replace($"<{groups[groupNum][setNum].name}>", 
                                groups[groupNum][setNum].set[indexs[groupNum]])));
                    list.Add(temp);
                });
            }).ToArray();



        /// <summary>
        /// Given &lt;generic&gt; and &lt;number&gt; set by default <br/>
        /// &lt;generic&gt; from T1 to Tn <br/>
        /// &lt;number&gt; from numberStart to numberEnd<br/><br/>
        /// <code>
        /// GenerateGenricPattern("(&lt;generic&gt;) arg", 3) <br />
        /// {<br />
        /// "(T1) arg",<br />
        /// "(T1, T2) arg",<br />
        /// "(T1, T2, T3) arg"<br />
        /// }
        /// </code>
        /// </summary>
        /// <param name="template"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static string[] GenerateGenricPattern(string template, int nGeneric = 6, int numberEnd = 2, int numberStart = 1)
        {
            var genericSet = ("generic", GenericTemplate(nGeneric));
            var numberSet = ("number", (numberStart, numberEnd).ToRangeStringArray());
            return GenerateByNameAndGroup(template, new[] { genericSet }, new[] { numberSet });
        }


    }
}
