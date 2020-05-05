using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.CommonClass
{
    public static class MyLoop
    {


        public static void Loop(this int times, Action action)
        {
            for (int i = 0; i < times; i++)
                action();
        }
        public static void Loop(this int times, Action<int> action)
        {
            for (int i = 0; i < times; i++)
                action(i);
        }


        public static void Loop(this (int start, int end) args, Action action) => 
            Loop(args, (_) => action());

        /// <summary> [start, end] </summary>
        public static void Loop(this (int start, int end) args, Action<int> action)
        {
            for (int i = args.start; i <= args.end; i++)
                action(i);
        }

        public static void Loop(this (int start, int end, int step) args, Action action) => 
            Loop(args, (_) => action());

        public static void Loop(this (int start, int end, int step) args, Action<int> action)
        {
            for (int i = args.start; i <= args.end; i += args.step)
                action(i);
        }


    }
}
