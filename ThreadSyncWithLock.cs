using System;
using System.Threading;

namespace CSharpConcepts
{
    public static class ThreadSyncWithLock
    {
        static int sharedValue = 0; //shared variable among threads
        static object lockObject = new object(); //object used for locking

        public static void SynchronizationWithLock()
        {
            //creating two objects
            Thread t1 = new Thread(IncrementWithLock);
            Thread t2 = new Thread(IncrementWithLock);

            //start thread
            t1.Start();
            t2.Start();

            //join thread to finish
            t1.Join();
            t2.Join();

            Console.WriteLine($"Final shared value (with lock): {sharedValue}");
        }

        static void IncrementWithLock()
        {
            for(int i=0;i<500;i++)
            {
                //critical section: accessing and modifying the shared variable
                lock(lockObject)
                {
                    sharedValue++;
                }
            }
        }
    }
}
