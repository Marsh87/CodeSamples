using System;

namespace SortingAlgorithms.Models
{
    public class QuickSort
    {
        public void Sort(int[] arrayToSort)
        {
            int n = arrayToSort.Length, i;
            Console.WriteLine("Quick Sort");
            Console.Write("Initial array is: ");
            for (i = 0; i < n; i++) {
                Console.Write(arrayToSort[i] + " ");
            }
            quickSort(arrayToSort, 0, 9);
            Console.Write("\nSorted Array is: ");
            for (i = 0; i < n; i++) {
                Console.Write(arrayToSort[i] + " ");
            }
        }
        
        private static void quickSort(int[] arr, int left, int right) {
            int pivot;
            if (left < right) {
                pivot = Partition(arr, left, right);
                if (pivot > 1) {
                    quickSort(arr, left, pivot - 1);
                }  
                if (pivot + 1 < right) {
                    quickSort(arr, pivot + 1, right);
                }
            }
        }
        private static int Partition(int[] arr, int left, int right) {
            int pivot;
            pivot = arr[left];
            while (true) {
                while (arr[left] < pivot) {
                    left++;
                }
                while (arr[right] > pivot) {
                    right--;
                }
                if (left < right) {
                    int temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp;
                } else {
                    return right;
                }
            }
        }
    }
}