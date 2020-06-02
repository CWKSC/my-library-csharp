using System;
using System.Collections.Generic;
using System.Text;

using static MyLib_Csharp.CommonClass.MyPrint;

namespace MyLib_Csharp.CommonClass
{
    public static partial class MyAlgorithm
    {
        public static partial class MySort
        {
            public static void Test()
            {
                const int dataLength = 10;
                const int dataMin = -500;
                const int dataMax = 500;
                int[] allRangeIntArray = MyArray.GenerateRandIntArray(dataLength);
                int[] inRangeIntArray = MyArray.GenerateRandIntArray(dataLength, dataMin, dataMax);

                MyTest.SetTestSetting();

                /* Uncomment to see sorting flow
                    * many Print and so dataLength = 10 is suitable 
                    * (add "*" here to uncomment quickly) -->*/

                "Start sorting flow / correctness test".lnPrintln();

                // BubbleSort //
                MyTest.TestExecutionTime(BubbleSort_Debug, allRangeIntArray).PrintIsSorted_ascending();
                MyTest.TestExecutionTime(BubbleSort_Debug, inRangeIntArray).PrintIsSorted_ascending();
                ln();
                // SelectionSort //
                MyTest.TestExecutionTime(SelectionSort_Debug, allRangeIntArray).PrintIsSorted_ascending();
                MyTest.TestExecutionTime(SelectionSort_Debug, inRangeIntArray).PrintIsSorted_ascending();
                ln();
                // CountingSort //
                MyTest.TestExecutionTime(CountingSort_Debug, inRangeIntArray, dataMin, dataMax).PrintIsSorted_ascending();
                ln();
                // QuickSort //
                MyTest.TestExecutionTime(QuickSort_Debug, allRangeIntArray).Print().PrintIsSorted_ascending();
                MyTest.TestExecutionTime(QuickSort_Debug, inRangeIntArray).Print().PrintIsSorted_ascending();
                ln();

                //*/

                // BubbleSort //
                MyTest.TestExecutionTime(BubbleSort, allRangeIntArray);
                MyTest.TestExecutionTime(BubbleSort, inRangeIntArray);
                // SelectionSort //
                MyTest.TestExecutionTime(SelectionSort, allRangeIntArray);
                MyTest.TestExecutionTime(SelectionSort, inRangeIntArray);
                // CountingSort //
                MyTest.TestExecutionTime(CountingSort, inRangeIntArray, dataMin, dataMax);

                // QuickSort //
                MyTest.TestExecutionTime(QuickSort, allRangeIntArray);
                MyTest.TestExecutionTime(QuickSort, inRangeIntArray);
            }

        }
    }
}
