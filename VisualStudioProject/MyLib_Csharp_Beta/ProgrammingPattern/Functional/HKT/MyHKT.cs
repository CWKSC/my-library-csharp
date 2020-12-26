using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.ProgrammingPattern.Functional
{
    public static partial class MyHKT
    {

        //interface Functor<F>
        //{
        //    public F<B> Map<A, B>(F<A> a, Func<A, B> f);
        //}

        class Foo<F> { }

        public interface HKT<F, A> { }

        public interface Functor<F>
        {
            public HKT<F, B> Map<A, B>(HKT<F, A> ma, Func<A, B> f);
        }

        public interface Functor<A, B>
        {
            public Func<A, B> Map<A, B>(Func<A, A> fa, Func<A, B> F) => x => F(fa(x));
        }

        public interface HKTList { }
        public class HKTList<A> : HKT<HKTList, A>, HKTList
        {

            public List<A> value;
            public HKTList() => value = new List<A>();
            public HKTList(List<A> v) => value = v;
            public static HKTList<T> Narrow<T>(HKT<HKTList, T> v) => (HKTList<T>)v;
        }

        //class ListF : Functor<HKTList> {

        //    public HKT<HKTList, B> Map<A, B>(HKT<HKTList, A> ma, Func<A, B> f) => 
        //        HKTList<A>.Narrow(ma)
        //            .value.map(f)
        //            .collect(HKTList.collector());
        //}

    }
}
