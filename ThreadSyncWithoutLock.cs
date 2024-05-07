using System;
using System.Threading;

namespace CSharpConcepts
{
    public static class ThreadSyncWithoutLock
    {
        static int sharedValue = 0;
        public static void SynchronizationWithoutLock()
        {
            Thread t1 = new Thread(IncrementWithoutLock);
            Thread t2 = new Thread(IncrementWithoutLock);

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Console.WriteLine($"Final shared value (without lock): {sharedValue}");
        }

        static void IncrementWithoutLock()
        {
            for(int i=0;i<100000;i++)
            {
                //critical section: accessing and modifying the shared variables
                sharedValue++;
            }
        }
    }
}
