using MyLib_Csharp_Beta.CommonMethod;

namespace MyLib_Csharp_Beta.ProgrammingPattern
{
    public static partial class Looping
    {

        private static void PrintI(int i) => i.Println();

        public static void Test()
        {
            (0, 17, 3).Loop(PrintI).ln(); 
            (0, 5).Loop(PrintI).ln();
            3.Loop(PrintI).lnln();

            int[] array = { 1, 2, 3, 4, 5 };
            array.ForEach(ele => ele *= 3).Print();
        }

    }
}
