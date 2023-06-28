using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class BinarySearchTree<T> where T : IComparable
    {
        T NodeData { get; set; }
        //property For Left tree and right tree
        public BinarySearchTree<T> leftNode { get; set; }
        public BinarySearchTree<T> rightNode { get; set; }
       bool result = false;

        public BinarySearchTree(T NodeData)
        {
            this.NodeData = NodeData;
            this.leftNode = null;
            this.rightNode = null;
        }
        int leftCount = 0;
        int rightCount = 0;
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.leftNode == null)
                    this.leftNode = new BinarySearchTree<T>(item);
                else
                    this.leftNode.Insert(item);
            }
            else
            {
                if (this.rightNode == null)
                    this.rightNode = new BinarySearchTree<T>(item);
                else
                    this.rightNode.Insert(item);
            }
        }
        public void Display()
        {
            if (this.leftNode != null)
            {
                this.leftCount++;
                this.leftNode.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.rightNode != null)
            {
                this.rightCount++;
                this.rightNode.Display();
            }
        }
        public void Size()
        {
            Console.WriteLine("Size of Binary Serach Tree " + (1 + leftCount + rightCount));
        }

        public bool ifExists(T element, BinarySearchTree<T> node)
        {
            if (node == null)
                return false;
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Found element in Binary Search Tree " + node.NodeData);
                return true;
            }
            else

                Console.WriteLine("Current element is {0} in BST ", node.NodeData);
            if (element.CompareTo(node.NodeData) < 0)
                ifExists(element, node.leftNode);
            if (element.CompareTo(node.NodeData) > 0)
                ifExists(element, node.rightNode);
            return result;
        }
    }
}

