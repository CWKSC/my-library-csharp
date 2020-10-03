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

        /// <summary>
        /// add string to each string[] element
        /// </summary>
        public static string[] AllAdd(this string[] array, string add) =>
            array.Map((ele, i) => ele + add);

        /// <summary>
        /// add string to each string[] element in front
        /// </summary>
        public static string[] AllAddFront(this string[] array, string add) =>
            array.Map((ele, i) => add + ele);



        public static string[] Mix(this string[] array, string[] other) =>
            BuildArray<string>(array.Length, result =>
                result.Map((ele, i) => array[i] + other[i]));



        public static string ConcatToOneString(this string[] array) =>
             BuildString(builder =>
                array.Loop((ele, _) =>
                    builder.Append(ele)));


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
        /// "T".ToConcat1dArray_SeparateBy(5, "*") <br />
        /// T, T*T, T*T*T, T*T*T*T, T*T*T*T*T
        /// </summary>
        public static string[] ToConcat1dArray_SeparateBy(this string value, int length, string separate) =>
            BuildArray<string>(length, result =>
                result.Map((ele, i) =>
                    string.Join(separate, value.ToRepeatArray(i + 1))));

        /// <summary>
        /// return {"X0", "X1", "X2", "X3", ..., "X(n-1)"} <br /><br />
        /// e.g. Xn("T", 4) <br />
        /// = {"X0", "X1", "X2", "X3"}
        /// </summary>
        public static string[] Xn(string X, int n) => 
            X.ToRepeatArray(n)
             .Mix(n.ToStringArray());

        /// <summary>
        /// return {"T0", "T1", "T2", "T3", ..., "T(n-1)"} <br /><br />
        /// e.g. GenericType(5) <br />
        /// = {"T0", "T1", "T2", "T3", "T4"}
        /// </summary>
        public static string[] GenericType(int n) => Xn("T", n);


    }
}
