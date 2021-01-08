using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.ProgrammingPattern.Functional
{
    public static partial class Lambda
    {
        public static void Test()
        {
            Expr expr = new App(
                new Fun("x",
                    new App(new Val("x"),
                        new Fun("x", new Val("x")))),
                new Val("y"));

            Console.WriteLine(expr); // ((λ x. (x (λ x. x))) y)
            Console.WriteLine(expr.GenUUID().Reduce()); // (λ x. (λ x. x))
        }
    }
}
