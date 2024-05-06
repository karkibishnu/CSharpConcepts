using System;

namespace CSharpConcepts
{
    public static class ThrowVsThrowExException
    {
        public static void DivideByZeroThrow(int dividend, int divisor)
        {
            try
            {
                PerformDivision(dividend, divisor);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Divide by zero THROW error: {ex.StackTrace}");
                throw;
            }
        }

        public static void DivideByZeroThrowEx(int dividend, int divisor)
        {
            try
            {
                PerformDivision(dividend, divisor);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Divide by zero THROW EX error: {ex.StackTrace}");
                throw ex;
            }
        }

        private static void PerformDivision(int dividend, int divisor)
        {
            int result = dividend / divisor;
        }
    }
}
