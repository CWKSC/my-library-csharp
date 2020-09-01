using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.ProgrammingPattern
{
    public static partial class HigherOrderFunction
    {

        // Combination function //

        public static Func<tA, tC> CombinationFunc<tA, tB, tC>(Func<tB, tC> A, Func<tA, tB> B) =>
            x => A(B(x));


    }
}
