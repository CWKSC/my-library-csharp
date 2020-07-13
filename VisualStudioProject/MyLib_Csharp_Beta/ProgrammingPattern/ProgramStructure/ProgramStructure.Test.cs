using MyLib_Csharp_Beta.CommonMethod;
using MyLib_Csharp_Beta.CommonType;
using System;

namespace MyLib_Csharp_Beta.ProgrammingPattern
{
    public static partial class ProgramStructure
    {

        public static MyVoid Test() =>
            _(out bool condition).
            _(out Func<bool> isIfElseReach, () =>
                condition.
                    If(() => "If is reach".Println()).
                    Else(() => "Else is reach".Println()) ).
            _(out Func<string> printCondition, () => 
                ("condition variable : " + condition).Println() ).
            Call(printCondition).
            Call(isIfElseReach).
            _(condition = true).
            Call(printCondition).
            Call(isIfElseReach).
            ReturnVoid();

        /* Output
        condition variable : False
        Else is reach
        condition variable : True
        If is reach
        */

    }
}
