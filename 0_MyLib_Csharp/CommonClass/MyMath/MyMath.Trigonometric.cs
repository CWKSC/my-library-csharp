using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;



namespace MyLib_Csharp.CommonClass
{
    public partial class MyMath
    {

        public static void TrigonometricTest()
        {
            Console.WriteLine("Sin(30) = " + Sin(30));
            Console.WriteLine("Cos(60) = " + Sin(30));
            Console.WriteLine("Tan(45) = " + Sin(30));
            Console.WriteLine();
        }

        public static double Sin(double degrees) => Math.Sin(DegreesToRadians(degrees));
        public static double Cos(double degrees) => Math.Cos(DegreesToRadians(degrees));
        public static double Tan(double degrees) => Math.Tan(DegreesToRadians(degrees));
        public static double Atan2(Vector2 point) => Math.Atan2(point.Y, point.X);
        public static double Atan2(List<double> list) => Math.Atan2(list[1], list[0]);

    }
}
