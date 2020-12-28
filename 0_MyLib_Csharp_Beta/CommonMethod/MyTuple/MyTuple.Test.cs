using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.CommonMethod
{
    public static partial class MyTuple
    {

        public static void Test()
        {
            ("(3, 4) size : " + (3, 4).Size()).Println();
        }


    }
}
