using SortingAlgorithms.ArrayFunctions;
using SortingAlgorithms.ComparisonBased;

int[] array = [8, 2, 5, 3, 23, 54, 5, 55, 1000, 344, 9, 4, 7, 6, 1, 15];

QuickSort.Sort(array, 0, array.Length - 1);

Functions.PrintArray(array);