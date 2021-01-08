using System;

#pragma warning disable IDE1006 // 命名樣式

namespace MyLib_Csharp_Beta.ProgrammingPattern.Functional
{

    public interface State<S> { }
    public class State<S, V> : HKT<State<S>, V>, State<S>
    {
        public Func<S, (S state, V value)> runState;
        public State(Func<S, (S state, V value)> f) => runState = f;
        public static State<S, V> Narrow(HKT<State<S>, V> v) => (State<S, V>)v;
    }

    public class StateM<S> : Monad<State<S>>
    {
        public HKT<State<S>, V> Pure<V>(V value) => 
            new State<S, V>(state => (state, value));

        public HKT<State<S>, B> FlatMap<A, B>(HKT<State<S>, A> a, Func<A, HKT<State<S>, B>> f) =>
            new State<S, B>(s =>
            {
                (S state, A value) = State<S, A>.Narrow(a).runState(s);
                return State<S, B>.Narrow(f(value)).runState(state);
            });

        // 读取 //
        public static HKT<State<S>, S> Get = 
            new State<S, S>(s => (s, s));

        // 写入 //
        public static HKT<State<S>, S> Put(S s) => 
            new State<S, S>(any => (s, any));

        // 修改 //
        public static HKT<State<S>, S> Modify(Func<S, S> f) => 
            new State<S, S>(s => (f(s), s));
    }

}

#pragma warning restore IDE1006 // 命名樣式
