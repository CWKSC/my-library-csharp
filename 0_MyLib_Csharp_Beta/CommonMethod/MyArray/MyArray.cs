using MyLib_Csharp_Beta.ProgrammingPattern;
using System;
using System.Collections.Generic;
using System.Text;

using static MyLib_Csharp_Beta.ProgrammingPattern.Builder;

namespace MyLib_Csharp_Beta.CommonMethod
{
    public static partial class MyArray
    {

        /// <summary>
        /// start from index, copy length length <br />
        /// reference to: https://stackoverflow.com/a/943650/11693034
        /// </summary>
        public static T[] SubArray<T>(this T[] data, int index, int length)
        {
            T[] result = new T[length];
            Array.Copy(data, index, result, 0, length);
            return result;
        }


        /// <summary>
        /// <code>
        /// "T".ToRepeatArray(5) <br />
        /// {"T", "T", "T", "T", "T"}
        /// </code>
        /// </summary>
        public static T[] ToRepeatArray<T>(this T value, int length) =>
            BuildArrayForEach(length, _ => value);



        /// <summary>[min, max)</summary>
        public static int[] GenerateRandIntArray(int n, int min = int.MinValue, int max = int.MaxValue)
        {
            int[] result = new int[n];
            Random random = new Random();
            return result.Map((_, __) => random.Next(min, max));
        }

        /// <summary>[min, max)</summary>
        public static int[,] GenerateRandInt2dArray(int row, int col, int min = int.MinValue, int max = int.MaxValue)
        {
            int[,] result = new int[row, col];
            Random random = new Random();
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    result[i, j] = random.Next(min, max);
            return result;
        }


    }
}
