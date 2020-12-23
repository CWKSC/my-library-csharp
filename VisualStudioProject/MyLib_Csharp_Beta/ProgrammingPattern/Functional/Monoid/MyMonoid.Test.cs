using MyLib_Csharp_Beta.CommonMethod;
using System;
using System.Collections.Generic;
using System.Text;

using static MyLib_Csharp_Beta.ProgrammingPattern.ApplyFunction;

namespace MyLib_Csharp_Beta.ProgrammingPattern.Functional
{
    public static partial class MyMonoid
    {
        public static void Test()
        {
            Console.WriteLine(new OptionalM_pre<int>().Appends(new int?[] { null, 2, 3 }));

            ApplyFunc(ele => OptionalM<int>().Appends((int?[])ele).Println(),
                new int?[] { 1, null, null },
                new int?[] { null, 2, null },
                new int?[] { null, null, 3 },
                new int?[] { 1, 2, null },
                new int?[] { 1, null, 3 },
                new int?[] { null, 2, 3 },
                new int?[] { 1, 2, 3 }
            );
        }
    }
}
