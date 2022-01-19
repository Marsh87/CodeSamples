using SortingAlgorithms.Models;
//References
/*https://www.tutorialspoint.com/selection-sort-program-in-chash#:~:text=Selection%20Sort%20is%20a%20sorting,C%23%20is%20given%20as%20follows.*/
/*https://www.tutorialspoint.com/chash-program-to-perform-quick-sort-using-recursion#:~:text=Quick%20Sort%20is%20a%20sorting,the%20whole%20array%20is%20sorted.*/

namespace SortingAlgorithms
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arrayToSortForSelectionSort = new int[10] { 56, 1, 99, 67, 89, 23, 44, 12, 78, 34 };
            /*Selection Sort is a sorting algorithm that finds the minimum value in the array for each iteration of the loop.
             Then this minimum value is swapped with the current array element.
             This procedure is followed until the array is sorted.*/
            var selectionSort = new SelectionSort();
            selectionSort.Sort(arrayToSortForSelectionSort);
            
            /*Quick Sort is a sorting algorithm that uses the divide and conquer method.
             It takes a pivot element and places it in its correct position. 
             Then the array to the left and right of the pivot element are again sorted using Quick Sort. 
             This is done until the whole array is sorted.*/
            int[] arrayToQuickSort = new int[10] { 56, 1, 99, 67, 89, 23, 44, 12, 78, 34 };
            var quickSort = new QuickSort();
            quickSort.Sort(arrayToQuickSort);
        }
    }
}