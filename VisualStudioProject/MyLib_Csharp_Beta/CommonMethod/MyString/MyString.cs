using MyLib_Csharp_Beta.ProgrammingPattern;
using System;
using System.Collections.Generic;
using System.Text;

using static MyLib_Csharp_Beta.ProgrammingPattern.Builder;

namespace MyLib_Csharp_Beta.CommonMethod
{
    public static partial class MyString
    {

        public static string[][] ToUpperTriangular(string[] array) =>
            BuildArray<string[]>(array.Length, result =>
                (1, array.Length).Loop(i => 
                    result[i] = array.SubArray(0, i)));


    }
}
