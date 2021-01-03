using MyLib_Csharp_Beta.CommonMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLib_Csharp_Beta.Tool
{
    public static partial class TestExecutionTime
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




        public static List<T> MySort<T>(this List<T> list) where T : IComparable
        {
            List<List<T>> lists = list.ToNSortedListList();
            return lists.SortNSortedList();
        }

        public static List<List<T>> ToNSortedListList<T>(this List<T> list) where T : IComparable
        {
            int index = 0;
            List<List<T>> listList = new List<List<T>>();
            while (true)
            {
                T max = list[index];
                listList.Add(new List<T>());
                listList[^1].Add(max);
                //Console.Write(new string(' ', index * 3) + list[index]);
                for (int i = index + 1; i < list.Count; i++)
                {
                    if (list[i].CompareTo(max) >= 0)
                    {
                        max = list[i];
                        listList[^1].Add(max);
                        list[i] = list[++index];
                        //Console.Write(", " + max);
                    }
                }
                //Console.WriteLine();
                ++index;
                if (index >= list.Count) break;
            }
            return listList;
        }

        public static List<T> SortNSortedList<T>(this List<List<T>> lists) where T : IComparable
        {
            int length = lists.Aggregate(0, (pre, ele) => pre + ele.Count);
            List<T> result = new List<T>();
            for (int i = length - 1; i >= 0; i--)
            {
                T min = lists[0][0];
                int index = 0;
                for (int j = 1; j < lists.Count; j++)
                {
                    if (lists[j][0].CompareTo(min) < 0)
                    {
                        min = lists[j][0];
                        index = j;
                    }
                }
                result.Add(min);
                lists[index].RemoveAt(0);
                if (lists[index].Count == 0) lists.RemoveAt(index);
            }
            return result;
        }





        public static T[] SelectionSort<T>(this T[] result) where T : IComparable
        {
            //T[] result = (T[])array.Clone();
            for (int i = 0; i < result.Length; i++)
            {
                int maxIndex = 0;
                for (int j = 0; j < result.Length - i; j++)
                {
                    if (result[j].CompareTo(result[maxIndex]) > 0)
                    {
                        maxIndex = j;
                    }
                }
                T temp = result[maxIndex];
                result[maxIndex] = result[result.Length - 1 - i];
                result[result.Length - 1 - i] = temp;
            }
            return result;
        }




        public static T[] BubbleSort<T>(this T[] result) where T : IComparable
        {
            //T[] result = (T[])array.Clone();
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 1; j < result.Length - i; j++)
                {
                    if (result[j - 1].CompareTo(result[j]) > 0)
                    {
                        T temp = result[j - 1];
                        result[j - 1] = result[j];
                        result[j] = temp;
                    }
                }
            }
            return result;
        }




        // reference: https://emn178.pixnet.net/blog/post/88613503
        public static List<int> QuickSort(List<int> list)
        {
            if (list.Count < 2) return list;

            // middle pivot
            int pivot = list[list.Count / 2];
            list.RemoveAt(list.Count / 2);
            List<int> less = new List<int>();
            List<int> greater = new List<int>();
            List<int> result = new List<int>();
            foreach (int n in list)
            {
                if (n > pivot)
                    greater.Add(n);
                else
                    less.Add(n);
            }
            result.AddRange(QuickSort(less));
            result.Add(pivot);
            result.AddRange(QuickSort(greater));
            return result;
        }




    }
}
