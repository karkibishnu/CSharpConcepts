using System;
using System.Reflection;

namespace CSharpConcepts
{
    public class ReadOnlyExample
    {
        //declaring a readonly field
        public readonly int ReadOnlyField;

        //constructor to initialize the readonly field
        //value can be assigned either at initialization or inside the constructor
        //also another way to update the readonly value is by using Reflection
        public ReadOnlyExample(int value)
        {
            ReadOnlyField = value;
        }

        //readonly value update using Reflection
        public void ChangeReadOnlyUsingReflection(int newValue)
        {
            //getting fieldinfo using reflection
            FieldInfo fieldInfo = GetType().GetField(nameof(ReadOnlyField), BindingFlags.Instance | BindingFlags.Public);

            //checking if field info is not null
            if(fieldInfo != null)
            {
                //setting the field value of readonly field using reflection
                fieldInfo.SetValue(this, newValue);
                Console.WriteLine($"New value of readonly field: {ReadOnlyField}");
            }
        }

    }
}
