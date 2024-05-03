using System;
namespace CSharpConcepts
{
    /*
     * Sealed restricts the inheritance
     */
    public sealed class SingletonLazy
    {
        private static int counter = 0;

        private static readonly Lazy<SingletonLazy> instance =
            //lamda expression as delegate
            new Lazy<SingletonLazy>(() => new SingletonLazy()); 

        /*
         * private constructor ensures that object is not
         * instantiated other than within the class itself
        */
        private SingletonLazy()
        {
            counter++;
            Console.WriteLine($"Lazy Counter Value: {counter}");
        }

        /*
         * public property is used to return only one instance of the class
         * leveraging on the private property
         * primary reponsibility of GetInstance method is to return Singleton instance
        */
        public static SingletonLazy GetInstance
        {
            get
            {
                //by default, lazy objects are thread safe
                //in multithread scenarios, the first thread which tries
                //to access Value property will take care of thready safety
                //when multiple threads are trying to get instance at the same point
                return instance.Value;
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
