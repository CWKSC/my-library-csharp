using MyLib_Csharp.DataStructure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MyLib_Csharp.CommonClass
{
    public static class MyTest
    {

        public static void Warmup(this Action action)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            stopwatch.Start();
            while (stopwatch.ElapsedMilliseconds < 1200)
            {
                action();
            }
            stopwatch.Stop();
        }

        public static void TestExecutionTime(this Action action)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            action();
            stopwatch.Stop();
            Console.WriteLine(action.Method.Name + " run " + stopwatch.Elapsed.TotalMilliseconds + " ms");
        }
        public static void TestExecutionTime<P1>(Action<P1> action, P1 p1)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            action(p1);
            stopwatch.Stop();
            Console.WriteLine(action.Method.Name + " run " + stopwatch.Elapsed.TotalMilliseconds + " ms");
        }
        public static void TestExecutionTime<P1>(Action<P1[]> action, params P1[] p1)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            action(p1);
            stopwatch.Stop();
            Console.WriteLine(action.Method.Name + " run " + stopwatch.Elapsed.TotalMilliseconds + " ms");
        }
        public static void TestExecutionTime<P1, P2>(Action<P1, P2> action, P1 p1, P2 p2)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            action(p1, p2);
            stopwatch.Stop();
            Console.WriteLine(action.Method.Name + " run " + stopwatch.Elapsed.TotalMilliseconds + " ms");
        }
        public static void TestExecutionTime<P1, P2, P3>(Action<P1, P2, P3> action, P1 p1, P2 p2, P3 p3)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            action(p1, p2, p3);
            stopwatch.Stop();
            Console.WriteLine(action.Method.Name + " run " + stopwatch.Elapsed.TotalMilliseconds + " ms");
        }
        public static void TestExecutionTime<P1, P2, P3, P4>(Action<P1, P2, P3, P4> action, P1 p1, P2 p2, P3 p3, P4 p4)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            action(p1, p2, p3, p4);
            stopwatch.Stop();
            Console.WriteLine(action.Method.Name + " run " + stopwatch.Elapsed.TotalMilliseconds + " ms");
        }
        public static void TestExecutionTime<P1, P2, P3, P4, P5>(Action<P1, P2, P3, P4, P5> action, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            action(p1, p2, p3, p4, p5);
            stopwatch.Stop();
            Console.WriteLine(action.Method.Name + " run " + stopwatch.Elapsed.TotalMilliseconds + " ms");
        }
        public static void TestExecutionTime<P1, P2, P3, P4, P5, P6>(Action<P1, P2, P3, P4, P5, P6> action, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6) 
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            action(p1, p2, p3, p4, p5, p6);
            stopwatch.Stop();
            Console.WriteLine(action.Method.Name + " run " + stopwatch.Elapsed.TotalMilliseconds + " ms");
        }
        public static void TestExecutionTime<P1>(Action<Parameter<P1>> action, Parameter<P1> parameter)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            action(parameter);
            stopwatch.Stop();
            Console.WriteLine(action.Method.Name + " run " + stopwatch.Elapsed.TotalMilliseconds + " ms");
        }
        public static void TestExecutionTime<P1, P2>(Action<Parameter<P1, P2>> action, Parameter<P1, P2> parameter)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            action(parameter);
            stopwatch.Stop();
            Console.WriteLine(action.Method.Name + " run " + stopwatch.Elapsed.TotalMilliseconds + " ms");
        }
        public static void TestExecutionTime<P1, P2, P3>(Action<Parameter<P1, P2, P3>> action, Parameter<P1, P2, P3> parameter)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            action(parameter);
            stopwatch.Stop();
            Console.WriteLine(action.Method.Name + " run " + stopwatch.Elapsed.TotalMilliseconds + " ms");
        }
        public static void TestExecutionTime<P1, P2, P3, P4>(Action<Parameter<P1, P2, P3, P4>> action, Parameter<P1, P2, P3, P4> parameter)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            action(parameter);
            stopwatch.Stop();
            Console.WriteLine(action.Method.Name + " run " + stopwatch.Elapsed.TotalMilliseconds + " ms");
        }
        public static void TestExecutionTime<P1, P2, P3, P4, P5>(Action<Parameter<P1, P2, P3, P4, P5>> action, Parameter<P1, P2, P3, P4, P5> parameter)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            action(parameter);
            stopwatch.Stop();
            Console.WriteLine(action.Method.Name + " run " + stopwatch.Elapsed.TotalMilliseconds + " ms");
        }
        public static void TestExecutionTime<P1, P2, P3, P4, P5, P6>(Action<Parameter<P1, P2, P3, P4, P5, P6>> action, Parameter<P1, P2, P3, P4, P5, P6> parameter)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            action(parameter);
            stopwatch.Stop();
            Console.WriteLine(action.Method.Name + " run " + stopwatch.Elapsed.TotalMilliseconds + " ms");
        }


        public static Output TestExecutionTime<Output>(this Func<Output> func)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Output output = func();
            stopwatch.Stop();
            Console.WriteLine(func.Method.Name + " run " + stopwatch.Elapsed.TotalMilliseconds + " ms");
            return output;
        }
        public static Output TestExecutionTime<P1, Output>(Func<P1, Output> func, P1 p1)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Output output = func(p1);
            stopwatch.Stop();
            Console.WriteLine(func.Method.Name + " run " + stopwatch.Elapsed.TotalMilliseconds + " ms");
            return output;
        }
        public static Output TestExecutionTime<P1, Output>(Func<P1[], Output> func, params P1[] p1)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Output output = func(p1);
            stopwatch.Stop();
            Console.WriteLine(func.Method.Name + " run " + stopwatch.Elapsed.TotalMilliseconds + " ms");
            return output;
        }



    }
}
