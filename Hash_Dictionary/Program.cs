using System;
using System.Collections.Generic;

namespace Hash_Dictionary {
    //Display the count of each element in an unsorted array
    //<key = element, value=count of element>{ 5, 7, 3, 0, 2 }
    class Program {
        static void Main(string[] args) {
            int[] A = { 3, 0, 2, 4, 7, 3, 4, 5, 7, 6, 7 };
            DisplayFreqOfEachElement(A);
        }

        public static void DisplayFreqOfEachElement(int[] arr) {
            Dictionary<int, int> hMap = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++) {
                if (hMap.ContainsKey(arr[i])) {
                    hMap[arr[i]]++; //hash[arr[i]] += 1;                    
                } else {
                    hMap[arr[i]] = 1;
                }
            }

            foreach (var item in hMap) {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }

        public static void DisplayFreqOfEachElement2(int[] arr) {
            Dictionary<int, int> hMap = new Dictionary<int, int>();

            foreach (var item in arr) {
                hMap[item] = 0;
            }

            foreach (var item in arr) {

                int count;
                if (hMap.TryGetValue(item, out count)) {
                    count++;
                    hMap[item] = count;
                }
            }

            foreach (var item in hMap) {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
        }
    }
}
