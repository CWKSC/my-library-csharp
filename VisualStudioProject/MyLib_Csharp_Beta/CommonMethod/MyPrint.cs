﻿using MyLib_Csharp_Beta.CommonType;
using MyLib_Csharp_Beta.ProgrammingPattern;
using System;
using System.Collections.Generic;
using System.Text;

using static MyLib_Csharp_Beta.ProgrammingPattern.ProgramStructure;

namespace MyLib_Csharp_Beta.CommonMethod
{
    public static class MyPrint
    {

#pragma warning disable IDE1006 // 命名樣式
        public static MyVoid ln() => ln(1);
        public static MyVoid lnln() => ln(2);
        public static MyVoid lnlnln() => ln(3);
        public static Any ln<Any>(this Any _) { ln(); return _; }
        public static Any lnln<Any>(this Any _) { lnln(); return _; }
        public static Any lnlnln<Any>(this Any _) { lnlnln(); return _; }
        public static Any ln<Any>(this Any _, int times) { ln(times); return _; }
        public static MyVoid ln(int times) => new string('\n', times).Print().ReturnVoid();

#pragma warning restore IDE1006 // 命名樣式


        public static T Print<T>(this T value) { Console.Write(value); return value; }
        public static T Println<T>(this T value) { value.Print().ln(); return value; }
        public static T Printlnln<T>(this T value) { value.Println().ln(); return value; }
        public static T Printlnlnln<T>(this T value) { value.Printlnln().ln(); return value; }


#pragma warning disable IDE1006 // 命名樣式
        public static T lnPrint<T>(this T value) { ("\n" + value).Print(); return value; }
        public static T lnPrintln<T>(this T value) { ("\n" + value).Println();  return value; }
        public static T lnPrintlnln<T>(this T value) { ("\n" + value).Printlnln(); return value; }

#pragma warning restore IDE1006 // 命名樣式


        public static T[] Print<T>(this T[] array) => 
            array.JoinFunc((ele, _) => ele.Print(), ", ");


    }
}