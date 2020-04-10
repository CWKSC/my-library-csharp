using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.CommonClass
{
    public partial class MyMath
    {

        public static void Test()
        {

            ConvertTest();

            PrimeTest();

            CalculusTest();

            // Here start the performance test //

            // Test Setting //
            MyTest.SetTestSetting();
            Console.WriteLine();

            PrimePerformanceTest();




        }



    }
}
