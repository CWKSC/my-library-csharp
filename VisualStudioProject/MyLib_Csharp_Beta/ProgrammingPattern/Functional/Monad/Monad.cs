using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static MyLib_Csharp_Beta.ProgrammingPattern.Functional.MyHKT;

#pragma warning disable IDE1006 // 命名樣式

namespace MyLib_Csharp_Beta.ProgrammingPattern.Functional
{

    public interface Monad<T>
    {
        public HKT<T, V> Pure<V>(V value);
        public HKT<T, B> FlatMap<A, B>(HKT<T, A> a, Func<A, HKT<T, B>> f);
    }

    public class ListM : Monad<ListHKT>
    {
        public HKT<ListHKT, V> Pure<V>(V value) =>
            new ListHKT<V>(new List<V>() { value });

        // 方便使用 
        public HKT<ListHKT, V> Pure<V>(params V[] values) =>
            new ListHKT<V>(new List<V>(values));

        public HKT<ListHKT, B> FlatMap<A, B>(HKT<ListHKT, A> a, Func<A, HKT<ListHKT, B>> f) => 
            ListHKT<A>.Narrow(a).value.Aggregate(new ListHKT<B>(), (result, ele) =>
            {
                result.value.AddRange(ListHKT<B>.Narrow(f(ele)).value);
                return result;
            });
    }


    public class MaybeM : Monad<MaybeHKT>
    {
        public HKT<MaybeHKT, V> Pure<V>(V value) => new MaybeHKT<V>(value);
        public HKT<MaybeHKT, B> FlatMap<A, B>(HKT<MaybeHKT, A> a, Func<A, HKT<MaybeHKT, B>> f)
        {
            A value = ((Just<A>)MaybeHKT<A>.Narrow(a).maybe).value;
            return value == null ? new MaybeHKT<B>() : f(value);
        }
    }


}

#pragma warning restore IDE1006 // 命名樣式
