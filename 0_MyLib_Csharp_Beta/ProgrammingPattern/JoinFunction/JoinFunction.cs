using MyLib_Csharp_Beta.CommonType;
using System;

namespace MyLib_Csharp_Beta.ProgrammingPattern
{
    public static partial class JoinFunction
    {

        /// <summary> [start, end] </summary>
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



        /// <summary> [0, times - 1] </summary>
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



        public static T[] JoinFunc<T>(this T[] array, MyAction<T, int> work, MyAction<T, int> joinAction)
        {
            array.Length.JoinFunc(
                (MyAction<int>)(i => work.Invoke(array[i], i) ),
                (MyAction<int>)(i => joinAction.Invoke(array[i], i)) );
            return array;
        }




    }
}
