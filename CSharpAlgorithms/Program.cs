using System;

namespace Tree_BinarySearch
{
    class Program
    {
        class Node
        {
            public Node Left { get; set; }
            public Node Right { get; set; }            
            public int Data { get; set; }            
        }

        class BinarySearchTree
        {
            public static Node Insert(Node root, int value)
            {
                if (root == null)
                {
                    root = new Node();
                    root.Data = value;
                } else
                {
                    if (value < root.Data)
                    {                        
                        root.Left = Insert(root.Left, value);
                        //with node 4 this means root.Data = 4, no Left or Right reference this means root.Left = null and value = 2
                        //you call Insert recursively and for the second call root parameter should be null beacuse root.Left = null
                        //then function returns the root object (a Node) with root.Data = 2
                        //then the execution would go back to the initial call setting 2 as the left node (root.Left = 2) for the node 4
                    }
                    else if (value > root.Data)
                    {
                        root.Right = Insert(root.Right, value);
                    }
                }
                
                return root;
            }
        }

        static void Main(string[] args)
        {
            Node rootNode = new Node();
            rootNode.Data = 4;

            BinarySearchTree.Insert(rootNode, 2);
            BinarySearchTree.Insert(rootNode, 3);
            BinarySearchTree.Insert(rootNode, 5);
            BinarySearchTree.Insert(rootNode, 6);
            BinarySearchTree.Insert(rootNode, 4);

            Console.WriteLine();
        }
    }
}

