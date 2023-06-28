using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class Program
    {
        public static void Main(string[] args) 
        {
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>(56);
            binarySearchTree.Insert(70);
            binarySearchTree.Insert(30);
            binarySearchTree.Insert(40);
            binarySearchTree.Insert(50);
            binarySearchTree.Insert(60);
            binarySearchTree.Insert(52);
            binarySearchTree.Insert(5);
            binarySearchTree.Insert(42);
            binarySearchTree.Insert(43);
            binarySearchTree.Insert(55);
            Console.WriteLine("Binary Search Tree -");
            binarySearchTree.Display();
            binarySearchTree.Size();
            bool findElement = binarySearchTree.ifExists(63, binarySearchTree);
            Console.WriteLine(findElement);
        }
    }
}