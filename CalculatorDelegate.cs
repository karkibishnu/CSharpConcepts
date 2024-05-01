using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    //delegate that takes two integers as input params
    //returns an integer result
    delegate int ArithmeticOperation(int x, int y);
    class CalculatorDelegate
    {
        //method to perform arithmetic operation using provided callback
        //PerformOperation method takes two integers and a callb ack
        //method represented by ArithmeticOperation delete
        //It invoked callback method to perform arithmetic operation
        public int PerformOperation(int x, int y, ArithmeticOperation operation)
        {
            return operation(x, y);
        }
    }
}
