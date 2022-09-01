using System;
using System.Collections.Generic;

namespace Stack_Operations {
    //You can use Stack if you need to keep track of the state in your algorithm
    //Like Queues reduce complexity by removing the index and applying the constraint LIFO
    class Program {
        static void Main(string[] args) {
            //Emulate the runtime stack. Stack will help to track of where each function was called.
            Stack<string> stack = new Stack<string>();

            Console.WriteLine("Start Main");
            stack.Push("Main");
            Console.WriteLine("Start ResponseBuilder");            
            stack.Push("ResponseBuilder");
            Console.WriteLine("Start CallExternalService");
            stack.Push("CallExternalService");
            Console.WriteLine("END " + stack.Pop()); //Each pop statement returns the item on the top of the stack
            Console.WriteLine("Start ParseExternalData");
            stack.Push("ParseExternalData");
            Console.WriteLine("END " + stack.Pop());
            Console.WriteLine("END " + stack.Pop());
            Console.WriteLine("END " + stack.Pop());

            Console.WriteLine();

            // stack.Peek() Peeks at the top of the stack  without removing the item   
            // stack.TryPeek()

            string item;
            Console.WriteLine(stack.TryPeek(out item)); // returns false in this case because there is not item to peek
        }
    }
}
