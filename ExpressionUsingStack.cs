using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public static class ExpressionUsingStack
    {
        public static bool CheckIncomingExpression(string expression)
        {
            bool expresionMatching = false;
            //convert the expresion to char array first 
            char[] charArray = expression.ToCharArray();
            Stack<char> charStack = new Stack<char>();
            //loop through each char array
            foreach (char c in charArray)
            {
                //insert into stack if opening bracket
                if (c == '{' || c == '[' || c == '(')
                {
                    charStack.Push(c);
                }
                //else pop and match
                else
                {
                    if(charStack.Count > 0)
                    {
                        char popItem = charStack.Peek();
                        if ((popItem == '{' && c == '}')
                            || (popItem == '[' && c == ']')
                            || (popItem == '(' && c == ')'))
                        {
                            charStack.Pop();
                        }
                    }                    
                    else 
                    { 
                        charStack.Push(c); 
                    }
                }
            }

            if (charStack.Count == 0)
            {
                expresionMatching = true;
            }
            return expresionMatching;
        }
    }
}
