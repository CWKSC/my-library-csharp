using MyLib_Csharp_Beta.ProgrammingPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.CommonMethod
{
    public static partial class JaggedArray
    {

        public static T[][] ToJagged<T>(this T[,] rectArray)
        {
            int row = rectArray.GetLength(0);
            int col = rectArray.GetLength(1);
            T[][] jaggedArray = new T[row][];
            jaggedArray.Map((ele, i) => ele = new T[col]);
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    jaggedArray[i][j] = rectArray[i, j];
            return jaggedArray;
        }


    }
}
