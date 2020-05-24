﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MyLib_Csharp.CommonClass
{
    public static class MyAction
    {

        public delegate void ParamsAction(params object[] args);
        public delegate void ParamsAction<IN>(params IN[] args);
        public delegate void RefAction<IN>(ref IN arg);
        public delegate void OutAction<IN>(out IN arg);
        public delegate void InAction<IN>(in IN arg);


        public delegate ParamsAction<RecursionParamsAction<T>> RecursionParamsAction<T>(params T[] args);
        public delegate RefAction<RecursionRefAction<T>> RecursionRefAction<T>(ref T arg);
        public delegate OutAction<RecursionOutAction<T>> RecursionOutAction<T>(out T arg);
        public delegate InAction<RecursionInAction<T>> RecursionInAction<T>(in T arg);

        public static ParamsAction CallerLayer<T>(params T[] args) => (args2) => BodyLayer(args, args2);
        public static void BodyLayer<T>(T[] args, object[] args2) { /* ... */ }



        public static void Test()
        {
            CallerLayer(1, 2, 3)(4.5, 6.7, 8.9);
        }


    }
}