

namespace SortingAlgorithms.ArrayFunctions
{
    internal class Functions
    {

        internal static void PrintArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        internal static Boolean IsSorted(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
