using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.ProgrammingPattern.Functional
{
    public static partial class StateMonad_Test
    {

        public static StateM<(int, int)> m = new StateM<(int, int)>();

        public static State<(int, int), int> Fib(int n) => 
            n == 0 ? 
                State<(int, int), int>.Narrow(
                     m.FlatMap(StateM<(int, int)>.Get,
                     x => m.Pure(x.Item1))) : 
                State<(int, int), int>.Narrow(
                     m.FlatMap(StateM<(int, int)>.Modify(x => (x.Item2, x.Item1 + x.Item2)),
                     v => Fib(n - 1)));
        
        //public static int fib(int n)
        //{
        //    int[] a = { 0, 1, 1 };
        //    for (int i = 0; i < n; i++)
        //        a[(i + 2) % 3] = a[(i + 1) % 3] +
        //                         a[i % 3];
        //    return a[(n + 1) % 3];
        //}

        public static void Test()
        {
            int i = 42;
            ((Action<int>)(v => Console.WriteLine(v)))(i + 1);

            Console.WriteLine(Fib(0).runState((0, 1)).value);
            Console.WriteLine(Fib(1).runState((0, 1)).value);
            Console.WriteLine(Fib(2).runState((0, 1)).value);
            Console.WriteLine(Fib(3).runState((0, 1)).value);
            Console.WriteLine(Fib(4).runState((0, 1)).value);
            Console.WriteLine(Fib(5).runState((0, 1)).value);
            Console.WriteLine(Fib(6).runState((0, 1)).value);
            Console.WriteLine(Fib(7).runState((0, 1)).value);
            Console.WriteLine(Fib(8).runState((0, 1)).value);
            Console.WriteLine(Fib(9).runState((0, 1)).value);
            Console.WriteLine(Fib(10).runState((0, 1)).value);
        }

    }

}
