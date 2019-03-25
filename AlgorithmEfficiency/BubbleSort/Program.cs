using System;

namespace BubbleSort
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

            for(int i = 0; i < newArray.Length - 1; i++) {
                for(int j = 0; j < newArray.Length - 1; j++) {
                    
                    var current = newArray[j];
                    var next = newArray[j + 1];

                    if(current > next) {
                        temp = next;
                        newArray[j + 1] = current;
                        newArray[j] = temp;
                    }
                }
            }

            return newArray;
        }
    }
}
