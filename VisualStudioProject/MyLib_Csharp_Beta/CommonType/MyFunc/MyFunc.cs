using System;

namespace MyLib_Csharp_Beta.CommonType
{

    public partial class MyFunc<T, R>
    {
        public Func<T, R> func;

        public MyFunc(Func<T, R> funcT) => func = funcT;
        public MyFunc(Func<R> func) => this.func = _ => func();
        public MyFunc(R value) => func = _ => value;


        public R Invoke(T input) => func(input);

        public static implicit operator MyFunc<T, R>(Func<T, R> funcT) => new MyFunc<T, R>(funcT);
        public static implicit operator MyFunc<T, R>(Func<R> func) => new MyFunc<T, R>(func);
        public static implicit operator MyFunc<T, R>(R value) => new MyFunc<T, R>(value);
    }


    public partial class MyFunc<T1, T2, R>
    {
        public Func<T1, T2, R> func;

        public MyFunc(Func<T1, T2, R> funcTT) => func = funcTT;
        public MyFunc(Func<T1, R> funcT) => func = (t1, _) => funcT(t1);
        public MyFunc(Func<R> func) => this.func = (_, __) => func();
        public MyFunc(R value) => func = (_, __) => value;


        public R Invoke(T1 t1, T2 t2) => func(t1, t2);

        public static implicit operator MyFunc<T1, T2, R>(Func<T1, T2, R> funcTT) => new MyFunc<T1, T2, R>(funcTT);
        public static implicit operator MyFunc<T1, T2, R>(Func<T1, R> funcT) => new MyFunc<T1, T2, R>(funcT);
        public static implicit operator MyFunc<T1, T2, R>(Func<R> func) => new MyFunc<T1, T2, R>(func);
        public static implicit operator MyFunc<T1, T2, R>(R value) => new MyFunc<T1, T2, R>(value);
    }


}
