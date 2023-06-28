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
            Console.WriteLine("Binary Search Tree -");
            binarySearchTree.Display();
          
        }
    }
}