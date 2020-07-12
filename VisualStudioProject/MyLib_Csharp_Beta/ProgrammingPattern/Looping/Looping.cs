using MyLib_Csharp_Beta.CommonType;
using System;
using System.Collections.Generic;
using System.Text;

using static MyLib_Csharp_Beta.ProgrammingPattern.ProgramStructure;

namespace MyLib_Csharp_Beta.ProgrammingPattern
{
    public static partial class Looping
    {

        /// <summary> Array.ForEach(array, action); </summary>
        public static T[] ForEach<T>(this T[] array, Action<T> action) { Array.ForEach(array, action); return array; }
        /// <summary> (array.Length).Loop(i => action(array[i], i)); </summary>
        public static T[] ForEach<T>(this T[] array, Action<T, int> action) { (array.Length).Loop(i => action(array[i], i)); return array; }



        /// <summary> int i = args.start; i <= args.end; i += args.step </summary>
        public static MyVoid Loop(this (int start, int end, int step) args, Action<int> action) =>
            args.For(action);

        /// <summary>
        /// <para> int i = args.start; i <= args.end; i += args.step </para>
        /// <para> i => { if (condition) action(i); </para>
        /// </summary>
        public static MyVoid Loop(this (int start, int end, int step) args, Action<int> action, Predicate<int> condition = null) => 
            args.Loop(i => { 
                if (condition == null || condition(i))
                    action(i);
            });


        /// <summary> [start, end] </summary>
        public static MyVoid Loop(this (int start, int end) args, Action<int> action, Predicate<int> condition = null) =>
            (args.start, args.end, 1).Loop(action, condition);


        /// <summary> Loop n times </summary>
        public static MyVoid Loop(this int times, Action<int> action, Predicate<int> condition = null) =>
            (0, times - 1).Loop(action, condition);





    }
}
