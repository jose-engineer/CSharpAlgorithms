using System;
using System.Collections.Generic;

namespace Hash_Operations {

    class Employee {
        int id;
        string name;
        string department;

        public Employee(int id, string name, string department) {
            this.id = id;
            this.name = name;
            this.department = department;
        }

        class Program {
            static void Main(string[] args) {
                Employee emp1 = new Employee(1, "Jose", "IT");
                Employee emp2 = new Employee(2, "Joseph", "YouTube");
                Employee emp3 = new Employee(3, "Sally", "Sales");

                //Dictionary is useful for key-value pairs, look-up items(values) in constant time by key
                Dictionary<int, Employee> hMap = new Dictionary<int, Employee>(); //Each key is unique                

                hMap.Add(emp1.id, emp1);
                hMap.Add(emp2.id, emp2);
                hMap.Add(emp3.id, emp3);

                Employee e;
                
                if (hMap.TryGetValue(2, out e)) {
                    Console.WriteLine(e.name + ": " + e.department);
                }

                //For working with data where each item is unique and order doesn't matter you can use HashSet
                //In general HasSet is good if you need to check if a given item is a member of a certain group
                HashSet<string> hSet = new HashSet<string>(); //Each value is unique

                hSet.Add("123ABC"); //productCode
                hSet.Add("2BCD");
                hSet.Add("3FGH");

                Console.WriteLine();
                Console.WriteLine(hSet.Contains("4321"));
                Console.WriteLine(hSet.Contains("2BCD"));
            }
        }
    }    
}
