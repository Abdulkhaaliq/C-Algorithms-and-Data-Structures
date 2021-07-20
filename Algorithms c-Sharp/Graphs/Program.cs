using System;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph(7);
            graph.AddNode(1);
            graph.AddNode(2);
            graph.AddNode(3);
            graph.AddNode(4);
            graph.AddNode(5);
            graph.AddNode(6);
            graph.AddNode(7);

            graph.AddEdges(4, 1);
            graph.AddEdges(4, 2);
            graph.AddEdges(4, 3);
            graph.AddEdges(4, 5);
            graph.AddEdges(4, 6);
            graph.AddEdges(4, 7);

            graph.AddEdges(1, 2);
            graph.AddEdges(1, 3);

            graph.AddEdges(7, 5);
            graph.AddEdges(7, 6);


            graph.Print();
            Console.WriteLine("--------------------------------");

            graph.Swap(4, 7);

            graph.Print();
            Console.WriteLine("--------------------------------");

            Console.WriteLine($"Max: {graph.FindMax()}");
            Console.WriteLine("--------------------------------");

            graph.DeleteNode(5);
            graph.Print();
            Console.WriteLine("--------------------------------");

            graph.AddNewNode(8);
            graph.Print();
            Console.WriteLine("--------------------------------");

            Console.WriteLine($"Max: {graph.FindMax()}");
            Console.WriteLine("--------------------------------");
        }
    }
}
