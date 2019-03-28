using System;

namespace QuickSort
{
    class Program
    {
        public static int[] unOrderedNumbers = new int[] {2, 4, 1, 10, 5, 3, 7, 9, 8, 6};
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ", unOrderedNumbers));
            var sortedArray = unOrderedNumbers;

            SortArray(sortedArray, 0, 9);

            Console.WriteLine(string.Join(", ", sortedArray)); 
        }

        private static void SortArray(int[] array, int low, int high)
        {
            if(low < high) 
            {
                int p = Partition(array, low, high);

                SortArray(array, low, p - 1);
                SortArray(array, p + 1, high);
            }
        }

        private static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];

            int index = (low - 1);

            for(int j = low; j < high; j++)
            {
                if(array[j] <= pivot) 
                {
                    index++;

                    var temp = array[index];
                    array[index] = array[j];
                    array[j] = temp;
                }
            }

            int temp1 = array[index + 1];
            array[index + 1] = array[high];
            array[high] = temp1;

            return index + 1;
        }
    }
}
