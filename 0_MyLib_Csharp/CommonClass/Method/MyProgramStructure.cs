using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.CommonClass.ForFunction
{
    public static partial class MyProgramStructure
    {


        public static bool If(this bool condition, Action action)
        {
            if (condition) action();
            return condition;
        }

        public static bool Else(this bool condition, Action action)
        {
            if (!condition) action();
            return condition;
        }


    }
}
