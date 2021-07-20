using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class Graph
    {
        Node[] nodes;
        int count;
        public Graph(int max)
        {
            nodes = new Node[max];
            count = 0;
        }

        public void AddNode(int data)
        {
            nodes[count] = new Node(data);
            count++;
        }

        private int FindNode(int data)
        {
            for(int i = 0; i < nodes.Length; i++)
            {
                if (nodes[i].Data == data)
                    return i;
            }
            return -1;
        }

        public void AddEdges(int x, int y)
        {
            int xIndex = FindNode(x);
            int yIndex = FindNode(y);
            if (xIndex == -1 || yIndex == -1)
                nodes[xIndex].Edges.Add(y);
             nodes[yIndex].Edges.Add(x);
        }

        public void Swap(int x, int y)
        {
            int xIndex = FindNode(x);
            int yIndex = FindNode(y);
            Node temp = nodes[xIndex];
            nodes[xIndex] = nodes[yIndex];
            nodes[yIndex] = temp;
        }

        public int FindMax()
        {
            int max = nodes[0].Data;
            for(int i = 0; i < nodes.Length; i++)
            {
                if (nodes[i].Data > max)
                    max = nodes[i].Data;
            }
            return max;
        }

        public void DeleteNode(int x)
        {
            int intPos = FindNode(x);
            Node[] temp = new Node[nodes.Length - 1];
            for(int i = 0; i < nodes.Length; i++)
            {
                if(i < intPos)
                {
                    temp[i] = nodes[i];
                }
                if (i > intPos)
                {
                    temp[i - 1] = nodes[i];
                }
            }
            DeleteEdge(x);
            nodes = temp;
            count--;
        }

        public void AddNewNode(int x)
        {
            Node[] temp = new Node[nodes.Length + 1];
            for (int i = 0; i < nodes.Length; i++)
            {
                temp[i] = nodes[i];
            }
            temp[nodes.Length] = new Node(x);
            count++;
            nodes = temp;
        }

        public void DeleteEdge(int x)
        {
            for(int i = 0; i < nodes.Length; i++)
            {
                for(int j = 0; j < nodes[i].Edges.Count; j++)
                {
                    if(nodes[i].Edges[j] == x)
                    {
                        nodes[i].Edges.Remove(x);
                    }
                }
            }
        }

        public void Print()
        {
            for (int i = 0; i < nodes.Length; i++)
            {
                Console.Write($"({nodes[i].Data})-");
                for (int j = 0; j < nodes[i].Edges.Count; j++)
                {
                    Console.Write($"{nodes[i].Edges[j]}");
                }
                Console.Write("");
            }
        }
    }
}
