using System;
using System.Linq;

namespace String_Validate {
    //str.StartsWith("h");
    class Program {
        static void Main(string[] args) {
            //Console.WriteLine(IsUppercase("HELLO"));
            Console.WriteLine(IsPasswordComplex("Hell0"));
            Console.WriteLine(IsPasswordComplex("Hello"));
            Console.WriteLine(IsPasswordComplex("he11o"));
        }

        public static bool IsPasswordComplex(string str) {
            return str.Any(char.IsDigit) && str.Any(char.IsLower) && str.Any(char.IsUpper);
        }

        public static bool IsUppercase(string str) {
            return str.All(char.IsUpper);
            //return str.All(x => x.ToString() == x.ToString().ToUpper());
        }

        public static bool IsLetter(string str) {
            return str.All(char.IsLetter);            
        }        
    }
}
