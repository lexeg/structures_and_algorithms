using System;

namespace SortExamples
{
    public static class SortHelper
    {
        public static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}