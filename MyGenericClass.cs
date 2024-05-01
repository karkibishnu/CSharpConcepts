using System;

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

        public void GetGenericTypeInformation<T>(MyGenericClass<T> instance)
        {
            //getting the type of the generic used in MyGenericClass
            Type genericType = typeof(MyGenericClass<>);
            Type[] typeArguments = genericType.GetGenericArguments();
            Type genericTypeUsed = typeArguments[0];

            //getting the type of the data stored in the instance
            Type dataType = typeof(T);

            Console.WriteLine($"Type of generic used in MyGenericClass: { genericTypeUsed.Name}");
            Console.WriteLine($"Type of data stored in the instance: {dataType.Name}");
        }
    }
}
