using Pastel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MyLib_Csharp.CommonClass
{
    public static class MyArray
    {

        public static int[] GenerateRandIntArray(int n)
        {
            int[] result = new int[n];
            Random random = new Random();
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = random.Next(int.MinValue, int.MaxValue);
            }
            return result;
        }

        /// <summary>[min, max)</summary>
        public static int[] GenerateRandIntArray(int n, int min, int max)
        {
            int[] result = new int[n];
            Random random = new Random();
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = random.Next(min, max);
            }
            return result;
        }

        public static int[,] GenerateRandInt2dArray(int n, int m)
        {
            int[,] result = new int[n, m];
            Random random = new Random();
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = random.Next(int.MinValue, int.MaxValue);
                }
            }
            return result;
        }


        public static void Print<T>(T[] array)
        {
            foreach(T element in array)
            {
                Console.Write(element + " ");
            }
        }
        public static void Println<T>(this T[] array)
        {
            Print(array);
            Console.Write('\n');
        }

        /// <summary>
        /// Mark color of some index
        /// </summary>
        public static void Println<T>(this T[] array, Color color, params int[] markIndex)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (markIndex.Contains(i))
                {
                    Console.Write(array[i].ToString().Pastel(color) + " ");
                }
                else
                {
                    Console.Write(array[i] + " ");
                }
            }
            Console.Write('\n');
        }

        public static void Print<T>(T[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.Write('\n');
            }
        }
    }
}
