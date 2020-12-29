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
using System.Reflection;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using static MyLib_Csharp_Beta.CommonMethod.MyString;
using static MyLib_Csharp_Beta.Tool.TemplateGenerator;
using MyLib_Csharp_Beta.ProgrammingPattern.Functional;
using MyLib_Csharp_Beta.Algorithm;

namespace MyLib_Csharp_Beta
{

    public static class Program
    {

        /// <summary>[min, max)</summary>
        public static int[] GenerateRandIntArray(int n, int min = int.MinValue, int max = int.MaxValue)
        {
            int[] result = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
                result[i] = random.Next(min, max);
            return result;
        }

        public static void Swap<T>(IList<T> list, int indexA, int indexB)
        {
            T tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
        }

        public static T[] MySort<T>(this T[] list) where T : IComparable
        {
            int index = 0;
            List<int> indexList = new List<int>();
            while (true)
            {
                T max = list[index];
                Console.Write(new string(' ', index * 3) + list[index]);
                for (int i = index + 1; i < list.Length; i++)
                {
                    if (list[i].CompareTo(max) >= 0)
                    {
                        Swap(list, ++index, i);
                        max = list[index];
                        
                        Console.Write(", " + list[index]);
                    }
                }
                indexList.Add(index);
                Console.WriteLine();
                list.Println();
                ++index;
                if (index >= list.Length) break;
            }
            List<int> record = new List<int>() { -1 };
            record.AddRange(indexList);

            int i_index = 0;
            T[] almostSortedArray = new T[list.Length];
            for (int i = almostSortedArray.Length - 1; i >= 0; i--)
            {
                almostSortedArray[i] = list[indexList[i_index]];
                if (i == 0) break;
                indexList[i_index]--;
                i_index = (i_index + 1) % indexList.Count;
                while (indexList[i_index] == record[i_index]) 
                    i_index = (i_index + 1) % indexList.Count;
            }
            return almostSortedArray;
        }

        public static T[] SortNSortedArray<T>(params T[][] arrays) where T : IComparable
        {
            int length = arrays.Aggregate(0, (pre, ele) => pre + ele.Length);
            T[] result = new T[length];
            int[] indexs = arrays.GetRowLengthArray();
            for(int i = length - 1; i >= 0; i--)
            {
                int k = 0;
                while (indexs[k] == 0) k++;
                int maxIndex = k;
                T max = arrays[k][indexs[k] - 1];

                for (int j = 1; j < arrays.Length; j++)
                {
                    if (indexs[j] == 0) continue;
                    if (arrays[j][indexs[j] - 1].CompareTo(max) > 0)
                    {
                        max = arrays[j][indexs[j] - 1];
                        maxIndex = j;
                    }
                }
                indexs[maxIndex]--;
                result[i] = max;
            }
            return result;
        }

        public static void Main(string[] args)
        {
            int[] a = GenerateRandIntArray(10, 0, 99);
            int[] b = GenerateRandIntArray(10, 0, 99);
            int[] c = GenerateRandIntArray(10, 0, 99);
            Array.Sort(a); a.Println();
            Array.Sort(b); b.Println();
            Array.Sort(c); c.Println();
            SortNSortedArray(a, b, c).Println();

            //a.Println();
            //a.MySort().MySort().Println();
            //a.Println();

            //Sort.Test();
            //MyHKT.Test();
            //Monoid.Test();
            //TemplateGenerator.Test();
        }


    }

}
