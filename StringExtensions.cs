using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    //static class containing extension methods
    public static class StringExtensions
    {
        //extension method to count the number of words in a string
        public static int WordCount(this string str)
        {
            //split the string into words using whitespace, periods and question marks
            string[] words = str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries);

            //return number of words
            return words.Length;
        }

        //extension method to reverse the characters in a string
        public static string Reverse(this string str)
        {
            //convert string to char array
            char[] charArray = str.ToCharArray();

            //reverse the charArray
            Array.Reverse(charArray);

            //create a new string from reversed array
            return new string(charArray);
        }
    }
}
