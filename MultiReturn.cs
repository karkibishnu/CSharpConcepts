namespace CSharpConcepts
{
    public class MultipleValues
    {
        public int IntValue { get; set; }
        public string StringValue { get; set; } 
        public bool BoolValue { get; set; }
    }
    public class MultiReturn
    {
        //method using tuples
        public (int, string ,bool) GetValuesAsTuples()
        {
            int intValue = 10;
            string stringValue = "Hello";
            bool boolValue = false;

            return (intValue, stringValue, boolValue);
        }

        //method using out params
        public void GetValuesAsOut(out int intValue, out string stringValue, out bool boolValue)
        {
            intValue = 20;
            stringValue = "World";
            boolValue = true;
        }

        //method using instance of class with multple properties
        public MultipleValues GetValuesAsClass()
        {
            return new MultipleValues
            {
                IntValue = 30,
                StringValue = "!",
                BoolValue = false
            };
        }

        //method using ref params
        public void GetValuesUsingRef(ref int intValue, ref string stringValue, ref bool boolValue)
        {
            //modifying values passed by reference
            intValue += 10;
            stringValue += " !!";
            boolValue = false;
        }
    }
}
