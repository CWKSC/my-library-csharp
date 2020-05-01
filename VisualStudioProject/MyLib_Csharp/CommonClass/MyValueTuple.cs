using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.CommonClass
{
    public static class MyValueTuple
    {

        public static object[] ToObjectArray<T>(this ValueTuple<T> tuple) => new object[] { tuple.Item1 };
        public static object[] ToObjectArray<T1, T2>(this (T1, T2) tuple) => new object[] { tuple.Item1, tuple.Item2 };
        public static object[] ToObjectArray<T1, T2, T3>(this (T1, T2, T3) tuple) => new object[] { tuple.Item1, tuple.Item2, tuple.Item3 };
        public static object[] ToObjectArray<T1, T2, T3, T4>(this (T1, T2, T3, T4) tuple) => new object[] { tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4 };




    }
}
