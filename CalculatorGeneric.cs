namespace CSharpConcepts
{
    public class CalculatorGeneric : ICalculable<int>, ICalculable<float>
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public float Add(float a, float b)
        {
            return a + b;
        }
    }
}
