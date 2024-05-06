using System;

namespace CSharpConcepts
{
    class Animal
    {
        //virtual method in base class
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes sound");
        }
    }

    class Dog : Animal
    {
        //child class does not override base class
    }

    class Cat : Animal

    {
        //override virtual method in base class
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Horse : Animal
    {
        /*
         * method hiding is used when a method in a derived class has
         * same name as method in its base calss but diff. implementation
         * the 'new' keyword is used in derived class to explicitly hide 
         * the base class method
         * method hiding introduces a new method with the same name as
         * the base class method but is nto related to POLYMORPHISM
         * when a hidden method is called on an instance of derived class
         * through reference of hte base class type, the base class method
         * is invoked, not the hidden method
         * method hiding is based on shadowing and occurs statically at 
         * compile time
        */
        public new void MakeSound()
        {
            Console.WriteLine("New method hiding");
        }
    }

    //method overloading example for achieving compile-time polymorphism
    class MathematicalOperation
    {
        //method overloading : two methods with same name
        //but different parameters
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
    }
}
