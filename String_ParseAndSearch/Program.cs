using System;

namespace String_ParseAndSearch {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(IsAtEvenIndex("HeLLo", 'L'));
            Console.WriteLine(IsAtEvenIndex("HeLLo", 'T'));
            Console.WriteLine(IsAtEvenIndex("HeLLo", 'H'));
            Console.WriteLine(IsAtEvenIndex(null, 'H'));
            Console.WriteLine(IsAtEvenIndex("", 'H'));

            Console.WriteLine();
            Console.WriteLine("Hello World".Contains("ll"));
        }
        
        public static bool IsAtEvenIndex(string str, char item) {
            if (string.IsNullOrEmpty(str)) {
                return false;
            }
            //With this for implementation we cut in half the search because we only search for even numbers from the begining
            for (int i = 0; i < (str.Length / 2) + 1; i=i+2) {

                if (str[i] == item) {
                    return true;
                }

            }
            return false;
        }

        //public static bool IsAtEvenIndex(string str, char item) {

        //    for (int i = 0; i < str.Length; i++) {

        //        if (str[i] == item && i % 2 == 0) {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
    }
}
