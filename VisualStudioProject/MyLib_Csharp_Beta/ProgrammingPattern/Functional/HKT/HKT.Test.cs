using System;
using System.Collections.Generic;

namespace MyLib_Csharp_Beta.ProgrammingPattern.Functional
{
    public static partial class HKT_Test
    {

        public static void Test()
        {
            List<int>       list          = new List<int>(){ 1, 2, 3, 4 };
            ListHKT<int>    listHKT       = new ListHKT<int>(list);
            ListF           listFunctor   = new ListF();
            ListHKT<double> mappedListHKT = (ListHKT<double>)listFunctor.Map(x => x + 1.5, listHKT);
            List<double>    mappedList    = mappedListHKT.value;

            foreach (var ele in mappedList)
                Console.Write(ele + " ");
            // 2.5 3.5 4.5 5.5

            Console.WriteLine();
            List<double> list2 = 
                ((ListHKT<double>)new ListF().Map(x => x + 1.5,
                    new ListHKT<int>(
                        new List<int>() { 1, 2, 3, 4 }))).value;
            foreach (var ele in list2) Console.Write(ele + " ");


            //ListHKT<int> listHKT = new List<int>() { 1, 2, 3, 4 };
            //List<double> mappedList = (ListHKT<double>)new ListF().Map(x => x + 1.5, listHKT);
        }

    }

}
