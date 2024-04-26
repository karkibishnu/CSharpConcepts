using System;

namespace CSharpConcepts
{
    public class DaysOfWeekENUM
    {
        public enum DaysOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
        }

        public void GreetAccordingToDay(DaysOfWeek today)
        {
            Console.WriteLine("Today is: " + today);

            switch (today)
            {
                case DaysOfWeek.Sunday:
                case DaysOfWeek.Saturday:
                    Console.WriteLine("Its weekend, time to relax");
                    break;
                case DaysOfWeek.Monday:
                    Console.WriteLine("Its monday, back to work");
                    break;
                default:
                    Console.WriteLine("Its weekday, get back to work");
                    break;
            }
        }
    }
}
