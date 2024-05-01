using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region enum 
            //using daysofweekENUM class
            DaysOfWeekENUM daysOfWeekENUM = new DaysOfWeekENUM();

            //assigning todays day
            DaysOfWeekENUM.DaysOfWeek today = DaysOfWeekENUM.DaysOfWeek.Friday;

            //printing today's day
            Console.WriteLine("Today is: " + today);

            //using the greetaccordinttoday method
            daysOfWeekENUM.GreetAccordingToDay(today);

            #endregion enum

            #region ref and out

            //create instance of RefAndOutExample class
            RefAndOutExample refAndOut = new RefAndOutExample();

            //using ref to increment a variable
            int num = 10;
            refAndOut.IncrementUsingRef(ref num); //increment num by 1
            Console.WriteLine($"Incremented value using ref: {num}" );

            //using out param to calculate quotient and remainder
            int result;
            int remainder;
            refAndOut.Divide(10, 3, out result, out remainder);
            Console.WriteLine($"Quotient: {result} , Remainder: {remainder}");

            #endregion ref and out

            #region Multiple value using ref, out, tuples, class

            MultiReturn multiReturn = new MultiReturn();

            //using tuples
            var (intTuple, stringTuple, boolTuple) = multiReturn.GetValuesAsTuples();
            Console.WriteLine($"Values from tuple: Int={intTuple}, String={stringTuple}, Bool={boolTuple}");

            //using out params
            multiReturn.GetValuesAsOut(out int intOut, out string stringOut, out bool boolOut);
            Console.WriteLine($"Values using out: Int={intOut}, String={stringOut}, Bool={boolOut}");

            //using class instance
            var classValues = multiReturn.GetValuesAsClass();
            Console.WriteLine($"Values using class: Int={classValues.IntValue}, String={classValues.StringValue}, Bool={classValues.BoolValue}");

            //using ref params
            int refInt = 40;
            string refString = "Hello";
            bool refBool = true;
            multiReturn.GetValuesUsingRef(ref refInt, ref refString, ref refBool);
            Console.WriteLine($"Values using ref: Int={refInt}, String={refString}, Bool={refBool}");

            #endregion Multiple value return

            #region const vs readonly and reflection

            //creating instance of readonly
            ReadOnlyExample readOnlyExample = new ReadOnlyExample(10);
            //displaying initial value of readonly field
            Console.WriteLine($"Initial value of readonly field: {readOnlyExample.ReadOnlyField}");

            //attempting to change the value of readonly field using reflection
            readOnlyExample.ChangeReadOnlyUsingReflection(20);
            //displaying modified field of readonly field
            Console.WriteLine($"Modified value of readonly field: {readOnlyExample.ReadOnlyField}");

            //const field requires value to be provided
            //so uncommenting below line with result in compile time error
            //const int MaxValue;
            //MaxValue = 20;

            const int MaxValue = 12;
            Console.WriteLine($"Const MaxValue: {MaxValue}");

            #endregion const vs readonly and reflection

            #region readonly vs static readonly

            //creating instance of ReadOnlyVsStaticReadOnly class
            ReadOnlyVsStaticReadOnly readOnlyVsStaticReadOnly = new ReadOnlyVsStaticReadOnly(5);

            //accessign readonly and static readonly fields
            Console.WriteLine($"ReadOnly Field: {readOnlyVsStaticReadOnly.ReadOnlyField}");
            Console.WriteLine($"Static ReadOnly Field: {ReadOnlyVsStaticReadOnly.StaticReadOnlyField}");

            //attempting to change value of ReadOnlyField (will result in a compile-time error)
            //readOnlyVsStaticReadOnly.ReadOnlyField = 10;  //uncommenting this line will result in compile time error

            //attempting to change the value of StaticReadOnlyField (will result in a compile-time error)
            //ReadOnlyVsStaticReadOnly.StaticReadOnlyField = 100; //uncommenting this line will result in compile time error

            #endregion readonly vs static readonly

            #region JaggedArray

            JaggedArrayExample jaggedArray = new JaggedArrayExample();
            jaggedArray.PrintWeeklySchedule();

            #endregion JaggedArray

            #region String vs StringBuilder class

            string s1 = "hello ";

            //calling Concat1 method with string s1
            StringBuilderVsString.Concat1(s1);

            //calling concat2 method with StringBuilder s2
            StringBuilder s2 = new StringBuilder("hello");
            StringBuilderVsString.Concat2(s2);

            #endregion String vs StringBuilder class

            #region Extension Methods
            Console.WriteLine("");
            //example sentence
            string sentence = "Hello bishnu! this is an extension method example";

            //using word counter extension method
            int wordCount = sentence.WordCount();
            Console.WriteLine($"Word Count: {wordCount}");

            //using the reverse extension method
            string reversedSentence = sentence.Reverse();
            Console.WriteLine($"Reversed Sentence: {reversedSentence}");

            #endregion Extension Methods

            #region SortedList and SortedDictionary

            SortedListAndDictionary sortedListAndDictionary = new SortedListAndDictionary();
            sortedListAndDictionary.SortedListOperation();
            sortedListAndDictionary.SortedDictionaryOperation();

            #endregion SortedList and SortedDictionary

            #region hashtable

            HashtableExample.HashtableOperation();

            #endregion hashtable

            #region Delegate

            CalculatorDelegate calculator = new CalculatorDelegate();

            //perform addition with custom callback
            int result1 = calculator.PerformOperation(5, 3, CustomAddition);
            Console.WriteLine($"Custom Addition Result: {result1}");

            //perform multiplication with custom callback
            int result2 = calculator.PerformOperation(4, 2, CustomMultiplication);
            Console.WriteLine($"Custom Multiplication Result: {result2}");

            #endregion Delegate

            #region Generic

            //creating instance of generic class with different data types
            MyGenericClass<int> intInstance = new MyGenericClass<int>(10);
            MyGenericClass<string> stringInstance = new MyGenericClass<string>("Hello World");

            //calling methods of generic class instance
            intInstance.DisplayValue();
            stringInstance.DisplayValue();

            //getting type information of generic instances
            intInstance.GetGenericTypeInformation(intInstance);
            stringInstance.GetGenericTypeInformation(stringInstance);

            #endregion Generic

            Console.ReadLine();
        }

        //callback method for custom addition
        static int CustomAddition(int x, int y)
        {
            //perform addition with custom logic
            return x + y + 10;
        }

        static int CustomMultiplication(int x, int y)
        {
            //perform multiplication with custom logic
            return x * y * 2;
        }
    }
}
