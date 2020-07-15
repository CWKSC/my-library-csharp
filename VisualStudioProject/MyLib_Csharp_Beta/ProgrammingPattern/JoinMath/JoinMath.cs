using MyLib_Csharp_Beta.CommonType;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.ProgrammingPattern
{

    public static partial class JoinMath
    {

        //// JoinSum ////

        /// <summary>
        /// <code> (1, 5).JoinSum(i => i.ToString()).Printlnln(); </code>
        /// Output:
        /// <code> 1+2+3+4+5 </code>
        /// </summary>
        public static string JoinSum(this (int start, int end) args, MyFunc<int, string> work) =>
            args.JoinStr(work, "+");
        public static string JoinSum(this (int start, int end) args, Func<int, string> work) =>
            args.JoinSum((MyFunc<int, string>)work);


        /// <summary>
        /// <code> 4.JoinSum(i => i.ToString()).Printlnln(); </code>
        /// Output:
        /// <code> 0+1+2+3 </code>
        /// </summary>
        public static string JoinSum(this int times, MyFunc<int, string> work) =>
            (0, times - 1).JoinSum(work);
        public static string JoinSum(this int times, Func<int, string> work) =>
            times.JoinSum((MyFunc<int, string>)work);


        /// <summary>
        /// <code> int[] array = { 12, 34, 56, 78, 910 }; <br />
        /// array.JoinSum((ele, i) => (ele, i).ToString() ).Printlnln(); </code>
        /// Output:
        /// <code> (12, 0)+(34, 1)+(56, 2)+(78, 3)+(910, 4) </code>
        /// </summary>
        public static string JoinSum<T>(this T[] array, MyFunc<T, int, string> work) =>
            array.Length.JoinSum(
                (MyFunc<int, string>)(i => work.Invoke(array[i], i)));
        public static string JoinSum<T>(this T[] array, Func<T, int, string> work) =>
         array.JoinSum((MyFunc<T, int, string>)work);




        //// JoinProduct ////

        /// <summary>
        /// <code> (2, 7).JoinProduct(i => i.ToString()).Println(); </code>
        /// Output:
        /// <code> 2*3*4*5*6*7 </code>
        /// </summary>
        public static string JoinProduct(this (int start, int end) args, MyFunc<int, string> work) =>
            args.JoinStr(work, "*");
        public static string JoinProduct(this (int start, int end) args, Func<int, string> work) =>
            args.JoinProduct((MyFunc<int, string>)work);


        /// <summary>
        /// <code> 7.JoinProduct(i => i.ToString()).Printlnln(); </code>
        /// Output:
        /// <code> 0*1*2*3*4*5*6 </code>
        /// </summary>
        public static string JoinProduct(this int times, MyFunc<int, string> work) =>
            (0, times - 1).JoinProduct(work);
        public static string JoinProduct(this int times, Func<int, string> work) =>
            times.JoinProduct((MyFunc<int, string>)work);


        /// <summary>
        /// <code> int[] array = { 12, 34, 56, 78, 910 }; <br />
        /// array.JoinProduct((ele, i) => (ele, i).ToString() ).Printlnln(); </code>
        /// Output:
        /// <code> (12, 0)*(34, 1)*(56, 2)*(78, 3)*(910, 4) </code>
        /// </summary>
        public static string JoinProduct<T>(this T[] array, MyFunc<T, int, string> work) =>
            array.Length.JoinProduct(
                (MyFunc<int, string>)(i => work.Invoke(array[i], i)));
        public static string JoinProduct<T>(this T[] array, Func<T, int, string> work) =>
         array.JoinProduct((MyFunc<T, int, string>)work);



        //// Advance Usage ////
        /*

        // Use JoinSum and JoinProduct at the same time //

        (1, 5).JoinProduct(i => 
            "(" +  (1, i).JoinSum(i => i.ToString()) + ")" 
        ).Printlnln();

        Output:
        (1)*(1+2)*(1+2+3)*(1+2+3+4)*(1+2+3+4+5)


        // Another example with using array //

        int[] array = { 12, 34, 56, 78, 910 };

        array.JoinSum((ele, i) => 
            array.JoinProduct((ele, i) => 
                ele.ToString()
            ) + "\n"
        ).Println();

        Output:
        12*34*56*78*910
        +12*34*56*78*910
        +12*34*56*78*910
        +12*34*56*78*910
        +12*34*56*78*910

        */




    }
}
