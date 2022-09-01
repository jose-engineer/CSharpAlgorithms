using System;
using System.Collections.Generic;

namespace Queue_Operations {
    //You can use queue to process data in the order it's recieved.
    //Queues reduce complexity by removing the index and applying the constraint FIFO
    class Program {
        static void Main(string[] args) {
            Queue<int> queue = new Queue<int>(); //FIFO

            queue.Enqueue(1); //First In, so this means number one will be removed first (First Out).
            queue.Enqueue(8);
            queue.Enqueue(20);
            queue.Enqueue(23);

            int removedItem = queue.Dequeue();
            Console.WriteLine(removedItem);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek()); //see 20 but don't removed

            // We can iterate through using while loop
            int current; //If true we get in this variable the removed item
            while (queue.TryDequeue(out current)) { //If empty returns false
                Console.WriteLine(current);
            }
        }
    }
}
