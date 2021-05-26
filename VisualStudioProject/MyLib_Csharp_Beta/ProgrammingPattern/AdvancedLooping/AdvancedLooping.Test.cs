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
            "FFor".Println();
            FFor(new (dynamic variable, Func<dynamic, bool> condition, Func<dynamic, dynamic> step)[]{
                (0,    i => i <= 2,   i => i + 1),
                (1.2f, i => i <= 2f,  i => i + 0.5f),
                ('a',  i => i <= 'c', i => ++i)
            },
                result => result.Println()
            );
            "".ln();


            "FFor with ref variable outside".Println();
            dynamic[] variables = new dynamic[3];
            static bool    condition(dynamic i) => i < 5;
            static dynamic step     (dynamic i) => i + 1;
            FFor(ref variables, new (Func<dynamic> init, Func<dynamic, bool> condition, Func<dynamic, dynamic> step)[]{
                (() => 0,                condition, step),
                (() => variables[0] + 1, condition, step),
                (() => variables[1] + 1, condition, step)
            },
                result => result.Println()
            );
            "".ln();


            "CombinationLoop".Println();
            int[] refer = { 2, 3, 4 };
            refer.CombinationLoop(indexs => indexs.Println()).ln();


            string[] list = { "1", "2", "3", "4", "5" };

            // nCr //
            "nC2".Println();
            list.Loop_nC2((a, b) => (a, b).Println()).ln();
            "nC3".Println();
            list.Loop_nC3((a, b, c) => (a, b, c).Println()).ln();
            "nC4".Println();
            list.Loop_nC4((a, b, c, d) => (a, b, c, d).Println()).ln();

            // nPr //
            "nP2".Println();
            list.Loop_nP2((a, b) => (a, b).Println()).ln();
            "nP3".Println();
            list.Loop_nP3((a, b, c) => (a, b, c).Println()).ln();
            return;
            "nPr".Println();
            list.Loop_nPr(2, arr => arr.Println());

        }
        /*
        FFor
        0, 1.2, a
        0, 1.2, b
        0, 1.2, c
        0, 1.7, a
        0, 1.7, b
        0, 1.7, c
        1, 1.2, a
        1, 1.2, b
        1, 1.2, c
        1, 1.7, a
        1, 1.7, b
        1, 1.7, c
        2, 1.2, a
        2, 1.2, b
        2, 1.2, c
        2, 1.7, a
        2, 1.7, b
        2, 1.7, c

        FFor with ref variable outside
        0, 1, 2
        0, 1, 3
        0, 1, 4
        0, 2, 3
        0, 2, 4
        0, 3, 4
        1, 2, 3
        1, 2, 4
        1, 3, 4
        2, 3, 4

        CombinationLoop
        0, 0, 0
        0, 0, 1
        0, 0, 2
        0, 0, 3
        0, 1, 0
        0, 1, 1
        0, 1, 2
        0, 1, 3
        0, 2, 0
        0, 2, 1
        0, 2, 2
        0, 2, 3
        1, 0, 0
        1, 0, 1
        1, 0, 2
        1, 0, 3
        1, 1, 0
        1, 1, 1
        1, 1, 2
        1, 1, 3
        1, 2, 0
        1, 2, 1
        1, 2, 2
        1, 2, 3

        nC2
        (1, 2)
        (1, 3)
        (1, 4)
        (1, 5)
        (2, 3)
        (2, 4)
        (2, 5)
        (3, 4)
        (3, 5)
        (4, 5)

        nC3
        (1, 2, 3)
        (1, 2, 4)
        (1, 2, 5)
        (1, 3, 4)
        (1, 3, 5)
        (1, 4, 5)
        (2, 3, 4)
        (2, 3, 5)
        (2, 4, 5)
        (3, 4, 5)

        nC4
        (1, 2, 3, 4)
        (1, 2, 3, 5)
        (1, 2, 4, 5)
        (1, 3, 4, 5)
        (2, 3, 4, 5)

        nP2
        (1, 1)
        (1, 2)
        (1, 3)
        (1, 4)
        (1, 5)
        (2, 1)
        (2, 2)
        (2, 3)
        (2, 4)
        (2, 5)
        (3, 1)
        (3, 2)
        (3, 3)
        (3, 4)
        (3, 5)
        (4, 1)
        (4, 2)
        (4, 3)
        (4, 4)
        (4, 5)
        (5, 1)
        (5, 2)
        (5, 3)
        (5, 4)
        (5, 5)

        nP3
        (1, 1, 1)
        (1, 1, 2)
        (1, 1, 3)
        (1, 1, 4)
        (1, 1, 5)
        (1, 2, 1)
        (1, 2, 2)
        (1, 2, 3)
        (1, 2, 4)
        (1, 2, 5)
        (1, 3, 1)
        (1, 3, 2)
        (1, 3, 3)
        (1, 3, 4)
        (1, 3, 5)
        (1, 4, 1)
        (1, 4, 2)
        (1, 4, 3)
        (1, 4, 4)
        (1, 4, 5)
        (1, 5, 1)
        (1, 5, 2)
        (1, 5, 3)
        (1, 5, 4)
        (1, 5, 5)
        (2, 1, 1)
        (2, 1, 2)
        (2, 1, 3)
        (2, 1, 4)
        (2, 1, 5)
        (2, 2, 1)
        (2, 2, 2)
        (2, 2, 3)
        (2, 2, 4)
        (2, 2, 5)
        (2, 3, 1)
        (2, 3, 2)
        (2, 3, 3)
        (2, 3, 4)
        (2, 3, 5)
        (2, 4, 1)
        (2, 4, 2)
        (2, 4, 3)
        (2, 4, 4)
        (2, 4, 5)
        (2, 5, 1)
        (2, 5, 2)
        (2, 5, 3)
        (2, 5, 4)
        (2, 5, 5)
        (3, 1, 1)
        (3, 1, 2)
        (3, 1, 3)
        (3, 1, 4)
        (3, 1, 5)
        (3, 2, 1)
        (3, 2, 2)
        (3, 2, 3)
        (3, 2, 4)
        (3, 2, 5)
        (3, 3, 1)
        (3, 3, 2)
        (3, 3, 3)
        (3, 3, 4)
        (3, 3, 5)
        (3, 4, 1)
        (3, 4, 2)
        (3, 4, 3)
        (3, 4, 4)
        (3, 4, 5)
        (3, 5, 1)
        (3, 5, 2)
        (3, 5, 3)
        (3, 5, 4)
        (3, 5, 5)
        (4, 1, 1)
        (4, 1, 2)
        (4, 1, 3)
        (4, 1, 4)
        (4, 1, 5)
        (4, 2, 1)
        (4, 2, 2)
        (4, 2, 3)
        (4, 2, 4)
        (4, 2, 5)
        (4, 3, 1)
        (4, 3, 2)
        (4, 3, 3)
        (4, 3, 4)
        (4, 3, 5)
        (4, 4, 1)
        (4, 4, 2)
        (4, 4, 3)
        (4, 4, 4)
        (4, 4, 5)
        (4, 5, 1)
        (4, 5, 2)
        (4, 5, 3)
        (4, 5, 4)
        (4, 5, 5)
        (5, 1, 1)
        (5, 1, 2)
        (5, 1, 3)
        (5, 1, 4)
        (5, 1, 5)
        (5, 2, 1)
        (5, 2, 2)
        (5, 2, 3)
        (5, 2, 4)
        (5, 2, 5)
        (5, 3, 1)
        (5, 3, 2)
        (5, 3, 3)
        (5, 3, 4)
        (5, 3, 5)
        (5, 4, 1)
        (5, 4, 2)
        (5, 4, 3)
        (5, 4, 4)
        (5, 4, 5)
        (5, 5, 1)
        (5, 5, 2)
        (5, 5, 3)
        (5, 5, 4)
        (5, 5, 5)
        */

    }
}
