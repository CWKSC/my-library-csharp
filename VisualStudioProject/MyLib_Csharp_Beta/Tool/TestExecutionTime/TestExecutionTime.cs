using MyLib_Csharp_Beta.CommonMethod;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace MyLib_Csharp_Beta.Tool
{
    public static partial class TestExecutionTime
    {

        public static bool non_setup = true;

        public static void Setup()
        {
            SetProcessPriority();
            Warmup();
        }

        public static void SetProcessPriority()
        {
            // Reference : https://www.codeproject.com/Articles/61964/Performance-Tests-Precise-Run-Time-Measurements-wi
            Process.GetCurrentProcess().ProcessorAffinity = new IntPtr(2); // Uses the second Core or Processor for the Test
            Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;  // Prevents "Normal" processes 
                                                                                    // from interrupting Threads
            Thread.CurrentThread.Priority = ThreadPriority.Highest;     // Prevents "Normal" Threads 
                                                                        // from interrupting this thread
        }

        public static void Warmup()
        {
            "Warmup ... ".Print();
            Stopwatch stopwatch = Stopwatch.StartNew();
            stopwatch.Start();
            while (stopwatch.ElapsedMilliseconds < 1200) ;
            stopwatch.Stop();
            "finish".Println();
        }

        public static void Run(this Action action, string name = null)
        {
            if (non_setup)
            {
                non_setup = false;
                Setup();
            }
            Stopwatch stopwatch = Stopwatch.StartNew();
            action();
            stopwatch.Stop();
            Console.WriteLine((name ?? action.Method.Name).PadRight(20, ' ') +
                "\trun " + stopwatch.Elapsed.TotalMilliseconds.ToString().PadRight(10, ' ') + " ms, " +
                stopwatch.ElapsedTicks.ToString().PadRight(10, ' ') + " ticks");
        }


    }
}
