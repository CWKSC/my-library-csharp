using System;
using System.Collections.Generic;
using System.Text;

using static MyLib_Csharp.CommonClass.MyCalculus;
using static MyLib_Csharp.CommonClass.MyPrime;

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
