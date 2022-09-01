using System;

namespace LinkedList_DeleteBackhalf {
    //Delete the back half of a linked list. Set the appropriate next pointer equal to null.
    //Original: 5 -> 8 -> 10 -> 13 -> null
    //Modified: 5 -> 8 -> null
    class CustomLinkedList { //This class wrap all the code
        Node head;

        public class Node { //Node class
            public int data;
            public Node next;

            public Node(int d) { //Node class constructor
                data = d;
            }
        }
        public void DeleteBackHalf() {
            if (head == null || head.next == null) { //If null the list must have zero elements or only one element
                head = null; //This will keep the list empty or it will delete single item in the list
            }

            Node slow = head;
            Node fast = head;
            Node prev = null;

            while (fast != null && fast.next != null) { //if null means the pointer is at the list or at the last element of the list                                
                prev = slow; //The prev node will run just behind the slow node, at the end of the while slow will be in the middle and will set prev with that element
                slow = slow.next; //the fast pointer will move twice as fast as the slow pointer, 
                fast = fast.next.next; //when the fast pointer reaches the end of the list the slow pointer will be at the middle element of the list
            }

            prev.next = null; //This deletes the middle node and everithing after it
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
                //Create a linked list from our CustomLinkedList class like:
                CustomLinkedList linkedList = new CustomLinkedList();

                Node firstNode = new Node(5);
                Node secondNode = new Node(8);
                Node thirdNode = new Node(10);
                Node fourthNode = new Node(13);

                linkedList.head = firstNode;
                firstNode.next = secondNode;
                secondNode.next = thirdNode;
                thirdNode.next = fourthNode; //Fourth is the last node We don't need to set it's next pointer because is already null

                linkedList.DisplayContents();
                linkedList.DeleteBackHalf();
                Console.WriteLine();
                linkedList.DisplayContents();

            }            
        }        
    }

    
}
