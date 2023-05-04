using System;
using System.Collections.Generic;

namespace Dict
{
    class Emp
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public bool IsManager { get; set; }
    }

    class Employee3
    {
        static void Main()
        {
            // Create a dictionary of type Dictionary<int, List<List<Emp>>>
            Dictionary<int, List<List<Emp>>> myDictionary = new Dictionary<int, List<List<Emp>>>();

            // Add some key-value pairs to the dictionary
            myDictionary.Add(1, new List<List<Emp>> {
            new List<Emp> { new Emp { Name = "John", Id = 123, IsManager = true }, new Emp { Name = "Mary", Id = 456, IsManager = false } },
            new List<Emp> { new Emp { Name = "Bob", Id = 789, IsManager = false }, new Emp { Name = "Alice", Id = 234, IsManager = true } }
        });

            myDictionary.Add(2, new List<List<Emp>> {
            new List<Emp> { new Emp { Name = "Tom", Id = 567, IsManager = false } },
            new List<Emp> { new Emp { Name = "Jane", Id = 890, IsManager = true }, new Emp { Name = "Mike", Id = 901, IsManager = false } }
        });

            myDictionary.Add(3, new List<List<Emp>> {
            new List<Emp> { new Emp { Name = "Susan", Id = 1234, IsManager = false }, new Emp { Name = "David", Id = 5678, IsManager = true } },
            new List<Emp> { new Emp { Name = "Karen", Id = 9012, IsManager = false } }
        });

            // Access the values in the dictionary
            List<List<Emp>> valuesForKey1 = myDictionary[1];
            Console.WriteLine("Values for key 1:");
            foreach (List<Emp> innerList in valuesForKey1)
            {
                Console.WriteLine("Inner list:");
                foreach (Emp employee in innerList)
                {
                    Console.WriteLine("Name: {0}, ID: {1}, IsManager: {2}", employee.Name, employee.Id, employee.IsManager);
                }
            }

            List<List<Emp>> valuesForKey2 = myDictionary[2];
            Console.WriteLine("Values for key 2:");
            foreach (List<Emp> innerList in valuesForKey2)
            {
                Console.WriteLine("Inner list:");
                foreach (Emp employee in innerList)
                {
                    Console.WriteLine("Name: {0}, ID: {1}, IsManager: {2}", employee.Name, employee.Id, employee.IsManager);
                }
            }

            List<List<Emp>> valuesForKey3 = myDictionary[3];
            Console.WriteLine("Values for key 3:");
            foreach (List<Emp> innerList in valuesForKey3)
            {
                Console.WriteLine("Inner list:");
                foreach (Emp employee in innerList)
                {
                    Console.WriteLine("Name: {0}, ID: {1}, IsManager: {2}", employee.Name, employee.Id, employee.IsManager);
                }
            }
        }
    }

}