using System;
using System.Collections.Generic;


    class D2
    {
        static void Main(string[] args)
        {
            // Create a dictionary of type Dictionary<int, List<Object>>
            Dictionary<int, List<Object>> myDictionary = new Dictionary<int, List<Object>>();

            // Add some key-value pairs to the dictionary
            myDictionary.Add(1, new List<Object> { "Mumbai", 123, true });
            myDictionary.Add(2, new List<Object> { "Pune", 456, false });
            myDictionary.Add(3, new List<Object> { "Delhi", 789, true });

            // Access the values in the dictionary
            List<Object> valuesForKey1 = myDictionary[1];
            Console.WriteLine("Values for key 1:");
            foreach (Object value in valuesForKey1)
            {
                Console.WriteLine(value);
            }

            List<Object> valuesForKey2 = myDictionary[2];
            Console.WriteLine("Values for key 2:");
            foreach (Object value in valuesForKey2)
            {
                Console.WriteLine(value);
            }

            List<Object> valuesForKey3 = myDictionary[3];
            Console.WriteLine("Values for key 3:");
            foreach (Object value in valuesForKey3)
            {
                Console.WriteLine(value);
            }




        // find key
        string searchObject = "Pune";
        int key = -1;

        foreach (KeyValuePair<int, List<Object>> kvp in myDictionary)
        {
            List<Object> values = kvp.Value;
            if (values.Contains(searchObject))
            {
                key = kvp.Key;
                break;
            }
        }

        if (key != -1)
        {
            Console.WriteLine("Key for object {0} is {1}", searchObject, key);
        }
        else
        {
            Console.WriteLine("Object {0} not found in dictionary", searchObject);
        }

    }
}
