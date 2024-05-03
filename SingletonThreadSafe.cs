using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    //Thread safe Singleton class using double check locking
    //sealed to avoid inheritance
    public sealed class SingletonThreadSafe
    {
        //private static volatile variable to hold the single instance of the class
        //volatile keyword ensures that the instance is read from and written to the main 
        //memory, preventing thread caching
        private static volatile SingletonThreadSafe instance = null; //the single instance of the class

        //object for locking
        private static readonly object lockObject = new object();

        //public static property to access single instance of the class
        public static SingletonThreadSafe GetInstance
        {
            get
            {
                //double-check locking to ensure thread safety
                //double-check ensures that only lock is acquired only when 
                //the instance is null, improving performance by avoiding
                //unnecessary locking once instance is initialized
                if(instance == null)
                {
                    //lock statement ensures that only one thread can enter
                    //critical section at a time making Singleton creation thread-safe
                    lock(lockObject)
                    {
                        if(instance == null)
                            instance = new SingletonThreadSafe();
                    }
                }
                return instance;
            }
        }

        //private constructor to prevent instantiation from outside the class
        private SingletonThreadSafe()
        {
            Console.WriteLine("Thread safe singleton instance created");
        }

        //public method to print details
        public void PrintDetails(string message)
        {
            Console.WriteLine("Thread safe: " + message);
        }
    }
}
