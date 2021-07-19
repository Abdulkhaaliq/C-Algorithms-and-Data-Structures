using System;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 25, 64, 89, 4, 12, 32, 28, 100, 230};

            Console.WriteLine("Enter a number");

            string result = Console.ReadLine();

            //Converts string to int
            int number = int.Parse(result);

            LinearSearchInArray(arr, number);

            Console.WriteLine("");
            // for all recuression lovers out there
            var recurssionResult = RecursionLinearSearch(arr, 0, number);
            if (recurssionResult < 0)
                Console.WriteLine($"{number} Was not found");
            else
                Console.WriteLine($"{number} was found after {recurssionResult} times");
        }

        private static int RecursionLinearSearch(int[] arr, int index, int searchedTerm)
        {
            if (index > arr.Length)
                return -1;
            if (arr[index] == searchedTerm)
                return index;
            return RecursionLinearSearch(arr, index + 1, searchedTerm);
        }

        public static int LinearSearchInArray(int[] arr, int number)
        {
            //iterates the length of array
            for (int i = 0; i < arr.Length; i++)
            {
                //if iteration is equal to the value passed
                if(arr[i] == number)
                {
                    Console.WriteLine($"It was found after {i} iterations");
                    return i;
                }
            }
            //if value was not found
            Console.WriteLine("It was not found");
            return -1;
        }
    }
}
