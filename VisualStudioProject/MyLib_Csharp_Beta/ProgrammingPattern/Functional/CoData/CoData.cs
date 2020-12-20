using System;
using System.Collections.Generic;
using System.Text;


namespace MyLib_Csharp_Beta.ProgrammingPattern.Functional
{
    public static partial class CoData
    {

        public class InfIntList
        {
            public int head;
            public Func<InfIntList> next;
            public InfIntList(int head, Func<InfIntList> next)
            {
                this.head = head;
                this.next = next;
            }
        }

        public static InfIntList InfAlt()
        {
            return new InfIntList(1, 
                () => new InfIntList(2, 
                    InfAlt));
        }



        public delegate (T value, InfRing<T> next) InfRing<T>();
        public static (int value, InfRing<int> next) threeLengthRing() =>
            (1, () => (2, () => (3, threeLengthRing)));



        public delegate (T value, List<InfTree<T>> nexts) InfTree<T>();
        public static (int value, List<InfTree<int>> nexts) tree(int x) => 
            (x, new List<InfTree<int>>{
                () => tree(x += 1),
                () => tree(x += 2) });




    }
}
