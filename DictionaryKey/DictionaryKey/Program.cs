using System;
using System.Collections.Generic;

namespace DictionaryKey
{
    class Program
    {
        static void Main(string[] args)

        {
            Dictionary<string, int> ages = new Dictionary<string, int>();

            //fill the Dictionary
            ages.Add("John", 47); //using the Add method
            ages.Add("Diana", 45);
            ages["James"] = 20;   //using array notation
            ages["Francesca"] = 18;

            ages["John"] = 88;

            //iterate using a foreeach statement
            //the iterator generates a KeyValuePair item
            Console.WriteLine("The Dictionary contains:");
            foreach (KeyValuePair<string, int> myelement in ages)
            {
                string name = myelement.Key;
                int age = myelement.Value;
                Console.WriteLine("Name: {0}, Age: {1}", name, age);
            }
         }
    }
}
