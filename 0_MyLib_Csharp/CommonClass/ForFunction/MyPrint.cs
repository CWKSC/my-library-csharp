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
        public static T Println<T>(this T value) { Console.WriteLine(value); return value; }
        public static T Printlnln<T>(this T value) { Console.WriteLine(value + "\n"); return value; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:命名樣式", Justification = "<暫止>")]
        public static T lnPrint<T>(this T value) { Console.Write("\n" + value); return value; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:命名樣式", Justification = "<暫止>")]
        public static T lnPrintln<T>(this T value) { Console.WriteLine("\n" + value); return value; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:命名樣式", Justification = "<暫止>")]
        public static T lnPrintlnln<T>(this T value) { Console.WriteLine("\n" + value + "\n"); return value; }


        public static T[] Print<T>(this T[] array)
        {
            foreach (T element in array)
            {
                Console.Write(element + " ");
            }
            ln();
            return array;
        }

        public static string Print_dontMoveCursor(this string str) {
            Console.Write(str);
            MyConsole.MoveCursorLeft(str.Length);
            return str;
        }


        public static string[] Print(this string[] strArray)
        {
            strArray.ForEach(ele =>
            {
                ele.Print_dontMoveCursor();
                MyConsole.MoveCursorDown();
            });
            return strArray;
        }



    }
}
