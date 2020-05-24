using MyLib_Csharp.CommonClass;
using System;
using System.Diagnostics.CodeAnalysis;
using static MyLib_Csharp.CommonClass.MyFunction;

namespace MyLib_Csharp
{
    class Program
    {


        public static RecursionRefFunc<T> Boo<T>(ref T input)
        {
            Console.WriteLine(input); // Work in here
            return Boo;
        }

        public static void Main(string[] args)
        {
            int x1 = 1, x2 = 2, x3 = 3, x4 = 4, x5 = 5;
            Boo(ref x1)(ref x2)(ref x3)(ref x4)(ref x5);
        }

    }

}
