using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolmioNelioLuokat
{
    class Triangle
    {
        // Properties
        public double Height { get; set; }
        public double Base { get; set; }
        // Consturctors
        public Triangle(double height, double baseParameter)
        {
            Height = height;
            Base = baseParameter;
        }
        // Methods
        public double Area()
        {
            return Height * Base / 2;
        }
        public double Perimeter()
        {
            return Height + Base + Math.Sqrt(Math.Pow(Base,2) + Math.Pow(Height,2)); 
        }
    }
}
