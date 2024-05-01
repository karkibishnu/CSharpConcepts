using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpConcepts
{
    public class SortedListAndDictionary
    {
        //creating sorted list
        public void SortedListOperation()
        {            
            SortedList sortedList = new SortedList
            {

                //adding key/value pairs into list using Add() method
                { 1.02, "Dog" },
                { 1.07, "Cat" },
                { 1.04, "Rat" },
                { 1.01, "Bird" }
            };

            Console.WriteLine("Sorted List:");
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine("{0} and {1}", item.Key, item.Value);
            }
            Console.WriteLine();
        }

        //creating sorted dictionary
        public void SortedDictionaryOperation()
        {
            SortedDictionary<int, string> sortedDict = new SortedDictionary<int, string>();

            //adding key/value pair in SortedDictionary using Add() method
            sortedDict.Add(004, "Kathmandu");
            sortedDict.Add(002, "New Delhi");
            sortedDict.Add(001, "New York");
            sortedDict.Add(003, "London");

            Console.WriteLine("Sorted Dicationary:");
            foreach (KeyValuePair<int, string> item in sortedDict)
            {
                Console.WriteLine("{0} and {1}", item.Key, item.Value);
            }
            Console.WriteLine();
        }
    }
}
