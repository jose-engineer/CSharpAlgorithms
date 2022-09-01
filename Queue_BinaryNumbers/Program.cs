using System;
using System.Collections.Generic;

namespace Queue_BinaryNumbers {
    class Program {
        //Print out the first N binary numbers. Binary number is a number that consist of ones and zeros and is on base-2 numeral system
        //If N is equal or less than zero nothing should be printed. If N is 5 output should be:
        //1 -> 1    - We print an item
        //10 -> 2   - Print that same first item with a 0 appended to it
        //11 -> 3   - Then we print that first item with a 1 appended to it
        //100 -> 4  - We print the second item (10) with a 0 appended to it
        //101 -> 5  - Then we print that second item (10) with a 1 appended to it
        //110 -> 6
        //111 -> 7
        //So, we process the first and second item in a FIFO fashion, so we can use a Queue for this algorithm
        static void Main(string[] args) {
            PrintBinary(5);
            PrintBinary(-2);
            PrintBinary(0);
            PrintBinary(2);
            PrintBinary(8);
        }

        public static void PrintBinary(int n) {
            if (n <= 0) {
                return;
            }

            Queue<int> queue = new Queue<int>(); //FIFO - First In First Out 
            queue.Enqueue(1);

            for (int i = 0; i < n; i++) {
                int current = queue.Dequeue(); //Dequeue fist item
                Console.WriteLine(current);
                queue.Enqueue(current * 10);
                queue.Enqueue(current * 10 + 1);
            }

            Console.WriteLine();
        }
    }
}
