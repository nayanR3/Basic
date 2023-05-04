using System;
using System.Collections;
using System.Runtime.ConstrainedExecution;

class D1
{
    public static void Main()
    {
        // create a dictionary 
        Dictionary<int, string> country = new Dictionary<int, string>();

        // add items to dictionary
        country.Add(5, "Brazil");
        country.Add(3, "China");
        country.Add(4, "Usa");


        // iterate through the car dictionary 
        foreach (var items in country)
        {
            Console.WriteLine("{0} : {1}", items.Key, items.Value);
        }


        // print value having key is 3        
        Console.WriteLine("\nValue having key 3: " + country[3]);


        // find key by value
        int key = 0;
        foreach (var kvp in country)
        {
            if (kvp.Value == "China")
            {
                key = kvp.Key;
                break;
            }
        }
        Console.WriteLine("\nKey having value 'China': " + key);
    }
}