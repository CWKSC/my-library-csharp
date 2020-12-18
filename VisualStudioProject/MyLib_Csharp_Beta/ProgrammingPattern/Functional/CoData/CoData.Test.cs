using System;
using System.Collections.Generic;
using System.Text;

using IntList = MyLib_Csharp_Beta.ProgrammingPattern.Functional.ADT.List<int>;
using IntNil = MyLib_Csharp_Beta.ProgrammingPattern.Functional.ADT.Nil<int>;
using IntCons = MyLib_Csharp_Beta.ProgrammingPattern.Functional.ADT.Cons<int>;

namespace MyLib_Csharp_Beta.ProgrammingPattern.Functional
{
    public static partial class CoData
    {
        public static void Test()
        {

            IntList list = new IntCons(4, new IntCons(2, new IntNil()));
            ADT.PrintList(list);

            // CS0165  使用未指派的區域變數 'list'
            // IntList list = new IntCons(4, list);

            Console.WriteLine(InfAlt().head); // 1
            Console.WriteLine(InfAlt().next().head); // 2
            Console.WriteLine(InfAlt().next().next().head); // 1
            Console.WriteLine(InfAlt().next().next().next().head); // 2
            Console.WriteLine(InfAlt().next().next().next().next().head); // 1
        }
    }
}
