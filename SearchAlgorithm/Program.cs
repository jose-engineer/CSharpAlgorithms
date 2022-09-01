using System;

namespace Tree_SearchAlgorithm
{
    class Program
    {
        class Node
        {
            public int Data { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
        }

        class BinarySearchTree
        {
            //Function that returns true if the vaue exists in the tree
            public static bool ContainsValue(Node root, int value)
            {                
                if (root == null)
                {
                    return false;
                } else if (value < root.Data) { //Since this is a binary search tree we have a constarint of order so we only need to check one side of the tree
                    return ContainsValue(root.Left, value);
                } else if (value > root.Data)
                {
                    return ContainsValue(root.Right, value);
                } else
                {
                    return true;
                }                
            }

            public static Node Insert(Node root, int value)
            {
                if (root == null)
                {
                    root = new Node();
                    root.Data = value;
                } else if (value < root.Data ) {
                    root.Left = Insert(root.Left, value);
                } else if (value > root.Data) {
                    root.Right = Insert(root.Right, value);
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

            //Search values
            Console.WriteLine(BinarySearchTree.ContainsValue(rootNode, 4));
            Console.WriteLine(BinarySearchTree.ContainsValue(rootNode, 3));
            Console.WriteLine(BinarySearchTree.ContainsValue(rootNode, 6));

            Console.WriteLine(BinarySearchTree.ContainsValue(rootNode, 0));
            Console.WriteLine(BinarySearchTree.ContainsValue(rootNode, -4));
            Console.WriteLine(BinarySearchTree.ContainsValue(null, 4));
        }
    }
}
