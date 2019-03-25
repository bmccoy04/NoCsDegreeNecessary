using System;

namespace MergeSort
{
    class Program
    {
        public static int[] unOrderedNumbers = new int[] {2, 4, 1, 10, 5, 3, 7, 9, 8, 6};
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ", unOrderedNumbers));

            var sortedArray = SortArray(unOrderedNumbers);

            Console.WriteLine(string.Join(", ", sortedArray)); 
        }

        private static int[] SortArray(int[] unOrderedNumbers)
        {
            var newArray = unOrderedNumbers;
            int temp;
            
            return newArray;
        }
    }
}
