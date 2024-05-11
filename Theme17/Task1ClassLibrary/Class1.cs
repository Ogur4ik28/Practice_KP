using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1ClassLibrary
{
    public class Triangle
    {
        public double Side1 { get; private set; }
        public double Side2 { get; private set; }
        public double Side3 { get; private set; }

        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public double Perimeter()
        {
            return Side1 + Side2 + Side3;
        }

        public double Area()
        {
            double s = Perimeter() / 2;
            return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
        }

        public string Type()
        {
            if (Side1 == Side2 && Side2 == Side3)
                return "Равносторонний";
            else if (Side1 == Side2 || Side2 == Side3 || Side1 == Side3)
                return "Равнобедренный";
            else
                return "Разносторонний";
        }
        public class Rectangle
        {
            public double Length { get; private set; }
            public double Width { get; private set; }

            public Rectangle(double length, double width)
            {
                Length = length;
                Width = width;
            }

            public double Perimeter()
            {
                return 2 * (Length + Width);
            }

            public double Area()
            {
                return Length * Width;
            }
        }
    }
}
