using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int i)
        {
            Data = i;
            Next = null;
        }

        public void AddSorted(int data)
        {
            if(Next == null)
            {
                Next = new Node(data);
            }
            else if(data < Next.Data)
            {
                Node temp = new Node(data);
                temp.Next = Next;
                Next = temp;
            }
            else
            {
                Next.AddSorted(data);
            }
        }

        //Adds to the end of linkedlist new data
        public void AddToEnd(int data)
        {
            if(Next == null)
            {
                Next = new Node(data);
            }
            else
            {
                Next.AddToEnd(data);
            }
        }

        //Prints linkedList
        public void Print()
        {
            Console.Write("|" + Data + "|" + "->");
            if(Next != null)
            {
                Next.Print();
            }
        }
    }
}
