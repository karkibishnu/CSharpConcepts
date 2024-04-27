using System;

namespace CSharpConcepts
{
    public class JaggedArrayExample
    {
        public void PrintWeeklySchedule()
        {
            //initialize jagged array
            //jagged array representing schedule for each day of the week
            string[][] weeklySchedule = new string[7][]
            {
                new string[] { "Meeting with client", "Lunch with team" },             // Day 1: Monday
                new string[] { "Presentation", "Team brainstorming session", "Project review" },  // Day 2: Tuesday
                new string[] { "Training session", "Workshop" },                        // Day 3: Wednesday
                new string[] { "Conference call", "Networking event" },                 // Day 4: Thursday
                new string[] { "Product demo", "Team outing" },                         // Day 5: Friday
                new string[] { "Project planning", "Client dinner" },                   // Day 6: Saturday
                new string[] { "Day off" }, // Day 7: Sunday
            };

            //pring schedule for each day
            for(int i=0;i<weeklySchedule.Length;i++)
            {
                Console.WriteLine($"Schedule for Day {i+1}");
                foreach(string schedule in weeklySchedule[i])
                {
                    Console.WriteLine("- " + schedule);
                }

                Console.WriteLine("");
            }
        }
    }
}
