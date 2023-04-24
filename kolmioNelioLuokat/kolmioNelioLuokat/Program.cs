using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolmioNelioLuokat
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square1 = new Square(5, 10);
            Console.WriteLine($"Area on square one is {square1.Area()}");
            Console.WriteLine($"Circumference on square one is {square1.Circumference()}");
            Console.ReadKey();
        }
    }
    public class Square
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Square(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Area()
        {
            return Width * Height;
        }
        public double Circumference()
        {
            return (Width * 2) + (Height * 2);
        }
    }
    public class Triangle
    {

    }
}
