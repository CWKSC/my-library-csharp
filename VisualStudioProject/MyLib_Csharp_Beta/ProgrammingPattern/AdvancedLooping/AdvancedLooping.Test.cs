using MyLib_Csharp_Beta.CommonMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.ProgrammingPattern
{
    public static partial class AdvancedLooping
    {

        public static void Test()
        {
            int[] refer = { 2, 3, 4 };
            refer.CombinationLoop(indexs => indexs.Println());
        }

    }
}
