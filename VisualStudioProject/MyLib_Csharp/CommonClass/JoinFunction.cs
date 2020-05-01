﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.CommonClass
{
    public static class JoinFunction
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
