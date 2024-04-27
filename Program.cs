﻿using System;
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

            Console.ReadLine();
        }
    }
}
