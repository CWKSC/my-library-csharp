using MyLib_Csharp_Beta.CommonMethod;
using MyLib_Csharp_Beta.CommonType;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.ProgrammingPattern
{
    /// <summary>
    /// JoinPrint will be implemented based on JoinStr
    /// There are three main functions here:
    /// <code> string JoinPrint(this (int start, int end) args,MyFunc&lt;int, string&gt; work, MyFunc&lt;int, string&gt; join) </code>
    /// <code> string JoinPrint(this int times, MyFunc&lt;int, string&gt; work, MyFunc&lt;int, string&gt; join) </code>
    /// <code> string JoinPrint&lt;T&gt;(this T[] array, MyFunc&lt;T, int, string&gt; work, MyFunc&lt;T, int, string&gt; join) </code>
    /// </summary>
    public static partial class JoinPrintString
    {

        /// <summary>
        /// 
        /// </summary>
        public static string JoinPrint(this (int start, int end) args, MyFunc<int, string> work, MyFunc<int, string> join) => 
            args.JoinStr(work, join).Print();
        public static string JoinPrint(this (int start, int end) args, Func<int, string> work, MyFunc<int, string> join) =>
            args.JoinPrint((MyFunc<int, string>)work, join);
        public static string JoinPrint(this (int start, int end) args, MyFunc<int, string> work, Func<int, string> join) =>
            args.JoinPrint(work, (MyFunc<int, string>)join);
        public static string JoinPrint(this (int start, int end) args, Func<int, string> work, Func<int, string> join) =>
            args.JoinPrint((MyFunc<int, string>)work, (MyFunc<int, string>)join);


        /// <summary>
        /// 
        /// </summary>
        public static string JoinPrint(this int times, MyFunc<int, string> work, MyFunc<int, string> join) =>
            times.JoinStr(work, join).Print();
        public static string JoinPrint(this int times, Func<int, string> work, MyFunc<int, string> join) =>
            times.JoinPrint((MyFunc<int, string>)work, join);
        public static string JoinPrint(this int times, MyFunc<int, string> work, Func<int, string> join) =>
            times.JoinPrint(work, (MyFunc<int, string>)join);
        public static string JoinPrint(this int times, Func<int, string> work, Func<int, string> join) =>
            times.JoinPrint((MyFunc<int, string>)work, (MyFunc<int, string>)join);



        /// <summary>
        /// 
        /// </summary>
        public static string JoinPrint<T>(this T[] array, MyFunc<T, int, string> work, MyFunc<T, int, string> join) =>
            array.JoinStr(work, join).Print();
        public static string JoinPrint<T>(this T[] array, Func<T, int, string> work, MyFunc<T, int, string> join) =>
            array.JoinPrint((MyFunc<T, int, string>)work, join);
        public static string JoinPrint<T>(this T[] array, MyFunc<T, int, string> work, Func<T, int, string> join) =>
            array.JoinPrint(work, (MyFunc<T, int, string>)join);
        public static string JoinPrint<T>(this T[] array, Func<T, int, string> work, Func<T, int, string> join) =>
            array.JoinPrint((MyFunc<T, int, string>)work, (MyFunc<T, int, string>)join);



    }
}
