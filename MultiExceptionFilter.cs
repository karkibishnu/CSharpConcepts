using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public class MultiExceptionFilter
    {
        public bool MultiCatchOperation()
        {
            bool success = true;

            try
            {
                // operation that could throw multiple types of exception
            }
            catch (Exception ex) when ((ex is NullReferenceException) ||
                                        (ex is ArgumentNullException) ||
                                        (ex is ArgumentOutOfRangeException))
            {
                success = false;
            }

            return success;
        }
    }
}
