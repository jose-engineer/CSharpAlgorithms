using System;
using System.Collections.Generic;
using System.Text;

namespace String_AlgorithmDriven {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(Reverse2("Hello World"));
            Console.WriteLine(Reverse(""));
            Console.WriteLine(Reverse("hello"));
            Console.WriteLine(Reverse("tacos"));
            Console.WriteLine(Reverse("Hi!"));
            Console.WriteLine(Reverse(null));
        }

        public static string Reverse(string input) {
            if (string.IsNullOrEmpty(input)) {
                return input;
            }

            StringBuilder reversed = new StringBuilder(input.Length); //set capacity to the string length

            for (int i = input.Length-1; i >= 0; i--) {
                reversed.Append(input[i]);
            }                           

            return reversed.ToString();
        }

        public static string Reverse2(string input) {
            if (string.IsNullOrEmpty(input)) {
                return input;
            }
            
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);

            return new string(arr);
        }
    }
}
