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

namespace MyLib_Csharp_Beta
{

    public class Program
    {


        public static void Main(string[] args)
        {
            int[] vs = { 1, 2, 3 };
            vs.JoinPrint((ele, i) => ele.ToString(), ", ");

            //Printing.Test();
            //AdvancedLooping.Test();
            //JaggedArray.Test();
            //GenerateCode.Test();
        }


    }

}
