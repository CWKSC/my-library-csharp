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
            "FFor<dynamic> return IEnumerable".Println();
            IEnumerable<dynamic[]> dynamicsFor = FFor(new (Func<dynamic[], dynamic> init, Func<dynamic, bool> condition, Func<dynamic, dynamic> step)[] {
                (v => 0,    i => i <= 2,   i => i + 1),
                (v => 1.2f, i => i <= 2f,  i => i + 0.5f),
                (v => 'a',  i => i <= 'c', i => ++i)
            });
            foreach (var indexs in dynamicsFor)
            {
                indexs.Println();
            }
            "".ln();

            "FFor<int> return IEnumerable".Println();
            static bool condition(int i) => i < 5;
            static int step(int i) => i + 1;
            IEnumerable<int[]> indexsList = FFor(new (Func<int[], int> init, Func<int, bool> condition, Func<int, int> step) [] {
                (v => 0,        condition, step),
                (v => v[0] + 1, condition, step),
                (v => v[1] + 1, condition, step)
            });
            foreach(var indexs in indexsList)
            {
                indexs.Println();
            }
            "".ln();

            "FFor<int> with ref variable outside".Println();
            int[] variables = new int[3];
            FFor(ref variables, new (Func<int> init, Func<int, bool> condition, Func<int, int> step)[]{
                (() => 0,                condition, step),
                (() => variables[0] + 1, condition, step),
                (() => variables[1] + 1, condition, step)
            },
                result => result.Println()
            );
            "".ln();


            "CombinationLoop, refer = { 2, 3, 4 }".Println();
            int[] refer = { 2, 3, 4 };
            refer.CombinationLoop(indexs => indexs.Println()).ln();


            string[] list = { "a", "b", "c", "d", "e" };

            // nCr //
            "nCr with array string[] list = { \"a\", \"b\", \"c\", \"d\", \"e\" }".Println();
            "nC2".Println();
            list.Loop_nC2((a, b) => (a, b).Println()).ln();
            "nC3".Println();
            list.Loop_nC3((a, b, c) => (a, b, c).Println()).ln();
            "nC4".Println();
            list.Loop_nC4((a, b, c, d) => (a, b, c, d).Println()).ln();

            "nCr (NCR(6, 4), NCR(6, 5), NCR(6, 6)".Println();
            ApplyFunction.ApplyFunc(v => {
                foreach (var indexs in v)
                    Printing.Println(indexs);
                "".ln();
            },
                NCR(6, 4),
                NCR(6, 5),
                NCR(6, 6)
            );

            // NPermutation //
            "NPermutation 1, 2, 3, 4".Println();
            ApplyFunction.ApplyFunc(v => {
                foreach (var indexs in v)
                    Printing.Println(indexs);
                "".ln();
            },
                NPermutation(1),
                NPermutation(2),
                NPermutation(3),
                NPermutation(4)
            );

            // nPr //
            "nPr (NPR(4, 1), NPR(4, 2), NPR(4, 3), NPR(4, 4))".Println();
            ApplyFunction.ApplyFunc(v => {
                foreach (var indexs in v)
                    Printing.Println(indexs);
                "".ln();
            },
                NPR(4, 1),
                NPR(4, 2),
                NPR(4, 3),
                NPR(4, 4)
            );

        }
        /*
        FFor<dynamic> return IEnumerable
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

        FFor<int> return IEnumerable
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

        FFor<int> with ref variable outside
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

        CombinationLoop, refer = { 2, 3, 4 }
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

        nCr with array string[] list = { "a", "b", "c", "d", "e" }
        nC2
        (a, b)
        (a, c)
        (a, d)
        (a, e)
        (b, c)
        (b, d)
        (b, e)
        (c, d)
        (c, e)
        (d, e)

        nC3
        (a, b, c)
        (a, b, d)
        (a, b, e)
        (a, c, d)
        (a, c, e)
        (a, d, e)
        (b, c, d)
        (b, c, e)
        (b, d, e)
        (c, d, e)

        nC4
        (a, b, c, d)
        (a, b, c, e)
        (a, b, d, e)
        (a, c, d, e)
        (b, c, d, e)

        nCr (NCR(6, 4), NCR(6, 5), NCR(6, 6)
        0, 1, 2, 3
        0, 1, 2, 4
        0, 1, 2, 5
        0, 1, 3, 4
        0, 1, 3, 5
        0, 1, 4, 5
        0, 2, 3, 4
        0, 2, 3, 5
        0, 2, 4, 5
        0, 3, 4, 5
        1, 2, 3, 4
        1, 2, 3, 5
        1, 2, 4, 5
        1, 3, 4, 5
        2, 3, 4, 5

        0, 1, 2, 3, 4
        0, 1, 2, 3, 5
        0, 1, 2, 4, 5
        0, 1, 3, 4, 5
        0, 2, 3, 4, 5
        1, 2, 3, 4, 5

        0, 1, 2, 3, 4, 5

        NPermutation 1, 2, 3, 4
        0

        0, 1
        1, 0

        0, 1, 2
        0, 2, 1
        1, 0, 2
        1, 2, 0
        2, 1, 0
        2, 0, 1

        0, 1, 2, 3
        0, 1, 3, 2
        0, 2, 1, 3
        0, 2, 3, 1
        0, 3, 2, 1
        0, 3, 1, 2
        1, 0, 2, 3
        1, 0, 3, 2
        1, 2, 0, 3
        1, 2, 3, 0
        1, 3, 2, 0
        1, 3, 0, 2
        2, 1, 0, 3
        2, 1, 3, 0
        2, 0, 1, 3
        2, 0, 3, 1
        2, 3, 0, 1
        2, 3, 1, 0
        3, 1, 2, 0
        3, 1, 0, 2
        3, 2, 1, 0
        3, 2, 0, 1
        3, 0, 2, 1
        3, 0, 1, 2

        nPr (NPR(4, 1), NPR(4, 2), NPR(4, 3), NPR(4, 4))
        0
        1
        2
        3

        0, 1
        1, 0
        0, 2
        2, 0
        0, 3
        3, 0
        1, 2
        2, 1
        1, 3
        3, 1
        2, 3
        3, 2

        0, 1, 2
        0, 2, 1
        1, 0, 2
        1, 2, 0
        2, 1, 0
        2, 0, 1
        0, 1, 3
        0, 3, 1
        1, 0, 3
        1, 3, 0
        3, 1, 0
        3, 0, 1
        0, 2, 3
        0, 3, 2
        2, 0, 3
        2, 3, 0
        3, 2, 0
        3, 0, 2
        1, 2, 3
        1, 3, 2
        2, 1, 3
        2, 3, 1
        3, 2, 1
        3, 1, 2

        0, 1, 2, 3
        0, 1, 3, 2
        0, 2, 1, 3
        0, 2, 3, 1
        0, 3, 2, 1
        0, 3, 1, 2
        1, 0, 2, 3
        1, 0, 3, 2
        1, 2, 0, 3
        1, 2, 3, 0
        1, 3, 2, 0
        1, 3, 0, 2
        2, 1, 0, 3
        2, 1, 3, 0
        2, 0, 1, 3
        2, 0, 3, 1
        2, 3, 0, 1
        2, 3, 1, 0
        3, 1, 2, 0
        3, 1, 0, 2
        3, 2, 1, 0
        3, 2, 0, 1
        3, 0, 2, 1
        3, 0, 1, 2
        */

    }
}
