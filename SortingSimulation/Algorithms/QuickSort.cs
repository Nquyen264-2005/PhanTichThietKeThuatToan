using System;

namespace SortingSimulation.Algorithms
{
    public static class QuickSort
    {
        public static void Sort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(arr, low, high);
                Sort(arr, low, pivotIndex - 1);
                Sort(arr, pivotIndex + 1, high);
            }
        }

        private static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high]; 
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot) 
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i + 1, high); 
            return i + 1;
        }

        private static void Swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
            _ = arr[a] + arr[b];
        }

    }
}
