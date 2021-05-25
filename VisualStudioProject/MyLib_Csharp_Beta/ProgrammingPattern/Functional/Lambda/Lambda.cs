using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable IDE1006 // 命名樣式

namespace MyLib_Csharp_Beta.ProgrammingPattern.Functional
{
    public static partial class Lambda
    {

        public interface Expr
        {
            Expr Reduce();
            Expr Apply(Val value, Expr expr);
            Expr GenUUID();
            Expr ApplyUUID(Val a);
        }

        // Value 变量 //
        public class Val : Expr
        {
            public string value;
            public string id;
            public Val(string value) => this.value = value;
            public Val(string value, string id)
            {
                this.value = value;
                this.id = id;
            }
            public override string ToString() => value;
            public override bool Equals(object obj) => 
                obj is Val val && id.Equals(val.id);
            public override int GetHashCode() => HashCode.Combine(value, id);

            public Expr Reduce() => this;
            public Expr Apply(Val value, Expr expr) => 
                Equals(value) ? expr : this;
            public Expr GenUUID() => this;
            public Expr ApplyUUID(Val a) => 
                value.Equals(a.value) ? new Val(value, a.id) : this;
        }

        // Function 函数定义 //
        public class Fun : Expr
        {
            public Val variable;
            public Expr expr;
            public Fun(string variable, Expr expr) {
                this.variable = new Val(variable);
                this.expr = expr;
            }
            public Fun(Val variable, Expr expr) {
                this.variable = variable;
                this.expr = expr;
            }

            public Expr Reduce() => this;

            public Expr Apply(Val variable, Expr expr) => 
                variable.Equals(this.variable) ? this : 
                    new Fun(this.variable, this.expr.Apply(this.variable, expr));

            public Expr GenUUID()
            {
                if (variable.id == null)
                {
                    Val v = new Val(variable.value, Guid.NewGuid().ToString());
                    return new Fun(v, expr.ApplyUUID(v).GenUUID());
                }
                return new Fun(variable, expr.GenUUID());
            }

            public Expr ApplyUUID(Val a) => 
                variable.value.Equals(a.value) ? this : 
                    new Fun(variable, expr.ApplyUUID(a));

            public override string ToString() => 
                "(λ " + variable + ". " + expr + ")";
        }

        // Apply 函数应用 //
        public class App : Expr
        {
            public Expr f, x;
            public App(Expr f, Expr x) {
                this.f = f;
                this.x = x;
            }

            public Expr Reduce()
            {
                Expr fr = f.Reduce();
                return fr is Fun fun ? 
                    fun.expr.Apply(fun.variable, x).Reduce() : 
                    new App(fr, x);
            }

            public Expr Apply(Val value, Expr expr) =>
                new App(f.Apply(value, expr),
                        x.Apply(value, expr));

            public Expr GenUUID() =>
                new App(f.GenUUID(), x.GenUUID());

            public Expr ApplyUUID(Val a) =>
                new App(f.ApplyUUID(a), x.ApplyUUID(a));

            public override string ToString() => 
                "(" + f + " " + x + ")";
        }

    }

}

#pragma warning restore IDE1006 // 命名樣式
