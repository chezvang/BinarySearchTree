using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class BinarySearchTree<T>
    {
        Node<int> head = null;

        int count;

        public BinarySearchTree()
        {

        }

        public void Add(int item)
        {
            Node<int> node = new Node<int>(item);
            if (head == null)
            {
                head = node; //sets first node as head node
                return;
            }

            Node<int> current = head;
            if (item < current.data)
            {
                current.left = node;
            }
            else
            {
                current.right = node;
            }
        }


        public bool Search(T searchData) //search method
        {
            Node<int> current = head;
            while (current.left != null)
            {
                if (current.data.Equals(searchData))
                {
                    return true;
                }
                current = current.right;
            }
            return false;
        }
    }
}
