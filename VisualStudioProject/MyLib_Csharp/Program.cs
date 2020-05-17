using MyLib_Csharp.CommonClass;
using System;
using System.Runtime.CompilerServices;
using static MyLib_Csharp.CommonClass.MyFunction;

namespace MyLib_Csharp
{
    class Program
    {

        public static void Foo(Action action) { }
        public static void Foo<T>(Action<T> func) { }
        public static void Foo<TResult>(Func<TResult> func) { }
        public static void Foo<T, TResult>(Func<T, TResult> func) { }

        public static void Foo<IN, OUT>(RefFunc<IN, OUT> refFunc) { }
        public static void Foo<IN, OUT>(OutFunc<IN, OUT> refFunc) { }
        public static void Foo<IN, OUT>(InFunc<IN, OUT> refFunc) { }
        public static void Foo<IN, OUT>(ParamsFunc<IN, OUT> refFunc) { }


        public static void Main(string[] args)
        {
            Foo(() => { });
            Foo(((double, long, string) a) => { });
            Foo(() => (1, 2.3));
            Foo(((char, short, (int, int)) a) => (6, 7, (8, 9)) );

            Foo((ref int a) => ('0', "", (1, 2.3)) );
            Foo((in int a) => ('0', "", (1, 2.3)) );
            Foo((out int a) => ('0', "", (a = 1, 2.3)));


            //MyMath.FunctionTest();
            //MyMath.Integral(0, Math.PI, x => x * Math.Sin(x) / (1 + Math.Pow(Math.Cos(x), 2)), 0.0005).Print();
        }

    }

}
