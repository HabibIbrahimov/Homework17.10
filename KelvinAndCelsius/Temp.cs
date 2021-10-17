using System;
using System.Collections.Generic;
using System.Text;

namespace KelvinAndCelsius
{
    class Celsius
    {
        public double Cel { get; set; }
        public Celsius(double c)
        {
            Cel = c;
        }
        public static implicit operator Kelvin(Celsius celsius)
        {
            return new Kelvin(celsius.Cel + 273.15);
        }
    }
    class Kelvin
    {
        public double Kel { get; set; }
        public Kelvin(double k)
        {
            Kel = k;
        }
    }
}
