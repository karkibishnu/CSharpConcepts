namespace CSharpConcepts
{
    public class ReadOnlyVsStaticReadOnly
    {
        //ReadOnly field - must be initialized either at declaration or within the constructor
        public readonly int ReadOnlyField;

        //Static ReadOnly field - must be initialized either at declaration or within the static constructor
        public static readonly int StaticReadOnlyField;

        //static constructor to initialize the static readonly field
        static ReadOnlyVsStaticReadOnly()
        {
            StaticReadOnlyField = 11;
        }

        //constructor to initialize th readonly field
        public ReadOnlyVsStaticReadOnly(int value)
        {
            ReadOnlyField = value;
        }
    }
}
