using MyLib_Csharp_Beta.CommonMethod;
using System;

using static MyLib_Csharp_Beta.ProgrammingPattern.ApplyFunction;

namespace MyLib_Csharp_Beta.ProgrammingPattern.Functional
{

    public static partial class Monoid_Test
    {
        public static void Test()
        {
            OptionalM<int> optionalM = new OptionalM<int>();
            ApplyFunc(ele => {
                Printing.Println(MyToString.ToStr(ele) + "\t = " + optionalM.Appends((int?[])ele));
            },
                new int?[] { 1, null, null },
                new int?[] { null, 2, null },
                new int?[] { null, null, 3 },
                new int?[] { 1, 2, null },
                new int?[] { 1, null, 3 },
                new int?[] { null, 2, 3 },
                new int?[] { 1, 2, 3 }
            ).ln();

            Monoid<Action> todo = new Todo();
            todo.Appends(
                () =>　Console.WriteLine("logic1"),
                todo.When(true, () => Console.WriteLine("logic2 When true")),
                todo.Cond(false,
                    () => Console.WriteLine("logic3 Cond true"),
                    () => Console.WriteLine("logic4 Cond false"))
            )();
        }
    }

}
