using System;
using System.Collections.Generic;
using System.Text;
using static MyLib_Csharp_Beta.ProgrammingPattern.Functional.MyHKT;

namespace MyLib_Csharp_Beta.ProgrammingPattern.Functional
{
    public static class MonadTest
    {
        public static void Test()
        {
            ListM listM = new ListM();

            ListHKT<int> pureHKT = (ListHKT<int>)listM.Pure(42, 10007);
            List<int> pure = pureHKT.value;
            foreach (var ele in pure)
                Console.Write(ele + " ");
            // 42 10007
            Console.WriteLine();

            List<int> list = new List<int>() { 1, 2, 3, 4 };
            ListHKT<int> listHKT = new ListHKT<int>(list);

            ListHKT<double> flatMappedListHKT = 
                (ListHKT<double>)listM.FlatMap(listHKT, v => 
                    listM.Pure(v + 0.5, v + 1.5));

            List<double> flatMappedList = flatMappedListHKT.value;
            foreach (var ele in flatMappedList)
                Console.Write(ele + " ");
            // 1.5 2.5 2.5 3.5 3.5 4.5 4.5 5.5
            Console.WriteLine();




        }
    }

}
