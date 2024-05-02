using System;

namespace CSharpConcepts
{
    public delegate void CustomCallback(string s);
    public class MulticastDelegate
    {
        public static void Hello(string s)
        {
            Console.WriteLine($"Hello, {s}");
        }

        public static void Goodbye(string s)
        {
            Console.WriteLine($" Goodbye, {s}");
        }
    }
}
