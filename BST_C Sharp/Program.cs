using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BST_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {

            BST bst1 = new BST();
            Console.WriteLine("First Binary Search Tree:\n");
            bst1.fillBinaryTree("file3.txt");
            Console.WriteLine("Level Order: "); bst1.printLevelOrder(bst1.ReturnRoot()); Console.WriteLine();
            Console.WriteLine("In Order: "); bst1.TraverseInOrder(bst1.ReturnRoot()); Console.WriteLine();
            Console.WriteLine("Post Order: "); bst1.TraversePostOrder(bst1.ReturnRoot()); Console.WriteLine();
            Console.WriteLine("Pre Order: "); bst1.TraversePreOrder(bst1.ReturnRoot()); Console.WriteLine();
            Console.WriteLine("Prime Numbers: "); bst1.printPrimeNumbers(bst1.ReturnRoot()); Console.WriteLine();
            Console.WriteLine("========================================");

            BST bst2 = new BST();
            Console.WriteLine("Second Binary Search Tree:\n");
            bst2.fillBinaryTree("file5.txt");
            Console.WriteLine("Level Order: "); bst2.printLevelOrder(bst2.ReturnRoot()); Console.WriteLine();
            Console.WriteLine("In Order: "); bst2.TraverseInOrder(bst2.ReturnRoot()); Console.WriteLine();
            Console.WriteLine("Post Order: "); bst2.TraversePostOrder(bst2.ReturnRoot()); Console.WriteLine();
            Console.WriteLine("Pre Order: "); bst2.TraversePreOrder(bst2.ReturnRoot()); Console.WriteLine();
            Console.WriteLine("Prime Numbers: "); bst2.printPrimeNumbers(bst2.ReturnRoot()); Console.WriteLine();
            Console.WriteLine("========================================");

            BST bst3 = new BST();
            Console.WriteLine("Third Binary Search Tree:\n");
            bst3.fillBinaryTree("file6.txt");
            Console.WriteLine("Level Order: "); bst3.printLevelOrder(bst3.ReturnRoot()); Console.WriteLine();
            Console.WriteLine("In Order: "); bst3.TraverseInOrder(bst3.ReturnRoot()); Console.WriteLine();
            Console.WriteLine("Post Order: "); bst3.TraversePostOrder(bst3.ReturnRoot()); Console.WriteLine();
            Console.WriteLine("Pre Order: "); bst3.TraversePreOrder(bst3.ReturnRoot()); Console.WriteLine();
            Console.WriteLine("Prime Numbers: "); bst3.printPrimeNumbers(bst3.ReturnRoot()); Console.WriteLine();
            Console.WriteLine("========================================");

            Console.ReadLine();
        }
    }
}