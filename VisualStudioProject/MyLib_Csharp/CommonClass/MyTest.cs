using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MyLib_Csharp.CommonClass
{
    class MyTest
    {

        public static void TestExecutionTime<Input>(Action<Input[]> action, params Input[] input)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            action(input);
            stopwatch.Stop();
            Console.WriteLine(action.Method.Name + " run " + stopwatch.Elapsed.TotalMilliseconds + " ms");
        }
        public static Output TestExecutionTime<Input, Output>(Func<Input[], Output> func, params Input[] input)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Output output = func(input);
            stopwatch.Stop();
            Console.WriteLine(func.Method.Name + " run " + stopwatch.Elapsed.TotalMilliseconds + " ms");
            return output;
        }


    }
}
