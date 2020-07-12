using MyLib_Csharp_Beta.CommonMethod;
using MyLib_Csharp_Beta.CommonType;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.ProgrammingPattern
{
    public static partial class ProgramStructure
    {

        public static MyVoid Test() =>
            Delcare(out bool condition).
            Delcare(out Func<bool> isIfElseReach, () =>
                condition.
                If(() => "If is reach".Println()).
                Else(() => "Else is reach".Println()) ).
            Delcare(out Func<string> printCondition, () => 
                ("condition variable : " + condition).Println()).
            Call(printCondition).
            Call(isIfElseReach).
            Expression(condition = true).
            Call(printCondition).
            Call(isIfElseReach);

        /*
        bool condition = default;
        Func<bool> isIfElseReach = () => {
            if (condition) { Console.WriteLine("If is reach"); }
            else {  Console.WriteLine("Else is reach"); }
        };
        Console.WriteLine("condition variable : " + condition);
        isIfElseReach2();
        condition = true;
        Console.WriteLine("condition variable : " + condition);
        isIfElseReach2();
        */

    }
}
