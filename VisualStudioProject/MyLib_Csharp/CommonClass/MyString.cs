using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.CommonClass
{
    public static class MyString
    {

        public static void Print(this string str) => Console.Write(str);

        public static void Println(this string str) => Console.WriteLine(str);

    }
}
