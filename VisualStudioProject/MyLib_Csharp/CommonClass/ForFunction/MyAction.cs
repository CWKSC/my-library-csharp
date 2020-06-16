using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MyLib_Csharp.CommonClass
{
    public static class MyAction
    {

        public static Action Nothing = () => { };

        public delegate void ParamsAction(params object[] args);
        public delegate void ParamsAction<IN>(params IN[] args);
        public delegate void RefAction<IN>(ref IN arg);
        public delegate void OutAction<IN>(out IN arg);
        public delegate void InAction<IN>(in IN arg);




        public static Action<T> _<T>(Action<T> action) => action;
        public static Action _(Action action) => action;





        public static ParamsAction CallerLayer<T>(params T[] args) => (args2) => BodyLayer(args, args2);
        public static void BodyLayer<T>(T[] args, object[] args2) {
            args.Println();
            args2.Println();
        }

        public static void Test()
        {
            CallerLayer(1, 2, 3)(4.5, 6.7, 8.9);
        }


    }
}
