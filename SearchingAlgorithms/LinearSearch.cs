namespace SearchingAlgorithms
{
    public class LinearSearch
    {
        public int Search(int[] arr, int searchNumber)
        {
            arr[arr.Length - 1] = searchNumber;
     
            int i;
            for (i = 0; arr[i] != searchNumber; i++);
            return (i < arr.Length -1) ? i : -1;
        }
        
    }
}