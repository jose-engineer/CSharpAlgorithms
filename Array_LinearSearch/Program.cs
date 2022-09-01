using System;

namespace Array_LinearSearch {
    class Program {
        static void Main(string[] args) {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };            

            Console.WriteLine(LinearSearch(arr, 4));
            Console.WriteLine(LinearSearch(arr, 8));

            Console.WriteLine();

            int item = Array.Find(arr, x => x == 4);
            Console.WriteLine(item);
            Console.WriteLine();
            int[] items = Array.FindAll(arr, x => x >= 5);
            Array.ForEach(items, Console.WriteLine);
        }

        public static bool LinearSearch(int[] input, int n) {
            if (input.Length == 0)
                return false;
            
            foreach (var item in input) {
                if (item == n) {
                    return true;
                    //return n;
                }
            }

            return false;
            //return -1; //We don't return the finded value we return a sentinel value instead
            //return null; //Also we can return "null" but we should use "?" in the return type this means "int?"
        }
    }
}
