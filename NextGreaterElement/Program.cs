using System;
using System.Collections.Generic;

namespace Stack_NextGreaterElement
{
    //Print the next greater element for every element in the array.
    //The next greater element is the first larger element on the right side of the array.
    class Program
    {
        static void Main(string[] args)
        {
            //int[] A = new int[] { 15, 8, 4, 10 };
            //int[] A2 = new int[] { 2 };
            //int[] A3 = new int[] { 2, 3 };
            //int[] A4 = new int[] { };

            PrintNextGreaterElement(new int[] { 15, 8, 4, 10 }); //Expected: 4 --> 10, 8 --> 10, 10 --> -1, 15 --> -1
            Console.WriteLine();
            PrintNextGreaterElement(new int[] { 2 }); //Expected: 2 --> -1
            Console.WriteLine();
            PrintNextGreaterElement(new int[] { 2, 3 }); //Expected: 2 --> 3, 3 --> -1
            Console.WriteLine();
            PrintNextGreaterElement(new int[] { }); //Expected: 
        }

        public static void PrintNextGreaterElement(int[] arr)
        {
            if(arr.Length <= 0) {
                return;
            }
            
            Stack<int> stack = new Stack<int>(); //LIFO - Last In First Out - horizontal alignment
            stack.Push(arr[0]);

            for (int i = 1; i < arr.Length; i++) {
                int next = arr[i];

                if (stack.Count > 0) {
                    int popped = stack.Pop();
                    while (popped < next) {
                        Console.WriteLine(popped + "-->" + next);
                        if (stack.Count == 0) {
                            break;
                        }
                        popped = stack.Pop(); //pop and check again, to keep track of the items
                    }
                    if (popped > next) {
                        stack.Push(popped); //push back again the popped
                    }
                }
                stack.Push(next);
            }

            while (stack.Count > 0) {
                Console.WriteLine(stack.Pop() + "-->" + -1); 
            }
        }
    }
}
