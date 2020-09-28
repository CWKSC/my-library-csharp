using MyLib_Csharp_Beta.ProgrammingPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using static MyLib_Csharp_Beta.ProgrammingPattern.Builder;

namespace MyLib_Csharp_Beta.CommonMethod
{
    public static partial class MyString
    {

        public static string[] AllAdd(this string[] array, string add) =>
            array.Map((ele, i) => ele + add);

        public static string[] AllAddFront(this string[] array, string add) =>
            array.Map((ele, i) => add + ele);



        public static string[] Mix(this string[] array, string[] other) =>
            BuildArray<string>(array.Length, result =>
                result.Map((ele, i) => array[i] + other[i]));



        public static string[] ToStringArray(this int length) =>
            BuildArray<string>(length, result =>
                result.Map((ele, i) => i.ToString()));

        public static string ToRepeatValue(this string value, int times) =>
            BuildString(builder => 
                times.Loop(_ => 
                    builder.Append(value)));

       



        public static string[][] ToUpperTriangular(this string[] array) =>
            BuildArray<string[]>(array.Length, result =>
                result.Map((ele, i) => 
                    array.SubArray(0, i + 1)));


        public static string ConcatSubArray(this string[] array, int index, int length) =>
            BuildString(builder =>
                (index, index + length - 1).Loop(i => 
                    builder.Append(array[i])));


        public static string[] ToConcatUpperTriangular(this string[] array) =>
             BuildArray<string>(array.Length, result =>
                result.Map((ele, i) => 
                    array.ConcatSubArray(0, i + 1)));


        public static string[] ToConcatUpperTriangular_SeparateBy(this string[] array, string separate) =>
             BuildArray<string>(array.Length, result =>
                result.Map((ele, i) =>
                    string.Join(separate, array.SubArray(0, i + 1))));



        public static string[][] ToUpperTriangular(this string value, int length) =>
            BuildArray<string[]>(length, result =>
                result.Map((ele, i) => 
                    value.ToRepeatArray(i + 1)));


        /// <summary>
        /// "T".ToConcatUpperTriangular_SeparateBy(5, "*") <br />
        /// T, T*T, T*T*T, T*T*T*T, T*T*T*T*T
        /// </summary>
        public static string[] ToConcat1dArray_SeparateBy(this string value, int length, string separate) =>
            BuildArray<string>(length, result =>
                result.Map((ele, i) =>
                    string.Join(separate, value.ToRepeatArray(i + 1))));


        public static string[] Xn(string A, int n) => 
            A.ToRepeatArray(n)
             .Mix(n.ToStringArray());

        public static string[] GenericType(int n) => Xn("T", n);


    }
}
