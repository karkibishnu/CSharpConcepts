using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    //subscriber class that handles the event
    public class EventSubscriber
    {
        //method that serves as the event handler
        public void HandleEvent(object sender, MyEventArgs e)
        {
            Console.WriteLine($"Event handled by subscriber: {e.Message}");
        }
    }
}
