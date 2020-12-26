using MyLib_Csharp_Beta.CommonMethod;
using System;
using System.Collections.Generic;
using System.Text;

using static MyLib_Csharp_Beta.ProgrammingPattern.Builder;

namespace MyLib_Csharp_Beta.ProgrammingPattern.Functional
{
    public static partial class MyHKT
    {

        public static R[] Map<T, R>(T[] fa, Func<T, R> F) =>
            BuildArrayForEach(fa.Length, i => F(fa[i]));


        public static void Test()
        {
            int[] list = { 1, 2, 3, 4 };
            Map(list, x => x + 1.5).Println();
        }

    }
}
