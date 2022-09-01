using System;

namespace Array_Reverse {
    class Program {
        static void Main(string[] args) {
            int[] arr = { 1, 2, 3, 4, 5, 6 };            
            int[] result = Reverse(arr);
            Array.ForEach(result, Console.WriteLine); //Expected: 6, 5, 4, 3, 2, 1

            Console.WriteLine();

            int[] arr2 = { 1, 2, 3, 4, 5, 6 };
            ReverseInPlace(arr2);
            Array.ForEach(arr2, Console.WriteLine); //Expected: 6, 5, 4, 3, 2, 1
        }

        public static int[] Reverse(int[] input) {
            int[] reversed = new int[input.Length];

            for (int i = 0; i < reversed.Length; i++) {
                reversed[i] = input[(input.Length -1) - i];
            }
            return reversed;
        }

        public static void ReverseInPlace(int[] input) {            
            for (int i = 0; i < input.Length / 2; i++) {                
                int temp = input[i];
                input[i] = input[(input.Length - 1) - i];
                input[(input.Length - 1) - i] = temp;
            }            
        }
    }
}
