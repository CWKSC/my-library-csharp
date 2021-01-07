using MyLib_Csharp_Beta.CommonMethod;
using System;

namespace MyLib_Csharp_Beta.ProgrammingPattern.Functional
{
    public static partial class ADT
    {
        public static void Test()
        {
            ISchoolPerson student = new Student();
            ISchoolPerson teacher = new Teacher();

            (student is ISchoolPerson).Println();
            (student is Student).Println();
            (student is Teacher).Printlnln();

            (teacher is ISchoolPerson).Println();
            (teacher is Student).Println();
            (teacher is Teacher).Printlnln();


            Nat number = new S(new S(new S(new Z())));
            CountNat(number).Printlnln();


            List<int> list = new Cons<int>(1, new Cons<int>(3, new Cons<int>(4, new Nil<int>())));
            PrintList(list);
        }

        public static int CountNat(Nat number)
        {
            int count = 0;
            while(!(number is Z))
            {
                number = ((S)number).value;
                count++;
            }
            return count;
        }

        public static void PrintList<T>(List<T> list)
        {
            Console.Write('[');
            while (!(list is Nil<T>))
            {
                Cons<T> cons = (Cons<T>)list;
                Console.Write(cons.value + ", ");
                list = cons.next;
            }
            Console.Write("Nil]");
        }


    }
}
