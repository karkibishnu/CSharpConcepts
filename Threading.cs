using System;
using System.Threading;

namespace CSharpConcepts
{
    public static  class Threading
    {
        public static void MainThread()
        {
            //create a new thread and specificy the method to execute
            Thread t = new Thread(WorkerThread);

            //start the thread
            t.Start();

            //do some other work in main thread
            //main thread continues execution while new thread runs concurrently
            for(int i=0;i<=5;i++)
            {
                Console.WriteLine("Main thread doing some work");
                Console.WriteLine($"Main thread ID: {Thread.CurrentThread.ManagedThreadId}, Number: {i}");
                Console.WriteLine();
                Thread.Sleep(1000);
            }

            //wait for thread to finish
            t.Join();

            Console.WriteLine("Thread execution completed");

        }

        //method that will be executed by the thread
        static void WorkerThread()
        {
            for(int i=0;i<=5;i++)
            {
                Console.WriteLine("Worker thread doing some work");
                Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}, Number: {i}");
                Console.WriteLine();
                Thread.Sleep(1000);
            }
        }
    }
}
