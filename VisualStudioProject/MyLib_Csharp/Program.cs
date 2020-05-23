using System;
using static MyLib_Csharp.CommonClass.MyFunction;

namespace MyLib_Csharp
{
    class Program
    {

        public static RecursionRefFunc<T> Foo<T>(ref T input)
        {
            Console.WriteLine(input); // Work in here
            return (ref T t) => { Foo(ref t); return Foo; };
        }

        public static void Main(string[] args)
        {
            int x1 = 1, x2 = 2, x3 = 3, x4 = 4, x5 = 5;
            Foo(ref x1)(ref x2)(ref x3)(ref x4)(ref x5);
        }

    }

}
