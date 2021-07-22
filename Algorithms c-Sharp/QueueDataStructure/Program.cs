using System;

namespace QueueDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue(3);
            DisplayHeader();
            char option = Console.ReadLine()[0];
            while (option != 'Q') 
            {
                switch (option)
                {
                    case 'I':
                        Console.Write("Enter Item: ");
                        try
                        {
                            queue.Insert(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                        break;

                    case 'P':
                        try
                        {
                            string result = (string)queue.Peek();
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                        break;
                    case 'R':
                        try
                        {
                            queue.Remove();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                        break;
                    case 'S':
                        Console.WriteLine(queue.ToString());
                        break;
                    case 'X':
                        queue.Clear();
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
                
                DisplayHeader();
                option = Console.ReadLine()[0];
            }
        }

        public static void DisplayHeader()
        {
            Console.WriteLine("Enter one of the following: ");
            Console.WriteLine("I - insert");
            Console.WriteLine("P - peek");
            Console.WriteLine("R - remove");
            Console.WriteLine("S - show queue");
            Console.WriteLine("X - clear queue");
            Console.WriteLine("Q - quit");
            Console.WriteLine("-----------------------");
        }
    }
}
