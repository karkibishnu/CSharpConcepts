namespace CSharpConcepts
{
    public class RefAndOutExample
    {
        //method using ref parameter to increment a variable
        public void IncrementUsingRef(ref int x)
        {
            //increment the value of x by 1
            x++;
        }

        //method using out parameters to calculate quotient and reminder
        public void Divide(int divident, int divisor, out int quotient, out int reminder)
        {
            //calculate quotient and remainder
            quotient = divident / divisor;
            reminder = divident % divisor;
        }
    }
}
