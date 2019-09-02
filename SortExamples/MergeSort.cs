namespace SortExamples
{
    public static class MergeSort
    {
        public static void RecursiveSort(ref int[] array)
        {
            Sort(ref array, 0, array.Length - 1);
        }

        private static void Sort(ref int[] array, int left, int right)
        {
            if (right - left <= 0) return;
            int m = (left + right) / 2;
            Sort(ref array, left, m);
            Sort(ref array, m + 1, right);
            Merge(ref array, left, m + 1, right);
        }

        private static void Merge(ref int[] array, int left, int middle, int right)
        {
            int i = left;
            int j = middle;
            int k = 0;
            int[] tempArray = new int[right - left + 1];
            while (i < middle && j <= right)
                tempArray[k++] = array[i] < array[j] ? array[i++] : array[j++];
            while (i < middle) tempArray[k++] = array[i++];
            while (j <= right) tempArray[k++] = array[j++];
            for (k = 0; k < tempArray.Length; k++)
            {
                array[left + k] = tempArray[k];
            }
        }
    }
}