﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class Node
    {
        public int Data;
        public List<int> Edges = new List<int>();

        public Node(int data)
        {
            Data = data;
        }
    }
}
