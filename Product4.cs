using System;
using System.Collections.Generic;

class Product
{
    public string Name { get; set; }
    public int Price { get; set; }
}

class Product4
{
    static void Main(string[] args)
    {
        // Create a dictionary of type Dictionary<int, List<List<List<Product>>>>
        Dictionary<int, List<List<List<Product>>>> myDictionary = new Dictionary<int, List<List<List<Product>>>>();

        // Add some key-value pairs to the dictionary
        myDictionary.Add(1, new List<List<List<Product>>> {
            new List<List<Product>> {
                new List<Product> { new Product { Name = "Apple", Price = 1 }, new Product { Name = "Banana", Price = 2 } },
                new List<Product> { new Product { Name = "Orange", Price = 3 }, new Product { Name = "Grape", Price = 4 } }
            },
            new List<List<Product>> {
                new List<Product> { new Product { Name = "Carrot", Price = 2 }, new Product { Name = "Broccoli", Price = 3 } },
                new List<Product> { new Product { Name = "Spinach", Price = 1 }, new Product { Name = "Kale", Price = 2 } }
            }
        });

        myDictionary.Add(2, new List<List<List<Product>>> {
            new List<List<Product>> {
                new List<Product> { new Product { Name = "Milk", Price = 5 }, new Product { Name = "Cheese", Price = 6 } }
            },
            new List<List<Product>> {
                new List<Product> { new Product { Name = "Bread", Price = 2 }, new Product { Name = "Butter", Price = 3 } },
                new List<Product> { new Product { Name = "Jam", Price = 4 } }
            }
        });

        myDictionary.Add(3, new List<List<List<Product>>> {
            new List<List<Product>> {
                new List<Product> { new Product { Name = "Pencil", Price = 1 }, new Product { Name = "Pen", Price = 2 } },
                new List<Product> { new Product { Name = "Eraser", Price = 1 }, new Product { Name = "Ruler", Price = 2 } }
            },
            new List<List<Product>> {
                new List<Product> { new Product { Name = "Notebook", Price = 3 }, new Product { Name = "Folder", Price = 4 } }
            }
        });

        // Access the values in the dictionary
        List<List<List<Product>>> valuesForKey1 = myDictionary[1];
        Console.WriteLine("Values for key 1:");
        foreach (List<List<Product>> innerList1 in valuesForKey1)
        {
            Console.WriteLine("Inner list 1:");
            foreach (List<Product> innerList2 in innerList1)
            {
                Console.WriteLine("Inner list 2:");
                foreach (Product product in innerList2)
                {
                    Console.WriteLine("Name: {0}, Price: {1}", product.Name, product.Price);
                }
            }
        }

        List<List<List<Product>>> valuesForKey2 = myDictionary[2];
        Console.WriteLine("Values for key 2:");
        foreach (List<List<Product>> innerList1 in valuesForKey2)
        {
            Console.WriteLine("Inner list 1:");
            foreach (List<Product> innerList2 in innerList1)
            {
                Console.WriteLine("Inner list 2:");
                foreach (Product product in innerList2)
                {
                    Console.WriteLine("Name: {0}, Price: {1}", product.Name, product.Price);
                }
            }
        }
    }
}
