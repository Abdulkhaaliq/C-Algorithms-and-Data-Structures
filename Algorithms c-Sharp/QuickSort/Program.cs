using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 5, 0, 34, 3, 9, 20, 18 };

            foreach(int number in intArray)
            {
                Console.Write(number + " ");
            }

            var result = QuickSort(intArray, 0, intArray.Length);
            Console.WriteLine();

            foreach (int res in result)
            {
                Console.Write(res + " ");
            }
        }

        public static int[] QuickSort(int[] intArray, int start, int end)
        {
            if(start < end)
            {
                int pivot = Partion(intArray, start, end);
                QuickSort(intArray, start, pivot);
                QuickSort(intArray, pivot + 1, end);

            }
          return intArray;
        }
        
        public static void Swap(int[] intArray, int i, int j)
        {
            int temp = intArray[i];
            intArray[i] = intArray[j];
            intArray[j] = temp;
        }

        public static int Partion(int[] intArray, int start, int end)
        {
            int pivot = intArray[start];
            int index = start;

            for(int i = start + 1; i < end; i++)
            {
                if (intArray[i] < pivot)
                {
                    index++;
                    Swap(intArray, i, index);
                }
            }
            Swap(intArray, start, index);
            return index;
        }
    }
}
