using System;
using System.Collections.Generic;
using System.Text;
using static MyLib_Csharp_Beta.ProgrammingPattern.Functional.MyHKT;

namespace MyLib_Csharp_Beta.ProgrammingPattern.Functional
{

#pragma warning disable IDE1006 // 命名樣式


    public interface Maybe { }
    public interface Maybe<T> : HKT<Maybe, T>, Maybe
    {
        public static Maybe<T> Narrow(HKT<Maybe, T> v) => (Maybe<T>)v;

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
            return Maybe<int?>.Narrow(
                m.FlatMap(ma, a =>
                m.FlatMap(mb, b =>
                m.Pure(a + b)))
            );
        }
    }

    public class Nothing<T> : Maybe<T> { }
    public class Just<T> : Maybe<T>
    {
        public T value;
        public Just() { }
        public Just(T value) => this.value = value;
    }


#pragma warning restore IDE1006 // 命名樣式

}
