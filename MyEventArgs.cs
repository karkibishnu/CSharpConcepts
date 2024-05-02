using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    //define a custom event argument class to hold event-specific data
    public class MyEventArgs : EventArgs
    {
        public string Message { get; } //property to store event message

        //constructor to initialize the event message
        public MyEventArgs(string message)
        {
            Message = message;
        }
    }
}
