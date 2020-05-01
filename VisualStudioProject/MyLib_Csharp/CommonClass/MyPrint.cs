using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.CommonClass
{
    public static class MyPrint
    {


        public static void JoinPrint<T>(this T[] array, Action<T, int> work, string joinString) =>
            JoinPrint(array, (ele, i) => { work(ele, i); return ""; }, (__, ___) => joinString);

        public static void JoinPrint<T>(this T[] array, Action<T, int> work, Func<string> joinAction) =>
            JoinPrint(array, (ele, i) => { work(ele, i); return ""; }, (__, ___) => joinAction());


        public static void JoinPrint<T>(this T[] array, Func<T, int, string> work, string joinString) =>
                JoinPrint(array, work, (__, ___) => joinString);

        public static void JoinPrint<T>(this T[] array, Func<T, int, string> work, Func<string> joinAction) =>
            JoinPrint(array, work, (__, ___) => joinAction());



        public static void JoinPrint<T>(this T[] array, Func<T, int, string> work, Func<T, int, string> joinAction)
        {
            Console.Write(work(array[0], 0));
            (1, array.Length).Loop((i) =>
            {
                Console.Write(joinAction(array[i], i));
                Console.Write(work(array[i], i));
            });
        }



    }
}
