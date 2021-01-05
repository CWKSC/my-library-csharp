using System;
using System.Collections.Generic;
using System.Text;
using static MyLib_Csharp_Beta.ProgrammingPattern.Functional.MyHKT;

namespace MyLib_Csharp_Beta.ProgrammingPattern.Functional
{

#pragma warning disable IDE1006 // 命名樣式

    public interface Maybe<T>
    {

        //public static Maybe<int?> AddI(Maybe<int?> ma, Maybe<int?> mb)
        //{
        //    if (ma is Nothing<int?> || mb is Nothing<int?>)
        //        return new Nothing<int?>();
        //    return new Just<int?>(
        //        ((Just<int?>)ma).value +
        //        ((Just<int?>)mb).value);
        //}

        public static Maybe<int?> AddE(Maybe<int?> ma, Maybe<int?> mb)
        {
            try
            {
                return new Just<int?>(((Just<int?>)ma).value + ((Just<int?>)mb).value);
            }
            catch (Exception)
            {
                return new Nothing<int?>();
            }
        }

        public static Maybe<int?> AddI(Maybe<int?> ma, Maybe<int?> mb)
        {
            MaybeM m = new MaybeM();
            return MaybeHKT<int?>.Narrow(
                m.FlatMap(new MaybeHKT<int?>(ma), a =>
                m.FlatMap(new MaybeHKT<int?>(mb), b =>
                m.Pure(a + b)))
            ).maybe;
        }
    }
    public class Nothing<T> : Maybe<T> { }
    public class Just<T> : Maybe<T>
    {
        public T value;
        public Just() { }
        public Just(T value) => this.value = value;
    }


    public interface MaybeHKT { }
    public class MaybeHKT<T> : HKT<MaybeHKT, T>, MaybeHKT
    {
        public Maybe<T> maybe;
        public MaybeHKT() => maybe = new Nothing<T>();
        public MaybeHKT(T value) => maybe = new Just<T>(value);
        public MaybeHKT(Maybe<T> maybe) => this.maybe = maybe;
        public static MaybeHKT<T> Narrow(HKT<MaybeHKT, T> v) => (MaybeHKT<T>)v;
    }


#pragma warning restore IDE1006 // 命名樣式

}
