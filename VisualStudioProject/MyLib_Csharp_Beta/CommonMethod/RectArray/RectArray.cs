using MyLib_Csharp_Beta.ProgrammingPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.CommonMethod
{
    public static partial class RectArray
    {

        public static int[] GetRowLengthArray<T>(this T[][] array)
        {
            int[] rowLength = new int[array.Length];
            rowLength.Map((ele, i) => array[i].Length);
            return rowLength;
        }


    }
}
