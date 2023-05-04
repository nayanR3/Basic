using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dict
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Employee(int id, string name, int age)
        {
            ID = id;
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Age: {Age}";
        }
    }

    class Employee2
    {
        static void Main(string[] args)
        {
            // Create a dictionary of type Dictionary<int, List<Employee>>
            Dictionary<int, List<Employee>> myDictionary = new Dictionary<int, List<Employee>>();

            // Create some employees
            Employee emp1 = new Employee(1, "John", 25);
            Employee emp2 = new Employee(2, "Mary", 30);
            Employee emp3 = new Employee(3, "Bob", 35);
            Employee emp4 = new Employee(4, "Jane", 40);

            // Add the employees to the dictionary
            myDictionary.Add(1, new List<Employee> { emp1, emp2 });
            myDictionary.Add(2, new List<Employee> { emp3 });
            myDictionary.Add(3, new List<Employee> { emp4, emp2 });

            // Access the values in the dictionary
            List<Employee> valuesForKey1 = myDictionary[1];
            Console.WriteLine("Values for key 1:");
            foreach (Employee value in valuesForKey1)
            {
                Console.WriteLine(value);
            }

            List<Employee> valuesForKey2 = myDictionary[2];
            Console.WriteLine("Values for key 2:");
            foreach (Employee value in valuesForKey2)
            {
                Console.WriteLine(value);
            }

            List<Employee> valuesForKey3 = myDictionary[3];
            Console.WriteLine("Values for key 3:");
            foreach (Employee value in valuesForKey3)
            {
                Console.WriteLine(value);
            }
        }

    }
}