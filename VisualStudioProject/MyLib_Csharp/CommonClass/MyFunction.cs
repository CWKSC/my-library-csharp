using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.CommonClass
{
    public static class MyFunction
    {



        public static Func<int, object[], double> ToNoArgsLoopFunc(this Func<int, double> f) => (x, _) => f(x);

        public static Func<int, T> ToIntInputFunc<T>(this Func<double, T> f) => x => f(x);



        public static void JoinFunc(int times, Action<int> work, Action<int> joinAction) => 
            JoinFunc(0, times, work, joinAction);

        public static void JoinFunc(int start, int end, Action<int> work, Action<int> joinAction)
        {
            work(start);
            (start + 1, end).Loop((i) =>
            {
                joinAction(i);
                work(i);
            });
        }


        public static void JoinFunc<T>(T[] array, Action<T> work, Action joinAction) =>
            JoinFunc(array, (ele, ___) => work(ele), (__, ___) => joinAction());

        public static void JoinFunc<T>(T[] array, Action<T> work, Action<T> joinAction) => 
            JoinFunc(array, (ele, ___) => work(ele), (ele, ___) => joinAction(ele));


        public static void JoinFunc<T>(T[] array, Action<T, int> work, Action joinAction) =>
            JoinFunc(array, work, (__, ___) => joinAction());
        public static void JoinFunc<T>(T[] array, Action<T, int> work, Action<T> joinAction) =>
            JoinFunc(array, work, (ele, ___) => joinAction(ele));

        public static void JoinFunc<T>(T[] array, Action<T, int> work, Action<T, int> joinAction)
        {
            work(array[0], 0);
            (1, array.Length).Loop((i) =>
            {
                joinAction(array[i], i);
                work(array[i], i);
            });
        }


    }
}
