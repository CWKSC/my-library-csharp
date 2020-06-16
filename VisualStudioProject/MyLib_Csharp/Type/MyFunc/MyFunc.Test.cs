using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.Type
{
    public partial class MyFunc
    {

        public static void Foo(Func<int, bool> func) => func(1);
        public static void Foo(Func<bool> func) => func();


        public static void Foo(MyFunc<int, bool> func) => func.Invoke(1);

        public static void Test()
        {
            Func<int, int> func = i => 1;
            MyFunc<int, int> myFunc = func;
        }


    }
}
