using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.CommonClass
{
    public static class MyFunction
    {

        public delegate OUT ParamsFunc<OUT>(params object[] args);
        public delegate OUT ParamsFunc<IN, OUT>(params IN[] args);
        public delegate OUT RefFunc<IN, OUT>(ref IN arg);
        public delegate OUT OutFunc<IN, OUT>(out IN arg);
        public delegate OUT InFunc<IN, OUT>(in IN arg);

        public delegate ParamsFunc<RecursionParamsFuncFunc> RecursionParamsFuncFunc(params object[] args);
        public delegate ParamsFunc<T, RecursionParamsFunc<T>> RecursionParamsFunc<T>(params T[] args);
        public delegate RefFunc<T, RecursionRefFunc<T>> RecursionRefFunc<T>(ref T arg);
        public delegate OutFunc<T, RecursionOutFunc<T>> RecursionOutFunc<T>(out T arg);
        public delegate InFunc<T, RecursionInFunc<T>> RecursionInFunc<T>(in T arg);

        public static Func<int, object[], double> ToNoArgsLoopFunc(this Func<int, double> f) => (x, _) => f(x);

        public static Func<int, T> ToIntInputFunc<T>(this Func<double, T> f) => x => f(x);


        /*

        public static RecursionRefFunc<T> Foo<T>(ref T input)
        {
            Console.WriteLine(input);
            return (ref T t) => { Foo(ref t); return Foo; };
        }

        public static void Main(string[] args)
        {
            int x1 = 1, x2 = 2, x3 = 3, x4 = 4, x5 = 5;
            Foo(ref x1)(ref x2)(ref x3)(ref x4)(ref x5);
        }

        */



    }
}
