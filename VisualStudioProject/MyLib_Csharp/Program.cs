using MyLib_Csharp.CommonClass;
using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using static MyLib_Csharp.CommonClass.MyAction;
using static MyLib_Csharp.CommonClass.MyFunction;

namespace MyLib_Csharp
{
    class Program
    {

        public static Func<T, int> GetFunc<T>(Func<T, int> func) => func;

        public static int Work(int input) { return 1; }


        public static void Main(string[] args)
        {
            Delegate @delegate = Delegate.CreateDelegate(typeof(int));
        }

    }

}
