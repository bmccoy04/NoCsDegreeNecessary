using System;

namespace SelectionSort 
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

            for(int i = 0; i < 9; i++) {
                var currentNumber = newArray[i];
                var minIndex = i;

                for(int y = i + 1; y < 10; y++) {

                    var numberToBeChecked = newArray[y];
                    var newMinNumber = newArray[minIndex];

                    if(numberToBeChecked < newMinNumber)
                        minIndex = y;
                }

                int tempNumber = newArray[minIndex];
                newArray[minIndex] = newArray[i];
                newArray[i] = tempNumber;
            }

            return newArray;
        }
    }
}
