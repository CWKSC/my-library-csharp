using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.ProgrammingPattern.Functional
{
    public static partial class MyHKT
    {

        //public interface Functor<F>
        //{
        //    public F<B> Map<A, B>(Func<A, B> f, F<A> a);
        //}

        //public interface Functor<F>
        //{
        //    public object Map(Func<object, object> f, object a);
        //}

        public interface HKT<F, A> { }

        public interface Functor<F>
        {
            public HKT<F, B> Map<A, B>(Func<A, B> f, HKT<F, A> a);
        }

        public interface ListHKT { }
        public class ListHKT<T> : HKT<ListHKT, T>, ListHKT
        {
            public List<T> value;
            public ListHKT() => value = new List<T>();
            public ListHKT(List<T> v) => value = v;
            public static implicit operator ListHKT<T>(List<T> list) => new ListHKT<T>(list);
            public static implicit operator List<T>(ListHKT<T> list) => list.value;

            public static ListHKT<T> Narrow(HKT<ListHKT, T> v) => (ListHKT<T>)v;
        }




        public class ListF : Functor<ListHKT>
        {
            public HKT<ListHKT, B> Map<A, B>(Func<A, B> f, HKT<ListHKT, A> a)
            {
                List<A> aList = ListHKT<A>.Narrow(a).value;
                B[] result = new B[aList.Count];
                for (int i = 0; i < aList.Count; i++)
                {
                    result[i] = f(aList[i]);
                }
                return new ListHKT<B>(new List<B>(result));
            }
        }

    }
}
