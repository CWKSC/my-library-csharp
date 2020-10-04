using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.ProgrammingPattern
{
    public static partial class HigherOrderFunction
    {


#pragma warning disable IDE0039 // 使用區域函式

        public static void Test()
        {
            Func<int, string> intToString = x => "42";
            Func<string, bool> stringToBool = x => true;

            CombinationFunc(stringToBool, intToString)(1);
        }

#pragma warning restore IDE0039 // 使用區域函式



    }
}
