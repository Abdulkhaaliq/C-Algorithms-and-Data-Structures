using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    public class NodeList
    {
        public Node HeadNode { get; set; }

        public NodeList(int i)
        {
            HeadNode = null;
        }

        public void AddSorted(int data)
        {
            if (HeadNode == null)
            {
                HeadNode = new Node(data);
            }
            else if (data < HeadNode.Data)
            {
                AddToBeginning(data);
            }
            else
            {
                HeadNode.AddSorted(data);
            }
       
        }

        //Adds to Beginning of linkedList
        public void AddToBeginning(int data)
        {
            if(HeadNode == null)
            {
                HeadNode = new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.Next = HeadNode;
                HeadNode = temp;
            }
        }

        //Adds to end of linkedList
        public void AddToEnd(int data)
        {
            if (HeadNode == null)
            {
                HeadNode = new Node(data);
            }
            else
            {
                HeadNode.AddToEnd(data);
            }
        }

        //Prints linkedList
        public void Print()
        {
       
            if (HeadNode != null)
            {
                HeadNode.Print();
            }
     
        }
    }
}
