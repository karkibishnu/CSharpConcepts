using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public static class HashtableExample
    {
        public static void HashtableOperation()
        {
            Hashtable ht = new Hashtable();

            //adding elements
            ht.Add("key1", "value1");
            ht["key2"] = "value2"; //adding element using indexer

            //accessing elements
            //contains method or using indexer
            if(ht.ContainsKey("key1"))
            {
                string value = (string)ht["key1"];
                Console.WriteLine("Accessing element: " + value);
            }

            //iterating elements
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }

            //removing element
            ht.Remove("key1");

            //counting elements
            Console.WriteLine("Number of elements: " + ht.Count);

            //checking if hashtable contains specific value
            if(ht.ContainsValue("value2"))
            {
                Console.WriteLine("Hashtable conatins value2");
            }
            //clearing hashtable
            ht.Clear();
        }
    }
}
