using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.Tool
{
    public partial class LagrangeInterpolation
    {

        public static void Test()
        {
            Generate((2, 7), (0, -9), (3, -3), (4, 6), (-5, 3), (1, 5), (-6, 2));
            Console.WriteLine();
            Generate3((2, 7), (0, -9), (3, -3), (4, 6), (-5, 3), (1, 5), (-6, 2));
            Console.WriteLine();
            Generate4((2, 7), (0, -9), (3, -3), (4, 6), (-5, 3), (1, 5), (-6, 2));
            Console.WriteLine();
            Console.WriteLine(Calc(5, (2, 7), (0, -9), (3, -3), (4, 6), (-5, 3), (1, 5), (-6, 2)));
        }

    }
}
