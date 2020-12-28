using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.ProgrammingPattern.Functional
{
    public static partial class GADT
    {
        public interface Expr { }
        public interface Expr<T> : Expr { }
        public class IntVal : Expr<int>
        {
            public int value;
            public IntVal(int v) => value = v;
        }
        public class BoolVal : Expr<bool>
        {
            public bool value;
            public BoolVal(bool b) => value = b;
        }
        public class Add : Expr<int>
        {
            public Expr<int> e1, e2;
            public Add(Expr<int> e1, Expr<int> e2)
            {
                this.e1 = e1;
                this.e2 = e2;
            }
        }
        public class Eq : Expr<bool>
        {
            public Expr<bool> e1, e2;
            public Eq(Expr<bool> e1, Expr<bool> e2)
            {
                this.e1 = e1;
                this.e2 = e2;
            }
        }
    }
}
