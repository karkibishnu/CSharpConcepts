using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace CSharpConcepts
{
    public static class StringBuilderVsString
    {
        //concat to String
        public static void Concat1(string s1)
        {
            //Initial memory reference of s1
            Console.WriteLine($"Memory reference of s1 {s1} before string concatenation: " +
                $"{ RuntimeHelpers.GetHashCode(s1)}");

            //taking a string which is to be concatenated
            string st = "bishnu";

            //using String.Concat method
            s1 = string.Concat(s1, st);

            //memory referenc of s1 after concatenation
            Console.WriteLine($"Memory reference of s1 {s1} after concatenation: " +
                $"{RuntimeHelpers.GetHashCode(s1)}");
        }

        //concat to StringBuilder
        public static void Concat2(StringBuilder s2)
        {
            //initial memory reference of s2
            Console.WriteLine($"Memory reference of s2 {s2} before concatenation: " +
                $"{RuntimeHelpers.GetHashCode(s2)}");

            //using append method of StringBuilder class
            s2.Append("bisnu");

            //memory reference of s2 after concatenation
            Console.WriteLine($"Memory reference of s2 {s2} after concatenation: " +
                $"{RuntimeHelpers.GetHashCode(s2)}");
        }
    }
}
