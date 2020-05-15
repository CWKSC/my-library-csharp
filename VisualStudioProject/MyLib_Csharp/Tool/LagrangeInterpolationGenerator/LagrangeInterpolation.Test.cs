using System;

namespace MyLib_Csharp.Tool
{
    public partial class LagrangeInterpolation
    {

        public static void Test()
        {
            (double x, double y)[] points = { (2, 7), (0, -9), (3, -3), (4, 6), (-5, 3), (1, 5), (-6, 2) };
            Generate(points);
            Console.WriteLine();
            Generate3(points);
            Console.WriteLine();
            Generate4(points);
            Console.WriteLine();
            Generate5(points);
            Console.WriteLine();
            Console.WriteLine(Calc(5, points));
        }

    }
}
