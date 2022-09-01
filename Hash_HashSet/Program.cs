using System;
using System.Collections.Generic;

namespace Hash_HashSet {
    //Find items present in the first array, but not the second array. This is a question of membership, good to use HashSet.
    //We are able to retrieve and search data in Constant Time O(1), because each item stored in the HasSet is unique
    class Program {
        static void Main(string[] args) {
            int[] arr1 = { 3, 2, 8, 4, 5 };
            int[] arr2 = { 5, 7, 3, 0, 2 };

            var result = FindMissingElements(arr1, arr2);
            result.ForEach(Console.WriteLine);            
        }

        public static List<int> FindMissingElements(int[] first, int[] second) {
            List<int> missing = new List<int>();
            HashSet<int> secondHash = new HashSet<int>();

            foreach (var item in second) { //since location and order doesn't matter we use foreach loop
                secondHash.Add(item);
            }

            foreach (var item in first) {
                if (!secondHash.Contains(item)) {
                    missing.Add(item);
                }
            }

            return missing;
        }
    }
}
