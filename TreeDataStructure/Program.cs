using System;
using TreeDataStructure.Model;

namespace TreeDataStructure
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /* Taken from http://csharpexamples.com/c-binary-search-tree-implementation/*/
            BinaryTree binaryTree = new BinaryTree();
 
            binaryTree.Add(1);
            binaryTree.Add(2);
            binaryTree.Add(7);
            binaryTree.Add(3);
            binaryTree.Add(10);
            binaryTree.Add(5);
            binaryTree.Add(8);
 
            Node node = binaryTree.Find(5);
            int depth = binaryTree.GetTreeDepth();
 
            /*Visit the root
            Traverse the left subtree
            Traverse the right subtree */
            Console.WriteLine("PreOrder Traversal:");
            binaryTree.TraversePreOrder(binaryTree.Root);
            Console.WriteLine();
 
            /*Traverse the left subtree
            Visit the root
            Traverse the right subtree*/
            Console.WriteLine("InOrder Traversal:");
            binaryTree.TraverseInOrder(binaryTree.Root);
            Console.WriteLine();
 
            /*Traverse the left subtree
             Traverse the right subtree
             Visit the root
             */
            Console.WriteLine("PostOrder Traversal:");
            binaryTree.TraversePostOrder(binaryTree.Root);
            Console.WriteLine();
 
            binaryTree.Remove(7);
            binaryTree.Remove(8);
 
            Console.WriteLine("PreOrder Traversal After Removing Operation:");
            binaryTree.TraversePreOrder(binaryTree.Root);
            Console.WriteLine();
 
            Console.ReadLine();
        }
    }
}