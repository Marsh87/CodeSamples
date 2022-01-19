using System;

namespace SortingAlgorithms.Models
{
    public class SelectionSort
    {
        public void Sort( int[] arrayToSort)
        {
            int n = arrayToSort.Length;
            Console.WriteLine("Selection sort");
            Console.Write("Initial array is: ");
            for (int i = 0; i < n; i++) {
                Console.Write(arrayToSort[i] + " ");
            }
            int temp, smallest;
            for (int i = 0; i < n - 1; i++) {
                smallest = i;
                for (int j = i + 1; j < n; j++) {
                    if (arrayToSort[j] < arrayToSort[smallest]) {
                        smallest = j;
                    }
                }
                temp = arrayToSort[smallest];
                arrayToSort[smallest] = arrayToSort[i];
                arrayToSort[i] = temp;
            }
            Console.WriteLine();
            Console.Write("Sorted array is: ");
            for (int i = 0; i < n; i++) {
                Console.Write(arrayToSort[i] + " ");
            }
            
        }
    }
}