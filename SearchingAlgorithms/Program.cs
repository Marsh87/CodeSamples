using System;
using System.Linq;

namespace SearchingAlgorithms
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*http://csharpexamples.com/c-sequential-search-example/
             Sequential search(Linear search) is the simplest search algorithm. It is a special case of brute-force search. 
             It is a method for finding a particular value in a list. To achieve this, it checks every one of its elements one.
             */
            var linearSearch = new LinearSearch();
            int[] numbers = new int[10]
            {
                1, 2, 4, 11, 20, 28, 48, 84, 96, 106
            };

            var indexForLinearSerSearch = linearSearch.Search(numbers, 20);
            Console.WriteLine("Index of 20 value in array is " + indexForLinearSerSearch.ToString());

            /*http://csharpexamples.com/c-binary-search-example/
             Binary search or half-interval search algorithm finds the position of a specified input value (the search “key”) within an array sorted by key value.
            For more information about Binary Search:*/
            var binarySearch = new BinarySearch();
            int dotNetBinarySearch = numbers.ToList().BinarySearch(20);
            int binarySearchIterativeIndex = binarySearch.BinarySearchIterative(numbers, 20);
            int binarySearchRecursiveIndex = binarySearch.BinarySearchRecursive(numbers, 20, 0, numbers.Length - 1);
            Console.WriteLine("Index of 20 value in list is " + dotNetBinarySearch.ToString() + " (using .NET Frameowork)");
            Console.WriteLine("Index of 20 value in list is " + binarySearchIterativeIndex.ToString() + " (using BinarySearchIterative method)");
            Console.WriteLine("Index of 20 value in list is " + binarySearchRecursiveIndex.ToString() + " (using BinarySearchRecursive method)");
        }
    }
}