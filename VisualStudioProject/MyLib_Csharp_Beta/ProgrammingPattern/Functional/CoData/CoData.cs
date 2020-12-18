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

    }
}
