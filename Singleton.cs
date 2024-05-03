using System;
/// <summary>
/// first Singleton version
/// </summary>
namespace CSharpConcepts
{
    /*
     * Sealed restricts the inheritance
     */
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        private static readonly object obj = new object();

        /*
         * private constructor ensures that object is not
         * instantiated other than within the class itself
        */
        private Singleton()
        {
            counter++;
            Console.WriteLine($"Counter Value: {counter}");
        }
       
        /*
         * public property is used to return only one instance of the class
         * leveraging on the private property
         * primary reponsibility of GetInstance method is to return Singleton instance
        */
        public static Singleton GetInstance
        {
            get 
            { 
                //double check locking
                if(instance == null)
                {
                    //thread safety singleton
                    lock (obj)
                    {
                        //no thread safe singleton
                        if (instance == null)
                            instance = new Singleton();
                    }
                }                
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
