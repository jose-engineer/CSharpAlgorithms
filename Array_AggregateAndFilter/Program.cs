﻿using System;
using System.Collections;
using System.Linq;

namespace Array_AggregateAndFilter {
    class Program {
        static void Main(string[] args) {
            int[] arr1 = { -8, 2, 3, -9, 11, -20 };
            int[] arr2 = { 0, -2, -9, -39, 39, 10, 7 };

            int[] evenArray = FindEvenNums(arr1, arr2);

            Array.ForEach(evenArray, Console.WriteLine);
        }

        public static int[] FindEvenNums(int[] arr1, int[] arr2) {
            ArrayList result = new ArrayList();

            foreach (var item in arr1) {
                if (item % 2 == 0) {
                    result.Add(item);
                }
            }

            foreach (var item in arr2) {
                if (item % 2 == 0) {
                    result.Add(item);
                }
            }

            return (int[])result.ToArray(typeof(int));
        }

        //public static int[] FindEvenNums2(int[] arr1, int[] arr2) {            
        //    int[] result1 = Array.FindAll(arr1, x => x % 2 == 0);
        //    int[] result2 = Array.FindAll(arr2, x => x % 2 == 0);            

        //    return result1.Concat(result2).ToArray();
        //}
    }
}
