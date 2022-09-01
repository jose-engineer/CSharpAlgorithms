using System;
using System.Collections.Generic;
using System.Linq;

namespace Intro_FindMaximum {
    class Program {
        //How to describe time complexity of an algorithm (Big O notation):
        //Algorithm 1 - Assumptions: The item we are searching for will be always the first or the last element in the list no mater the input size
        //Best case: Constant time O(1)
        //Worst case: Constant time O(1)
        //Algorithm 2 - Assumptions: The item we are searching for could be anywhere within the list
        //Best case: Constant time O(1)
        //Worst case: Linear time O(n) - means as the input size increases, the seach time increases. Where n is the input size.
        //
        //O(1) - Constant time - most efficient
        //O(log(n)) - Logarithmic time
        //O(n) - Linear time
        //O(n2) - Exponential time (nested loops)
        //O(n!) - Factorial time
        //
        //Space complexity: Does the algorithm use constant space or as much space as the size of the input?
        static void Main(string[] args) {
            Console.WriteLine(FindMaximum2(1, 2, 3));
            Console.WriteLine(FindMaximum2(8, 8, 1));
            Console.WriteLine(FindMaximum2(3, 2, 3));
            Console.WriteLine(FindMaximum2(1, 1, 9));
            Console.WriteLine(FindMaximum2(1, 9, 9));
        }

        public static int FindMaximum(int a, int b, int c) {
            if(a > b) {
                if (a > c || a == c) {
                    return a;
                }                
            }

            if (b > c) {
                if (b > a || b == a) {
                    return b;
                }                
            }

            return c;            
        }

        public static int FindMaximum2(int a, int b, int c) {
            int max = a;

            if (b > max) {
                max = b;
            }

            if (c > max) {
                max = c;
            }

            return max;
        }
    }
}
