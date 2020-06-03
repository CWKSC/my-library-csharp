﻿using System;
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


        public delegate RecursionParamsFuncFunc RecursionParamsFuncFunc(params object[] args);
        public delegate RecursionParamsFunc<T> RecursionParamsFunc<T>(params T[] args);
        public delegate RecursionRefFunc<T> RecursionRefFunc<T>(ref T arg);
        public delegate RecursionOutFunc<T> RecursionOutFunc<T>(out T arg);
        public delegate RecursionInFunc<T> RecursionInFunc<T>(in T arg);


        public static Func<int, object[], double> ToNoArgsLoopFunc(this Func<int, double> f) => (x, _) => f(x);

        public static Func<int, T> ToIntInputFunc<T>(this Func<double, T> f) => x => f(x);


        /*

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

        */



    }
}