using System;

namespace SortExamples
{
    public static class Sorts
    {
        public static void Bubble(ref int[] array)
        {
            int n = array.Length;
            for (var i = n - 1; i >= 1; i--)
            {
                for (var j = 0; j < i; j++)
                {
                    if (array[j] > array[j + 1])
                        Swap(ref array[j], ref array[j + 1]);
                }
            }
        }

        public static void Shaker(ref int[] array)
        {
            int l = 0, r = array.Length - 1, posLastSwap = 0;
            do
            {
                for (var i = l; i < r; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(ref array[i], ref array[i + 1]);
                        posLastSwap = i;
                    }
                }
                r = posLastSwap;
                for (int i = r; i > l; i--)
                {
                    if (array[i - 1] > array[i])
                    {
                        Swap(ref array[i - 1], ref array[i]);
                        posLastSwap = i;
                    }
                }
                l = posLastSwap;
            } while (l < r);
        }

        public static void Select(ref int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[minIndex] > array[j]) minIndex = j;
                }
                Swap(ref array[i], ref array[minIndex]);
            }
        }

        public static void Insert(ref int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i - 1;
                while (j >= 0 && array[j + 1] < array[j])
                {
                    Swap(ref array[j], ref array[j + 1]);
                    j--;
                }
            }
        }

        public static void InsertBin(ref int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i - 1;
                int midIndex = j / 2;
                int l = 0, r = j;
                while (l < r)
                {
                    if (array[i] > array[midIndex]) l = midIndex + 1;
                    else r = midIndex - 1;
                    midIndex = (l + r) / 2;
                }
                while (midIndex <= j && array[j] > array[j + 1])
                {
                    Swap(ref array[j], ref array[j + 1]);
                    j--;
                }
            }
        }

        public static void Shell(ref int[] array)
        {
            throw new NotImplementedException();
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            T t = x;
            x = y;
            y = t;
        }
    }
}