using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BST_C_Sharp
{
    class BST
    {
        public Node Root { get; set; }

        List<int> primeNumbers = new List<int>();

        public Node ReturnRoot()
        {
            return Root;
        }

        public bool addItem(int value)
        {
            Node before = null, after = this.Root; //Nodes

            while (after != null) //Loop condition
            {
                before = after;
                if (value < after.Data) //Is new node in left tree?
                    after = after.LeftNode;
                else if (value > after.Data) //Is new node in right tree?
                    after = after.RightNode;
                else
                {
                    //Exist same value
                    return false;
                }
            }

            Node newNode = new Node(); //New node
            newNode.Data = value;

            if (this.Root == null) //Tree is empty
                this.Root = newNode;
            else
            {
                if (value < before.Data)
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;
            }
            return true;
        }

        public void fillBinaryTree(string filename)
        {
            try
            {
                FileStream fs = new FileStream(filename, FileMode.Open); //Open connection
                if (File.Exists(filename)) //File exist or no?
                {
                    if (new FileInfo(filename).Length == 0) //Checks if the file is empty
                    {
                        Console.WriteLine("File is empty! "); //Error message
                        Console.ReadLine();
                    }
                    else
                    {

                        StreamReader sr = new StreamReader(fs); //TextReader

                        while (!sr.EndOfStream)
                        {
                            int temp = int.Parse(sr.ReadLine()); //Converting
                            addItem(temp); //Adding 
                            primeNumbers.Add(temp);
                        }

                        sr.Close(); //Connection close
                    }
                }
            }
            catch (Exception ex) //Error catch 
            {
                Console.WriteLine(ex.Message); //Error catch message
            }
        }

        public void TraversePreOrder(Node parent) //Method for traverse pre order
        {
            if (parent != null) //Condition
            {
                Console.Write(parent.Data + " "); //Checks the root
                TraversePreOrder(parent.LeftNode); //Checks left node
                TraversePreOrder(parent.RightNode); //Checks right node
            }
        }

        public void TraverseInOrder(Node parent) //Method for traverse in order
        {
            if (parent != null) //Condition
            {
                TraverseInOrder(parent.LeftNode); //Checks left node
                Console.Write(parent.Data + " "); //Checks the root
                TraverseInOrder(parent.RightNode); //Checks right node
            }
        }

        public void TraversePostOrder(Node parent) //Method for traverse post order
        {
            if (parent != null) //Condition
            {
                TraversePostOrder(parent.LeftNode); //Checks left node
                TraversePostOrder(parent.RightNode); //Checks right node
                Console.Write(parent.Data + " "); //Checks the root
            }
        }

        public void printLevelOrder(Node root) //Method for level order
        {
            //Base case  
            if (root == null) //Condition
                return;

            //Create an empty queue for level order tarversal  
            Queue<Node> q = new Queue<Node>();

            //Enqueue Root and initialize height  
            q.Enqueue(root);

            while (true)
            {

                //nodeCount (queue size) indicates number of nodes at current level
                int nodeCount = q.Count;
                if (nodeCount == 0) //If equal 0 we stop the loop
                    break;

                //Dequeue all nodes of current level and Enqueue all nodes of next level  
                while (nodeCount > 0)
                {
                    Node node = q.Peek();
                    Console.Write(node.Data + " ");
                    q.Dequeue();
                    if (node.LeftNode != null) //Condition
                        q.Enqueue(node.LeftNode); //Enqueue left node
                    if (node.RightNode != null) //Condition
                        q.Enqueue(node.RightNode); //Enqueue right node
                    nodeCount--;
                }
                Console.WriteLine();
            }
        }

        public bool checkPrime(int num) //Method to check prime numbers
        {

            bool divided = false;
            if (num < 1)
            {
                divided = false;
            }
            else
            {
                for (int j = 2; j <= Math.Sqrt(num); j++)
                {
                    if (num % j == 0)
                    {
                        divided = true;
                        break;
                    }
                }
            }
            return divided;
        }

        public void printPrimeNumbers(Node parent)
        {
            foreach (int i in primeNumbers)
            {
                if (checkPrime(i) == false && i != 1)
                    Console.Write(i + "   ");
            }
            primeNumbers.Clear();
        }
    }
}