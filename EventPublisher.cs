using System;

namespace CSharpConcepts
{
    //publisher class responsible for raising the event
    public class EventPublisher
    {
        //define event using eventhandler delegate
        public event EventHandler<MyEventArgs> MyEvent;

        //method to raise the event
        public void RaiseEvent(string message)
        {
            Console.WriteLine($"Event raise: {message}");
            //check if there are subscribers (event handlers)
            if(MyEvent != null)
            {
                //invoke the event, passing sender and event arguments
                MyEvent(this, new MyEventArgs(message));
            }
        }
    }
}
