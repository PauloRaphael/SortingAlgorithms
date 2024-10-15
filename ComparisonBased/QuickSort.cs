namespace SortingAlgorithms.ComparisonBased
{
    internal class QuickSort
    {

        static void Sort(int[] array, int start, int end)
        {
            if (end <= start) return;

            int pivot = Partition(array, start, end);

            Sort(array, start, pivot - 1);
            Sort(array, pivot + 1, end);

        }

        static int Partition(int[] array, int start, int end)
        {
            int pivot = array[end];
            int i = start - 1;

            for (int j = start; j <= end; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    (array[i], array[j]) = (array[j], array[i]);
                }
            }

            i++;

            (array[i], array[end]) = (array[end], array[i]);

            return i;
        }
    }
}
