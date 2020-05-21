using MyLib_Csharp.CommonClass;
using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using static MyLib_Csharp.CommonClass.MyAction;
using static MyLib_Csharp.CommonClass.MyFunction;

namespace MyLib_Csharp
{
    class Program
    {


        public static RefFunc<int, RefFunc<int, int>> Foo(ref int input)
        {
            return (ref int x) => Foo(ref x);
        }


        public static void Main(string[] args)
        {


        }

    }

}
