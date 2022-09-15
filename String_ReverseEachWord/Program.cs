using System;
using System.Collections.Generic;
using System.Text;

namespace String_ReverseEachWord {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(ReverseEachWord("Taylor is a grat worker")); //rolyaT si a targ rekrow
            Console.WriteLine(ReverseEachWord(null));
            Console.WriteLine(ReverseEachWord("racer racecar madam")); //recar racecar madam
            Console.WriteLine(ReverseEachWord("what can I do today")); //tahw nac I od yadot
            Console.WriteLine(ReverseEachWord(" "));
        }

        public static string ReverseEachWord(string input) {
            if (string.IsNullOrEmpty(input)) {
                return input;
            }
            
            StringBuilder result = new StringBuilder();
            string[] arr = input.Split(' ');

            for (int i = 0; i < arr.Length; i++) {
                result.Append(Reverse(arr[i]));
                if (i != (arr.Length - 1)) { //Append space except if we are on the last word
                    result.Append(" ");
                }                
            }

            return result.ToString();
        }

        public static string Reverse(string input) {
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static string ReverseEachWord2(string input) {
            string[] arr = input.Split(' ');

            StringBuilder reversed = new StringBuilder();
            List<string> result = new List<string>();

            foreach (var item in arr) {
                for (int i = item.Length - 1; i >= 0; i--) {
                    reversed.Append(item[i]);
                }
                result.Add(reversed.ToString());
                reversed.Clear();
            }            

            return string.Join(' ', result);
        }

        public static string ReverseEachWord3(string input) {
            string[] arr = input.Split(' ');

            StringBuilder reversed = new StringBuilder();            
            string[] result = new string[input.Length];

            for (int i = 0; i < arr.Length; i++) {
                for (int j = arr[i].Length - 1; j >= 0; j--) {
                    reversed.Append(arr[i][j]);
                }
                result[i] = reversed.ToString();
                reversed.Clear();
            }
            
            return string.Join(' ', result);
        }
    }
}
