﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            tree.Add(50);
            tree.Add(10);
            tree.Add(60);
            tree.Add(75);
            tree.Add(25);

            Console.WriteLine(tree);
        }
    }
}
