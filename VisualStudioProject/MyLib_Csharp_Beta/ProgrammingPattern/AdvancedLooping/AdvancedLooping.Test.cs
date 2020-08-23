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
            refer.CombinationLoop(indexs => indexs.Println()).ln();

            string[] list = { "1", "2", "3", "4", "5" };

            // nCr //
            list.Loop_nC2((a, b) => (a, b).Println()).ln();
            list.Loop_nC3((a, b, c) => (a, b, c).Println()).ln();
            list.Loop_nC4((a, b, c, d) => (a, b, c, d).Println()).ln();
            
            // nPr //
            list.Loop_nP2((a, b) => (a, b).Println()).ln();
            list.Loop_nP3((a, b, c) => (a, b, c).Println()).ln();

        }

    }
}
