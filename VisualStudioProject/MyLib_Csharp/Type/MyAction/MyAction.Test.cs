using System;
using System.Collections.Generic;
using System.Text;

using static MyLib_Csharp.CommonClass.MyAction;

namespace MyLib_Csharp.Type
{
    public partial class MyAction<T>
    {

        public static void Foo(MyAction<int> myAction)
        {
            myAction.actionT(1);
        }



        public static void Test()
        {
            Foo(_(() => { }));
            Foo(_<int>(i => { }));
            MyAction<int> myAction = _<int>(i => { });
        }


    }
}
