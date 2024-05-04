using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    /*by marking the class as `sealed`, we prevent inheritance from the class
     *which further strengthens the Singleton pattern by ensuring no subclass
     *can be created.
    */
    public sealed class PrinterSpoolerSingleton
    {
        //singleton instance
        private static PrinterSpoolerSingleton instance;

        //queue to store print jobs
        private Queue<string> printQueue;

        //private constructor to prevent instantiation
        private PrinterSpoolerSingleton()
        {
            printQueue = new Queue<string>();
        }

        //method to get singleton instance
        public static PrinterSpoolerSingleton GetInstance()
        {
            if(instance == null)
                instance = new PrinterSpoolerSingleton();
            return instance;
        }

        //method to add print job to the queue
        public void AddJob(string document)
        {
            printQueue.Enqueue(document);
            Console.WriteLine($"Added document to print queue: {document}");
        }

        //method to process print jobs
        public void ProcessJobs()
        {
            while(printQueue.Count > 0)
            {
                string document = printQueue.Dequeue();
                Console.WriteLine($"Printing document: {document}");
            }
            Console.WriteLine($"All print jobs processed");
        }
    }
}
