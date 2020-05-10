using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MyLib_Csharp.CommonClass
{
    public static class MyAction
    {


        public delegate void ParamsAction(params object[] args);
        public static ParamsAction CallerLayer<T>(params T[] args) => (args2) => BodyLayer(args, args2);
        public static void BodyLayer<T>(T[] args, object[] args2) { /* ... */ }



        public static void Test()
        {
            CallerLayer(1, 2, 3)(4.5, 6.7, 8.9);
        }


    }
}
