using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Provide a number:");

            int result = Int32.Parse(Console.ReadLine());

            int[] arr = { 1, 25, 64, 89, 4, 12, 32, 28, 100, 230 };

            BinarySearch(arr, result);
        }

        private static int BinarySearch(int[] arr, int searchedTerm)
        {
            int begin = 0;
            int end = arr.Length - 1;
            while(begin <= end)
            {
                int mid = (begin + end) / 2;
                if (searchedTerm == arr[mid])
                {
                    Console.WriteLine($"{searchedTerm} was found after {end} times");
                    return mid;
                }
                if(searchedTerm < arr[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    begin = mid + 1;
                }
            }
            Console.WriteLine($"{searchedTerm} was not found");
            return -1;
        }
    }
}
