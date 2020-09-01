using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.ProgrammingPattern
{
    public static partial class HigherOrderFunction
    {


        public static void Test()
        {
#pragma warning disable IDE0039 // 使用區域函式
            Func<int, string> intToString = x => "42";
            Func<string, bool> stringToBool = x => true;
#pragma warning restore IDE0039 // 使用區域函式

            CombinationFunc(stringToBool, intToString)(1);
        }




    }
}
