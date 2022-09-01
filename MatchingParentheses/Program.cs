using System;
using System.Collections.Generic;

namespace Stack_MatchingParentheses {
    class Program {
        //Determine whether a given piece of text has matching parentheses
        static void Main(string[] args) {
            Console.WriteLine(HasMatchingParentheses("((hello()))"));
            Console.WriteLine(HasMatchingParentheses("()(hello())"));
            Console.WriteLine(HasMatchingParentheses("((hello))"));
            Console.WriteLine(HasMatchingParentheses("(hello)"));

            Console.WriteLine();

            Console.WriteLine(HasMatchingParentheses("(hello("));
            Console.WriteLine(HasMatchingParentheses(")hello)"));
            Console.WriteLine(HasMatchingParentheses(")hello("));
            Console.WriteLine(HasMatchingParentheses("hello(("));
            Console.WriteLine(HasMatchingParentheses("(hello"));
            Console.WriteLine(HasMatchingParentheses("((hello)"));
            Console.WriteLine(HasMatchingParentheses("hello)(("));
        }

        public static bool HasMatchingParentheses(string s) {
            Stack<char> stack = new Stack<char>(); //FIFO

            for (int i = 0; i < s.Length; i++) {
                char current = s[i];

                if (current == '(') {
                    stack.Push(current);
                    continue;
                } 
                
                if (current == ')') {
                    if (stack.Count > 0) {
                        stack.Pop();
                    } else {
                        return false;
                    }                   
                }
            }

            return stack.Count == 0;
        }

        //Since we are only dealing with just one symbol type (parenthesis) we can keep track with just an integer
        public static bool HasMatchingParentheses2(string s) { 
            int tracker = 0;

            for (int i = 0; i < s.Length; i++) {
                char current = s[i];

                if (current == '(') {
                    tracker++;
                    continue;
                }

                if (current == ')') {
                    if (tracker > 0) {
                        tracker--;
                    } else {
                        return false;
                    }
                }
            }

            return tracker == 0;
        }
    }
}
