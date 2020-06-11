using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.Type
{
    public partial class MyFunc<T, R>
    {
        public Func<T, R> funcTR;
        public Func<R> funcR;

        public MyFunc(Func<T, R> funcTR)
        {
            this.funcTR = funcTR;
        }
        public MyFunc(Func<R> funcR)
        {
            this.funcR = funcR;
        }

        public static implicit operator Func<T, R>(MyFunc<T, R> thisObject) => thisObject.funcTR;
        public static implicit operator Func<R>(MyFunc<T, R> thisObject) => thisObject.funcR;

        public static implicit operator MyFunc<T, R>(Func<T, R> funcTR) => new MyFunc<T, R>(funcTR);
        public static implicit operator MyFunc<T, R>(Func<R> funcR) => new MyFunc<T, R>(funcR);


    }
}
