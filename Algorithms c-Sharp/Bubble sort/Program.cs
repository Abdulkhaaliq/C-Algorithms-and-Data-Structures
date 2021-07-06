using System;

namespace Bubble_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] unsortedList = { 36, 42, 7, 27, 100, 10, 18};

            /*
             1.)  36, 42, 7, 27, 100, 10, 18
             2.)  36, 7, 27, 42, 10, 18, 100
             3.)  7, 27, 36, 10, 18, 42, 100
             4.)  7, 27, 10, 18, 36, 42, 100
             5.)  7, 10, 18, 27, 36, 42, 100
             */

            BubbleSort(unsortedList);
        }

        public static void BubbleSort(double[] unsortedList)
        {
            double temp;

            for(int i =0; i < unsortedList.Length - 1; i++)
            {
                for(int j = 0; j < unsortedList.Length - (1 + i); j++)
                {
                    if(unsortedList[j] > unsortedList[j+ 1])
                    {
                        temp = unsortedList[j + 1];
                        unsortedList[j + 1] = unsortedList[j];
                        unsortedList[j] = temp;
                    }
                }
            }
          
        }
    }
}
