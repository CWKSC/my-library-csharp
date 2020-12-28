using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.CommonMethod
{
    public static partial class MyTuple
    {

        /// <summary>
        /// (3, 4).Size() // 2
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public static int Size(this (int start, int end) arg) => arg.end - arg.start + 1;


    }
}
