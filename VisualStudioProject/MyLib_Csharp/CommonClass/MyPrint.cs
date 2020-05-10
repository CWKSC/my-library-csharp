using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.CommonClass
{
    public static class MyPrint
    {


        public static void Print<T>(this T value) => Console.Write(value);
        public static void Println<T>(this T value) => Console.WriteLine(value);



    }
}
