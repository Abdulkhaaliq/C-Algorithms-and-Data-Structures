using System;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            NodeList node = new NodeList(9);

            node.AddToEnd(6);
            node.AddToEnd(4);

            node.AddToBeginning(2);
            node.AddToBeginning(7);

            node.AddSorted(81);
            node.AddSorted(73);
            node.AddSorted(100);

            node.Print();
        }
    }
}
