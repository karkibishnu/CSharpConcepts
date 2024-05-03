using System;
namespace CSharpConcepts
{
    //Singleton class (Thread unsafe)
    public sealed class SingletonNoThreadSafe
    {
        //private static variable to hold the single instance of the class
        private static SingletonNoThreadSafe instance = null; //single instance of the class

        public static SingletonNoThreadSafe GetInstance
        {
            get
            {
                //if instance is null, create new instance
                if (instance == null)
                    instance = new SingletonNoThreadSafe();
                
                //return instance
                return instance;
            }
        }

        //private constructor to prevent instantiation from outside the class
        private SingletonNoThreadSafe()
        {
            Console.WriteLine("Thread unsafe singleton instance created");
        }

        //public method to print details
        public void PrintDetails(string message)
        {
            Console.WriteLine("Thread unsafe: " + message);
        }
    }
}
