using System;

namespace String_Normalize {
    //str = str.Substring (10); // 10 = starting index of a substring, remove the first 10 characters (get all characters from index 10)
    //str = str.Substring (5, 10); // 5 = starting index of a substring, 10 = number of characters in the substring, to get the last 10 characters from index 5
    //str = str.Remove (1); // 1 = index to begin deleting characters, remove all characters from index 1
    //str = str.Remove (0, 10); //0 = starindex, 10 = number of characters to delete, remove the first 10 characters, 
    //str = str.Replace ("text", ""); // to replace the specific text with blank
    //
    //str.TrimStart(); str.TrimEnd();
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(NormalizeString(" Hello There, BUDDY    ")); //Expected: hello there buddy
        }

        public static string NormalizeString(string input) {
            //input.Substring(5, 10);
            return input.ToLower().Trim().Replace(",", "");
        }
    }
}
