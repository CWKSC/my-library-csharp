using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.CommonClass
{
    public static class MyPrint
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:命名樣式", Justification = "<暫止>")]
        public static void ln() => Console.WriteLine();

        public static T Print<T>(this T value) { Console.Write(value); return value; } 
        public static void Println<T>(this T value) => Console.WriteLine(value);
        public static void Printlnln<T>(this T value) => Console.WriteLine(value + "\n");

        public static T[] Print<T>(this T[] array)
        {
            foreach (T element in array)
            {
                Console.Write(element + " ");
            }
            ln();
            return array;
        }

    }
}
