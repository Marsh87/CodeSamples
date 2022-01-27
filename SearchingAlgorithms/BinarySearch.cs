namespace SearchingAlgorithms
{
    public class BinarySearch
    {
        public int BinarySearchIterative(int[] arr, int searchNumber)
        {
            int left = 0;
            int right = arr.Length - 1;
 
            int middle;
            while (left <= right)
            {
                middle = (left + right) / 2;
                switch (Compare(arr[middle], searchNumber))
                {
                    case -1: left = middle + 1; break;
                    case 0: return middle;
                    case 1: right = middle - 1; break;
                }
            }
            return -1;
        }
 
        public int BinarySearchRecursive(int[] arr, int searchNumber, int left, int right)
        {
            int middle;
            while (left <= right)
            {
                middle = (left + right) / 2;
                switch (Compare(arr[middle], searchNumber))
                {
                    case -1: return BinarySearchRecursive(arr, searchNumber, middle + 1, right);
                    case 0: return middle;
                    case 1: return BinarySearchRecursive(arr, searchNumber, left, middle - 1);
                }
            }
            return -1;
        }
 
        private int Compare(int x, int y)
        {
            return x < y ? -1 : (y < x ? 1 : 0);
        }
    }
}