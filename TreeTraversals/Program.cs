using System;

namespace Tree_Traversals
{
    //Pre-Order: Root -> Left -> Right
    //In-Order: Left -> Root -> Right
    //Post-Order: Left -> Right -> Root   

    class Program
    {
        class Node
        {
            public Node Left { get; set; }
            public Node Right { get; set; }
            public int Data { get; set; }

        }

        class BinaryTree //This class wil hold the traversal, it will display the data from our tree
        {
            public static void PreOrderTraversal(Node root)
            {
                if (root == null)
                {
                    return;
                }
                
                Console.Write(root.Data + " ");
                PreOrderTraversal(root.Left);
                PreOrderTraversal(root.Right);
            }

            public static void InOrderTraversal(Node root)
            {
                if (root == null)
                {
                    return;
                }
                
                InOrderTraversal(root.Left);
                Console.Write(root.Data + " ");
                InOrderTraversal(root.Right);
            }

            public static void PostOrderTraversal(Node root)
            {
                if (root == null)
                {
                    return;
                }

                PostOrderTraversal(root.Left);                
                PostOrderTraversal(root.Right);
                Console.Write(root.Data + " ");
            }
        }

        static void Main(string[] args)
        {
            //     4
            //  1      3
            //8   9  6

            //Create a small binary tree, it is not a binary search tree because it does not meet the ordering constraint
            Node rootNode = new Node();
            rootNode.Data = 4;

            Node NodeOne = new Node();
            NodeOne.Data = 1;

            Node NodeThree = new Node();
            NodeThree.Data = 3;

            Node NodeEight = new Node();
            NodeEight.Data = 8;

            Node NodeNine = new Node();
            NodeNine.Data = 9;

            Node NodeSix = new Node();
            NodeSix.Data = 6;

            rootNode.Left = NodeOne;
            rootNode.Right = NodeThree;
            NodeOne.Left = NodeEight;
            NodeOne.Right = NodeNine;
            NodeThree.Left = NodeSix;

            BinaryTree.PreOrderTraversal(rootNode);
            Console.WriteLine();
            BinaryTree.InOrderTraversal(rootNode);
            Console.WriteLine();
            BinaryTree.PostOrderTraversal(rootNode);
        }
    }
}
