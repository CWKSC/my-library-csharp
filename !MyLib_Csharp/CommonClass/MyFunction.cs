using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.CommonClass
{
    public static class MyFunction
    {



        public static Func<int, object[], double> ToNoArgsLoopFunc(this Func<int, double> f) => (x, _) => f(x);

        public static Func<int, T> ToIntInputFunc<T>(this Func<double, T> f) => x => f(x);





    }
}
