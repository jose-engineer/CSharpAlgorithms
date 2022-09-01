using System;

namespace LinkedList_DeleteKthNode {
    //Delete Kth node form the end of the list
    //Original 4 -> 6 -> 10 -> 3 -> 11 -> null
    //k = 1
    //The first node from the end of the list is 11
    //Modified: 4 -> 6 -> 10 -> 3 -> null
    //Then if k = 4
    //Modified: 6 -> 10 -> 3 -> null
    //Then if k = 2
    //Modified: 6 -> 3 -> null

    class CustomLinkedList {
        Node head;

        public class Node {
            public int data;
            public Node next;

            public Node(int d) {
                data = d;
            }
        }

        public void DeleteKthNodeFromEnd(int k) { //Since this method is part of the CustomLinkedList class we don't need to add the linked list as input
            if (head == null || k == 0) {
                return;
            }
            // [a, b, c, d, e]
            // k = 2
            //Pointers or trackers
            Node first = head;
            Node second = head;

            //We use a for loop to increment the second node 
            for (int i = 0; i < k; i++) { //We'll move the second node to the Kth element from the HEAD of the linked list
                second = second.next; //we'll continue to go to the next pointer until we hit the Kth node
                if (second.next == null) { //If second.next == null it means we reached the last element of the list,
                    //... k must be greater or equal to the number of items, k >= Length of List
                    //when k match the lenght of the list, the first element was deleted.
                    //In a list of 4, the fouth item from the end is the first(Kth) element
                    if (i == k - 1) { //Check if k equals the lenght of the list
                        head = head.next; //delete the first element
                    }
                    return; //leave the list unmodified if k is greater than the number of items in the list (as a second choice, we could also delete the first item of the list)
                            //In other words, leave the list unmodified if k is not between one and n
                }
            }
            //After the incrementation
            //head = a
            //second = c, c is the second node from the head of the list 
            //Then in the while we incremente both pointers at the same tima until the second pointer reaches the last element

            //After the loop the second node is pointing to the Kth element from the HEAD of the list.

            //To find the element that is the Kth node from the END of the list we can increment both the first and the second pointers
            //until the second pointer reaches the last element
            while (second.next != null) { //If second equals null we are at the last element, 
                //...so while it does not equal null we increment the pointers
                first = first.next;
                second = second.next;
                //When the second node reaches the end of the list the first node will be at the Kth element,
                //that's the element we want to delete.
                //When second.next == null, the first node will be at the Kth element from the END of the list.
            }

            // [a, b, c, d, e]
            //After two interations:
            // first = c, first.next = d
            // second = e
            //We want to delete the 2th node from the end of the list, in this case "d", means first.next
            first.next = first.next.next; //Set first.next (d) to first.next.next (e)
            // d = e
            //[a, b, c, e, e] or [a, b, c, e], we "deleted" d.

        }

        public void DisplayContents() {
            Node current = head;

            while (current != null) {
                Console.Write(current.data + "->");
                current = current.next;
            }
        }

        class Program {
            static void Main(string[] args) {
                CustomLinkedList linkedList = new CustomLinkedList();

                Node firstNode = new Node(4);
                Node secondNode = new Node(6);
                Node thirdNode = new Node(10);
                Node fourthNode = new Node(3);
                Node fifthNode = new Node(11);

                linkedList.head = firstNode;
                firstNode.next = secondNode;
                secondNode.next = thirdNode;
                thirdNode.next = fourthNode;
                fourthNode.next = fifthNode;

                linkedList.DisplayContents();
                linkedList.DeleteKthNodeFromEnd(2);
                Console.WriteLine();
                linkedList.DisplayContents();
            }
        }
    }    
}
