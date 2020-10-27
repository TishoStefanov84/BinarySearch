using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 5, 15, 28, 64, 112, 234 };
            var num = int.Parse(Console.ReadLine());

            var index = BinarySearch(arr, num, 0, arr.Length);
            Console.WriteLine(index);
        }

        private static int BinarySearch(int[] arr, int num, int start, int end)
        {
            if (start > end)
            {
                return -1;
            }
            var middle = (start + end) / 2;

            if (num < arr[middle])
            {
                return BinarySearch(arr, num, start, middle - 1);
            }
            else if (num > arr[middle])
            {
                return BinarySearch(arr, num, middle + 1, end);
            }
            else
            {
                return middle;
            }

        }
    }
}
