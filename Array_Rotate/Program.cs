using System;

namespace Array_Rotate {
    class Program {
        //Create an algorithm that rotates the contents of an array to the left by one space.
        //This rotation should be done in place. A new array shold not be created.
        static void Main(string[] args) {
            int[] arr = { 1, 2, 3, 4, 5, 6 }; //Output should be: { 2, 3, 4, 5, 6, 1 };
            RotateLeft(arr);            
            Array.ForEach(arr, Console.WriteLine);
            Console.WriteLine();
            RotateRight(arr);
            Array.ForEach(arr, Console.WriteLine);
        }

        static void RotateLeft(int[] input) {
            int first = input[0];

            for (int i = 0; i < input.Length - 1; i++) {
                input[i] = input[i + 1];
            }

            input[input.Length - 1] = first;
        }

        static void RotateRight(int[] input) {
            int last = input[input.Length - 1];

            for (int i = input.Length - 1; i > 0; i--) {
                input[i] = input[i - 1];
            }

            input[0] = last;
        }

        //static void Rotate2(int[] input) {
        //    int first = input[0];

        //    for (int i = 0; i < input.Length; i++) {                                                

        //        if (!(i == input.Length - 1)) {
        //            input[i] = input[i + 1];                    
        //        } else {
        //            input[input.Length - 1] = first;
        //        }
        //    }
        //}
    }
}
