using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.Tool
{
    public partial class LagrangeInterpolationGenerator
    {

        public static void Test()
        {
            Run((2, 7), (0, -9), (3, -3), (4, 6), (-5, 3), (1, 5), (-6, 2));
        }

    }
}
