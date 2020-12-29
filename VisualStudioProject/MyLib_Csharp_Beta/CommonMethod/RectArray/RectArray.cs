using MyLib_Csharp_Beta.ProgrammingPattern;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MyLib_Csharp_Beta.CommonMethod
{
    public static partial class RectArray
    {

        public static int[] GetRowLengthArray<T>(this T[][] array) => 
            array.Select((ele, i) => array[i].Length).ToArray();


    }
}
