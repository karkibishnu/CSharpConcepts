using System;
/// <summary>
/// first Singleton version
/// </summary>
namespace CSharpConcepts
{
    /*
     * Sealed restricts the inheritance
     */
    public sealed class SingletonEager
    {
        private static int counter = 0;
        private static readonly SingletonEager instance = 
            new SingletonEager();

        /*
         * private constructor ensures that object is not
         * instantiated other than within the class itself
        */
        private SingletonEager()
        {
            counter++;
            Console.WriteLine($"Eager Counter Value: {counter}");
        }

        /*
         * public property is used to return only one instance of the class
         * leveraging on the private property
         * primary reponsibility of GetInstance method is to return Singleton instance
        */
        public static SingletonEager GetInstance
        {
            get
            {
                //eager loading
                //CLR takes care of variable initialization and its thread safety
                //hence no explicit code is required for thread safety
                return instance;
            }
        }

        /*
         * public method which can be invoked through singleton instance
        */
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
