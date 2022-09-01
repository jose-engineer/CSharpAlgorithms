using System;
using System.Collections.Generic;

namespace LinkedList_Operations {
    class Program {
        static void Main(string[] args) {
            LinkedList<string> listy = new LinkedList<string>();

            listy.AddLast("Sarah");
            listy.AddLast("Polly");
            listy.AddLast("Rebecca");
            listy.AddLast("Jess");
            listy.AddLast("Jackie");

            foreach (var item in listy) {
                Console.Write(item + "->");
            }

            Console.WriteLine();

            Console.WriteLine(listy.Contains("Polly"));
            Console.WriteLine(listy.Count);

            listy.RemoveFirst();
            //listy.RemoveLast();
            foreach (var item in listy) {
                Console.Write(item + "->");
            }
        }
    }
}
