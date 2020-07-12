using MyLib_Csharp_Beta.CommonType;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.ProgrammingPattern
{
    public static partial class ProgramStructure
    {

        public static MyVoid ReturnVoid() => MyVoid.instance;

        public static MyVoid Start() => ReturnVoid();

        public static MyVoid End() => ReturnVoid();

        public static MyVoid ReturnVoid(Action action)
        {
            action();
            return ReturnVoid();
        }


        public static T Delcare<T>(out T variable, T init = default) => 
            variable = init;

        public static T Delcare<Any, T>(this Any _, out T variable, T init = default) =>
            variable = init;

        public static T Expression<Any, T>(this Any _, T expression) => 
            expression;

        public static R Call<T, R>(this T input, Func<T, R> func) => 
            func(input);


        public static MyVoid Call<Any, R>(this Any _, Func<R> func) =>
            ReturnVoid(() => func());


        public static bool If(this bool condition, Action action)
        {
            if (condition) action();
            return condition;
        }

        public static bool Else(this bool condition, Action action) =>
            If(!condition, action);


        public static MyVoid For(this (int start, int end, int step) args, Action<int> action) =>
            ReturnVoid(() =>
            {
                for (int i = args.start; i <= args.end; i += args.step)
                    action(i);
            });
         
        public static MyVoid While(this Func<bool> condition, Action action) =>
            ReturnVoid(() =>
            {
                while (condition())
                    action();
            });



    }
}
