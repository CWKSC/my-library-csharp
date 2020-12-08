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
            string flag = "";
            int[] outputhex = { 0x5B, 0x13, 0x49, 0x77, 0x13, 0x5E, 0x7D, 0x13 };
            int[] key = { 0x10, 0x20, 0x30 };
            int[] index = { 0, 1, 2, 0, 1, 2, 0, 1 };
            for (int i = outputhex.Length - 1; i >= 0; i--)
            {
                flag = (char)(outputhex[i] ^ key[index[i]]) + flag;
            }
            flag.Println(); // K3yg3nm3

            // key = letsplaychess


            //TemplateGenerator.Test();
        }


    }

}
