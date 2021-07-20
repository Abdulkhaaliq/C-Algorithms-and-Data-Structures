using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            tree.InsertIntoTree(24);
            tree.InsertIntoTree(72);
            tree.InsertIntoTree(45);
            tree.InsertIntoTree(18);
            tree.InsertIntoTree(3);
            tree.DisplayTree();
        }
    }
}
