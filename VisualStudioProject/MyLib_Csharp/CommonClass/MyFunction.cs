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

        public static Func<int, object[], double> ToNoArgsLoopFunc(this Func<int, double> f) => (x, _) => f(x);

        public static Func<int, T> ToIntInputFunc<T>(this Func<double, T> f) => x => f(x);





    }
}
