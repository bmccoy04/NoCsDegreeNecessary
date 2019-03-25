using System;

namespace BubbleSort
{
    class Program
    {
        public static int[] unOrderedNumbers = new int[] {2, 4, 1, 10, 5, 3, 7, 9, 8, 6};
        static void Main(string[] args)
        {
            Console.WriteLine(unOrderedNumbers.ToString());
            var sortedArray = SortArray(unOrderedNumbers);

            Console.WriteLine(sortedArray);
        }

        private static int[] SortArray(int[] unOrderedNumbers)
        {
            var sortedArray = new int[10];

            for(int i = 0; i < 10; i++) {
                var currentNumber = unOrderedNumbers[i];

                for(int y = i + 1; y < 10; y++) {
                    if(currentNumber < unOrderedNumbers[y])
                        currentNumber = unOrderedNumbers[y];
                }

                sortedArray[i] = currentNumber;
            }

            return sortedArray;
        }
    }
}
