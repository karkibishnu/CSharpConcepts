using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    // generic class definition
    public class MyGenericClass<T>
    {
        private T _value;

        //constructor
        public MyGenericClass(T value)
        {
            _value = value;
        }

        //method using generic type parameter
        public void DisplayValue()
        {
            Console.WriteLine($"Value: {_value}");
        }
    }
}
