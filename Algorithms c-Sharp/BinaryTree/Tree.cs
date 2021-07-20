using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Tree
    {
        public Node HeadRoot { get; set; }
        public Tree()
        {
            HeadRoot = null;
        }

        public void InsertIntoTree(int data)
        {
            // 1. If the tree is empty, return a new, single node 
            if (HeadRoot == null)
            {
                HeadRoot = new Node(data);
                return;
            }
            // 2. Otherwise, recur down the tree 
            InsertRecurssion(HeadRoot, new Node(data));
        }
        private void InsertRecurssion(Node root, Node newNode)
        {
            if (root == null)
                root = newNode;

            //Add to the left if smaller
            if (newNode.Data < root.Data)
            {
                if (root.Left == null)
                    root.Left = newNode;
                else
                    InsertRecurssion(root.Left, newNode);

            }
            else
            {  //add to right if bigger
                if (root.Right == null)
                    root.Right = newNode;
                else
                    InsertRecurssion(root.Right, newNode);
            }
        }

        //print doesn't work all too well but binary tree is there
        private void DisplayTree(Node root)
        {
            if (root == null) return;

            DisplayTree(root.Left);
            Console.Write(root.Data + " ");
            DisplayTree(root.Right);
        }
        public void DisplayTree()
        {
            DisplayTree(HeadRoot);
        }
    }
}
