using System;

namespace Array_BinarySearch {
    class Program {
        static void Main(string[] args) {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine(BinarySearch(arr, 5));
            Console.WriteLine();
            Console.WriteLine(Array.BinarySearch(arr, 5));
        }

        //We are assuming that the input array is sorted, and it's sorted in ascending order
        public static bool BinarySearch(int[] input, int n) {
            int min = 0;
            int max = input.Length -1;
            
            while (min <= max) {
                int mid = (min + max) / 2;

                if (n == input[mid]) {
                    return true;
                } else if (n < input[mid]) {
                    max = mid - 1;
                } else {
                    min = mid + 1;
                }                
            }            
            return false;
        }
    }
}
