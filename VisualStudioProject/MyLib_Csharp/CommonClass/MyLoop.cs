using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.CommonClass
{
    public static class MyLoop
    {


        public static void Loop(this int times, Action action)
        {
            for (int i = 0; i < times; i++)
                action();
        }


    }
}
