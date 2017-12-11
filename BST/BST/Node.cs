using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class Node <T>
    {
        public int data;

        public Node<int> left;
        public Node<int> right;

        public Node()
        {
            
        }

        public Node(int item)
        {
            data = item;
        }
    }
}
