using MyLib_Csharp_Beta.CommonMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.ProgrammingPattern
{
    public static partial class JoinMath
    {

        public static void Test()
        {
            //// JoinSum ////
            
            // string JoinSum(this (int start, int end) args, MyFunc<int, string> work) //
            (1, 5).JoinSum(i => i.ToString()).Println();

            // string JoinSum(this int times, MyFunc<int, string> work) //
            4.JoinSum(i => i.ToString()).Printlnln();


            //// JoinProdect ////

            // string JoinProduct(this (int start, int end) args, MyFunc<int, string> work) //
            (2, 7).JoinProduct(i => i.ToString()).Println();

            // string JoinProduct(this int times, MyFunc<int, string> work) //
            7.JoinProduct(i => i.ToString()).Printlnln();


            // Use JoinSum and JoinProduct at the same time //
            (1, 5).JoinProduct(i => 
                "(" +  (1, i).JoinSum(i => i.ToString()) + ")" 
            ).Printlnln();



            //// Array in JoinSum and JoinProdect ////

            int[] array = { 12, 34, 56, 78, 910 };

            // string JoinSum<T>(this T[] array, MyFunc<T, int, string> work) //
            array.JoinSum((ele, i) => (ele, i).ToString() ).Println();

            // string JoinProduct<T>(this T[] array, MyFunc<T, int, string> work) //
            array.JoinProduct((ele, i) => (ele, i).ToString() ).Printlnln();

            array.JoinSum((ele, i) => 
                array.JoinProduct((ele, i) => 
                    ele.ToString()
                ) + "\n"
            ).Println();

        }
        /* Output
        1+2+3+4+5
        0+1+2+3

        2*3*4*5*6*7
        0*1*2*3*4*5*6

        (1)*(1+2)*(1+2+3)*(1+2+3+4)*(1+2+3+4+5)

        (12, 0)+(34, 1)+(56, 2)+(78, 3)+(910, 4)
        (12, 0)*(34, 1)*(56, 2)*(78, 3)*(910, 4)

        12*34*56*78*910
        +12*34*56*78*910
        +12*34*56*78*910
        +12*34*56*78*910
        +12*34*56*78*910
        */

    }
}
