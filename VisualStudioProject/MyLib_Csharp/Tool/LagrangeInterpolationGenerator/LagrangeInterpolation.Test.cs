using System;

using static MyLib_Csharp.CommonClass.MyPrint;

namespace MyLib_Csharp.Tool
{
    public partial class LagrangeInterpolation
    {

        public static void Test()
        {
            (double x, double y)[] points = { (2, 7), (0, -9), (3, -3), (4, 6), (-5, 3), (1, 5), (-6, 2) };
            Generate(points);
            ln();
            Generate3(points);
            ln();
            Generate4(points);
            ln();
            Generate(points);
            ln();
            Calc(5, points).Println();
        }

    }
}
