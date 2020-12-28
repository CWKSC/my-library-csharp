using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.ProgrammingPattern.Functional
{
    public static partial class GADT
    {
        public static void Test()
        {
            // 1 + 2
            Expr OnePlusTwo = new Add(new IntVal(1), new IntVal(2));

            // true == false
            Expr TrueEqFalse = new Eq(new BoolVal(true), new BoolVal(false));

            // 1 + true
            // CS1503 引数 2: 无法从 'GADT.BoolVal' 转换成 'GADT.Expr<int>'
            //Expr OnePlusTrue = new Add(new IntVal(1), new BoolVal(true));

            // true == 42
            // CS1503 引数 2: 无法从 'GADT.IntVal' 转换成 'GADT.Expr<bool>'
            // Expr TrueEq42 = new Eq(new BoolVal(true), new IntVal(42));
        }

    }
}
