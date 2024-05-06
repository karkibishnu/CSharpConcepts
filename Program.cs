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
            //#region enum 
            ////using daysofweekENUM class
            //DaysOfWeekENUM daysOfWeekENUM = new DaysOfWeekENUM();

            ////assigning todays day
            //DaysOfWeekENUM.DaysOfWeek today = DaysOfWeekENUM.DaysOfWeek.Friday;

            ////printing today's day
            //Console.WriteLine("Today is: " + today);

            ////using the greetaccordinttoday method
            //daysOfWeekENUM.GreetAccordingToDay(today);

            //#endregion enum

            //#region ref and out

            ////create instance of RefAndOutExample class
            //RefAndOutExample refAndOut = new RefAndOutExample();

            ////using ref to increment a variable
            //int num = 10;
            //refAndOut.IncrementUsingRef(ref num); //increment num by 1
            //Console.WriteLine($"Incremented value using ref: {num}");

            ////using out param to calculate quotient and remainder
            //int result;
            //int remainder;
            //refAndOut.Divide(10, 3, out result, out remainder);
            //Console.WriteLine($"Quotient: {result} , Remainder: {remainder}");

            //#endregion ref and out

            //#region Multiple value using ref, out, tuples, class

            //MultiReturn multiReturn = new MultiReturn();

            ////using tuples
            //var (intTuple, stringTuple, boolTuple) = multiReturn.GetValuesAsTuples();
            //Console.WriteLine($"Values from tuple: Int={intTuple}, String={stringTuple}, Bool={boolTuple}");

            ////using out params
            //multiReturn.GetValuesAsOut(out int intOut, out string stringOut, out bool boolOut);
            //Console.WriteLine($"Values using out: Int={intOut}, String={stringOut}, Bool={boolOut}");

            ////using class instance
            //var classValues = multiReturn.GetValuesAsClass();
            //Console.WriteLine($"Values using class: Int={classValues.IntValue}, String={classValues.StringValue}, Bool={classValues.BoolValue}");

            ////using ref params
            //int refInt = 40;
            //string refString = "Hello";
            //bool refBool = true;
            //multiReturn.GetValuesUsingRef(ref refInt, ref refString, ref refBool);
            //Console.WriteLine($"Values using ref: Int={refInt}, String={refString}, Bool={refBool}");

            //#endregion Multiple value return

            //#region const vs readonly and reflection

            ////creating instance of readonly
            //ReadOnlyExample readOnlyExample = new ReadOnlyExample(10);
            ////displaying initial value of readonly field
            //Console.WriteLine($"Initial value of readonly field: {readOnlyExample.ReadOnlyField}");

            ////attempting to change the value of readonly field using reflection
            //readOnlyExample.ChangeReadOnlyUsingReflection(20);
            ////displaying modified field of readonly field
            //Console.WriteLine($"Modified value of readonly field: {readOnlyExample.ReadOnlyField}");

            ////const field requires value to be provided
            ////so uncommenting below line with result in compile time error
            ////const int MaxValue;
            ////MaxValue = 20;

            //const int MaxValue = 12;
            //Console.WriteLine($"Const MaxValue: {MaxValue}");

            //#endregion const vs readonly and reflection

            //#region readonly vs static readonly

            ////creating instance of ReadOnlyVsStaticReadOnly class
            //ReadOnlyVsStaticReadOnly readOnlyVsStaticReadOnly = new ReadOnlyVsStaticReadOnly(5);

            ////accessign readonly and static readonly fields
            //Console.WriteLine($"ReadOnly Field: {readOnlyVsStaticReadOnly.ReadOnlyField}");
            //Console.WriteLine($"Static ReadOnly Field: {ReadOnlyVsStaticReadOnly.StaticReadOnlyField}");

            ////attempting to change value of ReadOnlyField (will result in a compile-time error)
            ////readOnlyVsStaticReadOnly.ReadOnlyField = 10;  //uncommenting this line will result in compile time error

            ////attempting to change the value of StaticReadOnlyField (will result in a compile-time error)
            ////ReadOnlyVsStaticReadOnly.StaticReadOnlyField = 100; //uncommenting this line will result in compile time error

            //#endregion readonly vs static readonly

            //#region JaggedArray

            //JaggedArrayExample jaggedArray = new JaggedArrayExample();
            //jaggedArray.PrintWeeklySchedule();

            //#endregion JaggedArray

            //#region String vs StringBuilder class

            //string s1 = "hello ";

            ////calling Concat1 method with string s1
            //StringBuilderVsString.Concat1(s1);

            ////calling concat2 method with StringBuilder s2
            //StringBuilder s2 = new StringBuilder("hello");
            //StringBuilderVsString.Concat2(s2);

            //#endregion String vs StringBuilder class

            //#region Extension Methods
            //Console.WriteLine("");
            ////example sentence
            //string sentence = "Hello bishnu! this is an extension method example";

            ////using word counter extension method
            //int wordCount = sentence.WordCount();
            //Console.WriteLine($"Word Count: {wordCount}");

            ////using the reverse extension method
            //string reversedSentence = sentence.Reverse();
            //Console.WriteLine($"Reversed Sentence: {reversedSentence}");

            //#endregion Extension Methods

            //#region SortedList and SortedDictionary

            //SortedListAndDictionary sortedListAndDictionary = new SortedListAndDictionary();
            //sortedListAndDictionary.SortedListOperation();
            //sortedListAndDictionary.SortedDictionaryOperation();

            //#endregion SortedList and SortedDictionary

            //#region hashtable

            //HashtableExample.HashtableOperation();

            //#endregion hashtable

            //#region Delegate

            //CalculatorDelegate calculator = new CalculatorDelegate();

            ////perform addition with custom callback
            //int result1 = calculator.PerformOperation(5, 3, CustomAddition);
            //Console.WriteLine($"Custom Addition Result: {result1}");

            ////perform multiplication with custom callback
            //int result2 = calculator.PerformOperation(4, 2, CustomMultiplication);
            //Console.WriteLine($"Custom Multiplication Result: {result2}");

            ////multicast delegate
            //CustomCallback hiDel, byeDel, addDel, minusDel;

            //hiDel = MulticastDelegate.Hello;
            //byeDel = MulticastDelegate.Goodbye;

            //addDel = hiDel + byeDel;

            //minusDel = addDel - hiDel;
            //Console.WriteLine("Invoking delegate hiDel:");
            //hiDel("A");
            //Console.WriteLine("Invoking delegate byDel:");
            //byeDel("B");
            //Console.WriteLine("Invoking delegate addDel:");
            //addDel("C");
            //Console.WriteLine("Invoking delegate minusDel:");
            //minusDel("D");

            //#endregion Delegate

            //#region Generic

            ////creating instance of generic class with different data types
            //MyGenericClass<int> intInstance = new MyGenericClass<int>(10);
            //MyGenericClass<string> stringInstance = new MyGenericClass<string>("Hello World");

            ////calling methods of generic class instance
            //intInstance.DisplayValue();
            //stringInstance.DisplayValue();

            ////getting type information of generic instances
            //intInstance.GetGenericTypeInformation(intInstance);
            //stringInstance.GetGenericTypeInformation(stringInstance);

            //CalculatorGeneric calGeneric = new CalculatorGeneric();

            //int intResult = calGeneric.Add(5, 10);
            //Console.WriteLine($"Integer result: {intResult}");
            //float floatResult = calGeneric.Add(3.5f, 2.1f);
            //Console.WriteLine($"Float result: {floatResult}");
            //#endregion Generic

            //#region Event and event handler

            ////create instance of the publisher
            //EventPublisher publisher = new EventPublisher();
            ////create instance of the subscriber
            //EventSubscriber subscriber = new EventSubscriber();

            ////subscribe to the event by adding an event handler method

            ////publisher.MyEvent: this part accesses the `MyEvent` event of 
            ////the `publisher` object. `MyEvent` is an event defined in the 
            ////`EventPublisher` class

            ////+= is the event subscription operator. It is used to add an 
            ////event handler to the event. When you use +=, you are subscribing
            ////to the event which means you are adding a method that should 
            ////execute when event occurs

            ////`subscriber.HandleEvent` referes to HandleEvent method of the 
            ////subscriber object. HandleEvent is a method defined in the 
            ////EventSubscriber class. This method will execute when MyEvent is raised
            //publisher.MyEvent += subscriber.HandleEvent;

            ////raise the event
            //publisher.RaiseEvent("Hello Bishnu!!");

            //#endregion Event and event handler

            //#region Singleton

            //Parallel.Invoke(
            //    () => PrintStudentDetails(),
            //    () => PrintEmployeeDetails());

            //Parallel.Invoke(
            //    () => PrintStudentDetailsEager(),
            //    () => PrintEmployeeDetailsEager());

            //Parallel.Invoke(
            //    () => PrintStudentDetailsLazy(),
            //    () => PrintEmployeeDetailsLazy());

            //Parallel.Invoke(
            //    () => PrintStudentDetailsNoThreadSafe(),
            //    () => PrintEmployeeDetailsNoThreadSafe());

            //Parallel.Invoke(

            //    () => PrintStudentDetailsThreadSafe(),
            //    () => PrintEmployeeDetailsThreadSafe());

            //#endregion Singleton

            //#region static conversion

            //double celcius = 37;
            //double farenheit = 98.6;
            //Console.WriteLine("Value of {0} celcius to farenheit is {1}", 
            //    celcius, StaticConverter.ToFerenheit(celcius));

            //Console.WriteLine("Value of {0} farenheit to celcius is {1}",
            //    farenheit, StaticConverter.ToCelcius(farenheit));

            //#endregion static conversion

            //#region PrinterSpooler Singleton

            ////get singleton instance of the print spooler
            //PrinterSpoolerSingleton spooler = PrinterSpoolerSingleton.GetInstance();

            ////add some print jobs
            //spooler.AddJob("Document 1");
            //spooler.AddJob("Document 2");
            //spooler.AddJob("Document 3");

            ////process the print jobs
            //spooler.ProcessJobs();

            ////trying to create another instance will return the same instance
            //PrinterSpoolerSingleton spooler2 = PrinterSpoolerSingleton.GetInstance();
            //Console.WriteLine($"spooler == spooler2 {spooler == spooler2}");

            //#endregion PrinterSpooler Singleton

            #region Exceptions

            ExceptionHandler.HandleExceptions(() =>
            {
                //code that may throw exceptions
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine(numbers[4]); //trying to access an out of range index
            });

            try
            {
                Console.WriteLine("Exception using throw");
                ThrowVsThrowExException.DivideByZeroThrow(10, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception caught at top level: {ex.StackTrace}");
            }
            Console.WriteLine();


            try
            {
                Console.WriteLine("Exception using throw ex");
                ThrowVsThrowExException.DivideByZeroThrowEx(10, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception caught at top level: {ex.StackTrace}");
            }

            #endregion Exceptions

            Console.ReadLine();
        }

        private static void PrintEmployeeDetails()
        {
            /*
                * assuming Singleton is created from employee class
                * we refer to the GetInstance property from the Singleton class
            */
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Employee");
        }

        private static void PrintStudentDetails()
        {
            /*
                * assuming Singleton is created from the student class
                * we refer to the GetInstance property from the Singleton class
            */
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("From Student");
        }

        private static void PrintEmployeeDetailsEager()
        {
            /*
                * assuming Singleton is created from employee class
                * we refer to the GetInstance property from the Singleton class
            */
            SingletonEager fromStudent = SingletonEager.GetInstance;
            fromStudent.PrintDetails("From Employee");
        }

        private static void PrintStudentDetailsEager()
        {
            /*
                * assuming Singleton is created from the student class
                * we refer to the GetInstance property from the Singleton class
            */
            SingletonEager fromEmployee = SingletonEager.GetInstance;
            fromEmployee.PrintDetails("From Student");
        }

        private static void PrintEmployeeDetailsLazy()
        {
            /*
                * assuming Singleton is created from employee class
                * we refer to the GetInstance property from the Singleton class
            */
            SingletonLazy fromStudent = SingletonLazy.GetInstance;
            fromStudent.PrintDetails("From Employee");
        }

        private static void PrintStudentDetailsLazy()
        {
            /*
                         * assuming Singleton is created from the student class
                         * we refer to the GetInstance property from the Singleton class
                        */
            SingletonLazy fromEmployee = SingletonLazy.GetInstance;
            fromEmployee.PrintDetails("From Student");
        }

        private static void PrintEmployeeDetailsNoThreadSafe()
        {
            /*
                * assuming Singleton is created from employee class
                * we refer to the GetInstance property from the Singleton class
            */
            SingletonNoThreadSafe fromStudent = SingletonNoThreadSafe.GetInstance;
            fromStudent.PrintDetails("From Employee");
        }

        private static void PrintStudentDetailsNoThreadSafe()
        {
            /*
                         * assuming Singleton is created from the student class
                         * we refer to the GetInstance property from the Singleton class
                        */
            SingletonNoThreadSafe fromEmployee = SingletonNoThreadSafe.GetInstance;
            fromEmployee.PrintDetails("From Student");
        }

        private static void PrintEmployeeDetailsThreadSafe()
        {
            /*
                * assuming Singleton is created from employee class
                * we refer to the GetInstance property from the Singleton class
            */
            SingletonThreadSafe fromStudent = SingletonThreadSafe.GetInstance;
            fromStudent.PrintDetails("From Employee");
        }

        private static void PrintStudentDetailsThreadSafe()
        {
            /*
                         * assuming Singleton is created from the student class
                         * we refer to the GetInstance property from the Singleton class
                        */
            SingletonThreadSafe fromEmployee = SingletonThreadSafe.GetInstance;
            fromEmployee.PrintDetails("From Student");
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
