using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public static class StaticConverter
    {
        //conversion pretty much remains same so
        //using static is a good example for such cases
        public static double ToFerenheit(double celcius)
        {
            return (celcius * 9 / 5) + 32;
        }

        public static double ToCelcius(double farenheit)
        {
            return (farenheit - 32) * 5 / 9;
        }
    }
}
