using MyLib_Csharp_Beta.CommonType;
using System;

namespace MyLib_Csharp_Beta.ProgrammingPattern
{
    public static partial class JoinFunction
    {

        /// <summary>
        /// JoinFunc for start to end, range is [start, end]
        /// <code>(1, 5).JoinFunc(i => i.Print(), _ => ", ".Print()).ln();</code>
        /// Output:
        /// <code>1, 2, 3, 4, 5</code>
        /// </summary>
        public static (int start, int end) JoinFunc(this (int start, int end) args, MyAction<int> work, MyAction<int> joinAction)
        {
            work.Invoke(args.start);
            (args.start + 1, args.end).Loop(i =>
            {
                joinAction.Invoke(i);
                work.Invoke(i);
            });

            // [Another Version]
            // 
            //(args.start, args.end - 1).Loop(i =>
            //{
            //    work.Invoke(i);
            //    joinAction.Invoke(i);
            //});
            //work.Invoke(args.end);

            return args;
        }
        public static (int start, int end) JoinFunc(this (int start, int end) args, Action<int> work, MyAction<int> joinAction) =>
            args.JoinFunc((MyAction<int>)work, joinAction);
        public static (int start, int end) JoinFunc(this (int start, int end) args, MyAction<int> work, Action<int> joinAction) =>
            args.JoinFunc(work, (MyAction<int>)joinAction);
        public static (int start, int end) JoinFunc(this (int start, int end) args, Action<int> work, Action<int> joinAction) =>
            args.JoinFunc((MyAction<int>)work, (MyAction<int>)joinAction);

        // [Some Note here for JoinFunc]
        // 
        // , 1, 2, 3
        // 
        // (0, array.length - 1).Loop(i => {
        //     ", ".Print();
        //     array[i].Print();
        // })
        // 
        // 
        // 1, 2, 3, 
        // 
        // (0, array.length - 1).Loop(i => {
        //     array[i].Print();
        //     ", ".Print();
        // })
        // 
        // f(x) = print x
        // g(x) = print ", "
        //
        // /*g(0)*/ f(0) g(1) f(1) g(2) f(2) ... g(i) f(i)
        // f(0) g(0) f(1) g(1) f(2) g(2) ... f(i) /*g(i)*/



        /// <summary>
        /// JoinFunc for n times, range is [0, times - 1]
        /// <code>3.JoinFunc(i => i.Print(), _ => ", ".Print()).ln();</code>
        /// Output:
        /// <code>0, 1, 2</code>
        /// </summary>
        public static int JoinFunc(this int times, MyAction<int> work, MyAction<int> joinAction)
        {
            (0, times - 1).JoinFunc(work, joinAction);
            return times;
        }
        public static int JoinFunc(this int times, Action<int> work, MyAction<int> joinAction) =>
            times.JoinFunc((MyAction<int>)work, joinAction);
        public static int JoinFunc(this int times, MyAction<int> work, Action<int> joinAction) =>
            times.JoinFunc(work, (MyAction<int>)joinAction);
        public static int JoinFunc(this int times, Action<int> work, Action<int> joinAction) =>
            times.JoinFunc((MyAction<int>)work, (MyAction<int>)joinAction);


        /// <summary> 
        /// JoinFunc for array
        /// <code>int[] array = { 12, 34, 56, 78, 910 }; <br />
        /// array.JoinFunc((ele, _) => ele.Print(), (_, __) => ", ".Print()).ln();</code>
        /// Output:
        /// <code>12, 34, 56, 78, 910</code>
        /// </summary>
        public static T[] JoinFunc<T>(this T[] array, MyAction<T, int> work, MyAction<T, int> joinAction)
        {
            array.Length.JoinFunc(
                (MyAction<int>)(i => work.Invoke(array[i], i) ),
                (MyAction<int>)(i => joinAction.Invoke(array[i], i)) );
            return array;
        }
        public static T[] JoinFunc<T>(this T[] array, Action<T, int> work, MyAction<T, int> joinAction) =>
            array.JoinFunc((MyAction<T, int>)work, joinAction);
        public static T[] JoinFunc<T>(this T[] array, MyAction<T, int> work, Action<T, int> joinAction) =>
            array.JoinFunc(work, (MyAction<T, int>)joinAction);
        public static T[] JoinFunc<T>(this T[] array, Action<T, int> work, Action<T, int> joinAction) =>
            array.JoinFunc((MyAction<T, int>)work, (MyAction<T, int>)joinAction);





    }
}
