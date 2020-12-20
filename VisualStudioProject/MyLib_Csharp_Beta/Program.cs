using MyLib_Csharp_Beta.ProgrammingPattern;
using System;

using static MyLib_Csharp_Beta.ProgrammingPattern.ProgramStructure;
using static MyLib_Csharp_Beta.CommonMethod.Printing;
using MyLib_Csharp_Beta.CommonType;
using MyLib_Csharp_Beta.MyMath;
using MyLib_Csharp_Beta.Tool;
using static MyLib_Csharp_Beta.MyMath.SumOf_ProductOf;
using MyLib_Csharp_Beta.CommonMethod;
using System.Runtime.InteropServices.ComTypes;
using System.Reflection;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using static MyLib_Csharp_Beta.CommonMethod.MyString;
using static MyLib_Csharp_Beta.Tool.TemplateGenerator;
using MyLib_Csharp_Beta.ProgrammingPattern.Functional;

namespace MyLib_Csharp_Beta
{

    public static class Program
    {

        public static T1[] UnpackItem1<T1, T2>(this (T1, T2)[] tuple) => 
            tuple.Select(pkg => pkg.Item1).ToArray();
        public static T2[] UnpackItem2<T1, T2>(this (T1, T2)[] tuple) =>
            tuple.Select(pkg => pkg.Item2).ToArray();


        

        public static void Main(string[] args)
        {
            CoData.Test();
            //Monoid.Test();
            //TemplateGenerator.Test();
        }


    }

}
