using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.ProgrammingPattern
{
    public static partial class ApplyFunction
    {

        public static dynamic[] ApplyFunc(dynamic Func, params dynamic[] args) =>
            args.Loop((ele, i) => Func(ele));

        public static dynamic[] ApplyFunc(Action<dynamic> Func, params dynamic[] args) =>
            args.Loop((ele, i) => Func(ele));



    }
}
