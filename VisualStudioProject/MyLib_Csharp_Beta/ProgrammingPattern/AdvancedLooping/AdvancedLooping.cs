using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.ProgrammingPattern.AdvancedLooping
{
    public static partial class AdvancedLooping
    {


        public static void Loop_nC2<T>(this T[] array, Action<T, T> action) =>
            (0, array.Length).Loop(i =>
                (i + 1, array.Length).Loop(j =>
                    action(array[i], array[j])));
        public static void Loop_nC3<T>(this T[] array, Action<T, T, T> action) =>
            (0, array.Length).Loop(i =>
                (i + 1, array.Length).Loop(j =>
                    (j + 1, array.Length).Loop(k =>
                        action(array[i], array[j], array[k]))));

        public static void Loop_nCr<T>(this T[] array, int r, Action<T[]> action)
        {
            // OWO
        }

        public static void Loop_nP2<T>(this T[] array, Action<T, T> action) =>
            array.Loop((ele1, _) => 
                array.Loop((ele2, _) => 
                    action(ele1, ele2)));

        public static void Loop_nP3<T>(this T[] array, Action<T, T, T> action) =>
            array.Loop((ele1, _) =>
                array.Loop((ele2, _) =>
                    array.Loop((ele3, _) => 
                        action(ele1, ele2, ele3))));

        public static void Loop_nPr<T>(this T[] array, int r, Action<T[]> action)
        {
            // QWQ 
        }


    }
}
