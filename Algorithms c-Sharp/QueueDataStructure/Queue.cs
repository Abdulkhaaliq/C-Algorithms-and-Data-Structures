using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDataStructure
{
    public class Queue
    {
        public int front;
        public int rear = -1;
        public int numElements;
        object[] element;
        int maxSize;

        public Queue(int data)
        {
            element = new object[data];
            maxSize = data;
        }

        public bool Empty { get { return numElements == 0; } }
        public bool Full { get { return numElements == maxSize; } }
        public int Size { get { return numElements; } }



        public void Insert(object item)
        {
            if(Full) throw new Exception("Queue is full");
            rear = (rear + 1) % maxSize;
            element[rear] = item;
            numElements++;
        }

        public object Peek()
        {
            if(Empty) throw new Exception("Queue is empty");
            return element[front];
        }

        public void Remove()
        {
            if (Empty) throw new Exception("Queue is empty");
            element[front] = null;
            front = (front - 1) % maxSize;
            numElements--;
        }

        public void Clear()
        {
            while (!Empty)
            {
                Remove();
            }
        }

        public override string ToString()
        {
            string ans = "";
            int traveler = front;
            for(int i = 0; i < numElements; i++)
            {
                ans = ans + " " + element[traveler].ToString();
                traveler = (traveler + 1) % maxSize;
            }
            return ans;
        }
    }

}
