using System;

namespace RecursiveBinarySearch
{
    class Program
    {

        private static int BinarySearch(int[] a, int search, int rightMostPos, int leftMostPos = 0)
        {
            if (rightMostPos < leftMostPos)
            {
                return -1;
            }

            int middle = (int)(Math.Ceiling((rightMostPos + leftMostPos) / 2.0));

            if (search == a[middle])
            {
                return a[middle];
            }
            else if (search < a[middle])
            {
                return BinarySearch(a, search, middle - 1, leftMostPos);
            }
            else
            {
                return BinarySearch(a, search, rightMostPos, middle + 1);
            }
        }

        static void Main(string[] args)
        {
            int[] testArray1 = new int[10];

            for (int i = 0; i < testArray1.Length; i++)
            {
                testArray1[i] = i;
            }

            int searchPos = BinarySearch(testArray1, 9, 9);

            Console.WriteLine(searchPos);
        }
    }
}
