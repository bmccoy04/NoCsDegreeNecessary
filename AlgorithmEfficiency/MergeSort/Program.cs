using System;

namespace MergeSort
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

        private static void SortArray(int[] sortedArray, int leftIndex, int rightIndex)
        {
            int mid;

            if(rightIndex > leftIndex)
            {
                mid = (rightIndex + leftIndex) / 2;
                SortArray(sortedArray, leftIndex, mid);
                SortArray(sortedArray, mid + 1, rightIndex);

                SortMerge(sortedArray, leftIndex, mid + 1, rightIndex);
            }
        }

        private static void SortMerge(int[] sortedArray, int leftIndex, int mid, int rightIndex)
        {
            int[] temp = new int[sortedArray.Length];
            int endOfLeft = (mid - 1);
            int number = (rightIndex - leftIndex + 1);
            int position = leftIndex;


            while(leftIndex <= endOfLeft && (mid <= rightIndex)) 
            {
                if(sortedArray[leftIndex] <= sortedArray[mid]) {
                    temp[position++] = sortedArray[leftIndex++];
                } else {
                    temp[position++] = sortedArray[mid++];
                }
            }

            while(leftIndex <= endOfLeft) 
            {
                temp[position++] = sortedArray[leftIndex++];
            }

            while(mid <= rightIndex)
            {
                temp[position++] = sortedArray[mid++];
            }

            for(int i = 0; i < number; i++)
            {
                sortedArray[rightIndex] = temp[rightIndex];

                rightIndex--;
            }

        }
    }
}
