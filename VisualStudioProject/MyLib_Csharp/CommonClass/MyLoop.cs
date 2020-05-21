using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.CommonClass
{
    public static class MyLoop
    {


        public static void ForEach<T>(this T[] array, Action<T> action) => array.Length.Loop(i => action(array[i]));
        public static void ForEach<T>(this T[] array, Action<T, int> action) => array.Length.Loop(i => action(array[i], i));


        public static void Loop(this int times, Action action, Predicate<int> condition = null) =>
            times.Loop((__) => action(), condition);

        public static void Loop(this int times, Action<int> action, Predicate<int> condition = null) =>
            (0, times - 1).Loop(action, condition);



        public static void Loop(this (int start, int end) args, Action action, Predicate<int> condition = null) => 
            Loop(args, (__) => action(), condition);

        /// <summary> [start, end] </summary>
        public static void Loop(this (int start, int end) args, Action<int> action, Predicate<int> condition = null) =>
            (args.start, args.end, 1).Loop(action, condition);




        public static void Loop(this (int start, int end, int step) args, Action action, Predicate<int> condition = null) => 
            Loop(args, (_) => action(), condition);

        public static void Loop(this (int start, int end, int step) args, Action<int> action, Predicate<int> condition = null)
        {
            for (int i = args.start; i <= args.end; i += args.step)
                if(condition == null || condition(i))
                    action(i);
        }


    }
}
