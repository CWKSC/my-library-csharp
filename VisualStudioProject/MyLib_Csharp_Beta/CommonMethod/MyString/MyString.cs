using MyLib_Csharp_Beta.ProgrammingPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

using static MyLib_Csharp_Beta.ProgrammingPattern.Builder;

namespace MyLib_Csharp_Beta.CommonMethod
{
    public static partial class MyString
    {

        /// <summary>
        /// add string to each string[] element
        /// <code>
        /// string[] OneToFive = { "1", "2", "3", "4", "5"}; <br />
        /// OneToFive.AllAdd("0") <br />
        /// {"10", "20", "30", "40", "50"}
        /// </code>
        /// </summary>
        public static string[] AllAdd(this string[] array, string add) =>
            array.Map((ele, i) => ele + add);

        /// <summary>
        /// add string to each string[] element in front
        /// <code>
        /// string[] OneToFive = { "1", "2", "3", "4", "5"}; <br />
        /// OneToFive.AllAdd("0") <br />
        /// {"01", "02", "03", "04", "05"}
        /// </code>
        /// </summary>
        public static string[] AllAddFront(this string[] array, string add) =>
            array.Map((ele, i) => add + ele);


        /// <summary>
        /// <code>
        /// string[] ABCD = { "a", "b", "c", "d" }; <br />
        /// string[] OneToFour = { "1", "2", "3", "4" }; <br />
        /// ABCD.Mix(OneToFour) <br />
        /// {"a1", "b2", "c3", "d4"}
        /// </code>
        /// </summary>
        public static string[] Mix(this string[] array, string[] other) =>
            BuildArrayForEach(array.Length, 
                i => array[i] + other[i]);


        /// <summary>
        /// <code>
        /// new string[] {"1", "2", "3", "4"}.ConcatToOneString() <br />
        /// "1234"
        /// </code>
        /// </summary>
        public static string ConcatToOneString(this string[] array) =>
             BuildString(builder =>
                array.Loop((ele, _) =>
                    builder.Append(ele)));


        /// <summary>
        /// <code>
        /// {"0", "1", "2", ..., "n-1"} <br /><br />
        /// ToSequenceNumberStringArray(5) <br />
        /// {"0", "1", "2", "3", "4"}
        /// </code>
        /// </summary>
        public static string[] ToZeroToNStringArray(this int n) =>
            BuildArrayForEach(n, i => i.ToString());


        /// <summary>
        /// "T".ToRepeatValue(5) <br />
        /// "TTTTT"
        /// </summary>
        public static string ToRepeatValue(this string value, int times) =>
            BuildString(builder =>
                times.Loop(_ =>
                    builder.Append(value)));



        /// <summary>
        /// <code>
        /// "T".ToUpperTriangular(5) <br /> <br />
        /// {<br />
        /// {"T"},<br />
        /// {"T", "T"},<br />
        /// {"T", "T", "T"},<br />
        /// {"T", "T", "T", "T"},<br />
        /// {"T", "T", "T", "T", "T"}<br />
        /// }
        /// </code>
        /// </summary>
        public static string[][] ToUpperTriangular(this string value, int length) =>
            BuildArrayForEach(length,
                i => value.ToRepeatArray(i + 1));

        /// <summary>
        /// <code>
        /// new string[] { "1", "2", "3" }.ToUpperTriangular() <br /> <br />
        /// {<br />
        /// {"1"},<br />
        /// {"1", "2"},<br />
        /// {"1", "2", "3"}<br />
        /// }
        /// </code>
        /// </summary>
        public static string[][] ToUpperTriangular(this string[] array) =>
            BuildArrayForEach(array.Length, 
                i => array.SubArray(0, i + 1));


        /// <summary>
        /// <code>
        /// string[] ABCDEF = { "a", "b", "c", "d", "e", "f"}; <br />
        /// ABCDEF.ConcatSubArrayToString(0, 2) // "ab" <br />
        /// ABCDEF.ConcatSubArrayToString(0, 4) // "abcd" <br />
        /// ABCDEF.ConcatSubArrayToString(2, 2) // "cd" <br />
        /// ABCDEF.ConcatSubArrayToString(2, 4).// "cdef"
        /// </code>
        /// </summary>
        public static string ConcatSubArrayToString(this string[] array, int index, int length) =>
            BuildString(builder =>
                (index, index + length - 1).Loop(i => 
                    builder.Append(array[i])));


        /// <summary>
        /// <code>
        /// new string[]{ "1", "2", "3" }.ToConcat1dArray() <br />
        /// {"1", "12", "123"}
        /// </code>
        /// </summary>
        public static string[] ToConcat1dArray(this string[] array) =>
             BuildArrayForEach(array.Length, 
                 i => array.ConcatSubArrayToString(0, i + 1));


        /// <summary>
        /// <code>
        /// new string[]{ "1", "2", "3" }.ToConcat1dArray_SeparateBy("*") <br />
        /// {"1", "1*2", "1*2*3"}
        /// </code>
        /// </summary>
        public static string[] ToConcat1dArray_SeparateBy(this string[] array, string separate) =>
             BuildArrayForEach(array.Length, 
                 i => string.Join(separate, array.SubArray(0, i + 1)));



        /// <summary>
        /// "T".ToConcat1dArray_SeparateBy(5, "*") <br />
        /// {"T", "T*T", "T*T*T", "T*T*T*T", "T*T*T*T*T"}
        /// </summary>
        public static string[] ToConcat1dArray_SeparateBy(this string value, int length, string separate) =>
            BuildArrayForEach(length, 
                i => string.Join(separate, value.ToRepeatArray(i + 1)));

        /// <summary>
        /// {"X0", "X1", "X2", "X3", ..., "X(n-1)"} <br /><br />
        /// Xn("t", 4) <br />
        /// {"t0", "t1", "t2", "t3"}
        /// </summary>
        public static string[] Xn(string X, int n) => 
            X.ToRepeatArray(n)
             .Mix(n.ToZeroToNStringArray());


        /// <summary>
        /// {"T0", "T1", "T2", "T3", ..., "T(n-1)"} <br /><br />
        /// GenericType(5) <br />
        /// {"T0", "T1", "T2", "T3", "T4"}
        /// </summary>
        public static string[] GenericType(int n) => Xn("T", n);


    }
}
