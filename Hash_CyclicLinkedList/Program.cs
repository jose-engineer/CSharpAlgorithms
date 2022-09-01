using System;
using System.Collections.Generic;

namespace Hash_CyclicLinkedList {
    //Create an algorithm that detects a cycle within a linked list. Linked list with a cycle:
    //1 -> 2 -> 3
    //     ^
    //     |    |
    //     5 <- 4
    //Same linked list without a cycle:
    //1 -> 2 > 3 -> 4 -> 5 > null

    class CustomLinkedList {

        Node head;

        public class Node {
            public int data;
            public Node next;
            
            public Node(int d) {
                data = d;
                next = null;
            }
        }

        //This algorithm runs in constant time O(1) beacuse we are using HashSet
        public bool HasCycle() { //We need to check that a given next pointer is not pointing to a node we've already seen in the list
            HashSet<Node> hash = new HashSet<Node>(); //Since this a question of membership we use HashSet

            Node current = head;

            while(current != null) { //if current not null there are still elements in the list
                if (hash.Contains(current)) { //If true this is a node that we've already seen in the list, so it mush have a cycle
                    return true;
                } else {
                    hash.Add(current);                    
                }
                current = current.next;
            }

            return false;
        }

        class Program {
            static void Main(string[] args) {                
                Node firstNode = new Node(3);
                Node secondNode = new Node(4);
                Node thirdNode = new Node(5);
                Node fourthNode = new Node(6);

                CustomLinkedList noCycleLinkedList = new CustomLinkedList();
                noCycleLinkedList.head = firstNode;
                firstNode.next = secondNode;
                secondNode.next = thirdNode;
                thirdNode.next = fourthNode; //fourth.next is equals to null

                Console.WriteLine(noCycleLinkedList.HasCycle());

                Console.WriteLine();

                CustomLinkedList cycleLinkedList = new CustomLinkedList();                
                cycleLinkedList.head = firstNode;                
                thirdNode.next = secondNode;

                Console.WriteLine(cycleLinkedList.HasCycle());
            }
        }
    }    
}
