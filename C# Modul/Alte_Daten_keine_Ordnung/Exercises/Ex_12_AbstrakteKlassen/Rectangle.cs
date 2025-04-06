using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projektsammlung.Exercises.Ex_12_AbstrakteKlassen;

namespace Projektsammlung.Exercises.Ex_12_AbstrakteKlassen
{
    internal class Rectangle2 : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }


        public Rectangle2(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override void GetArea()
        { 
            Console.WriteLine($"{Height} * {Width} = {Height * Width}");
        }
        public override string ToString()
        {
            return $"Rechteck mit einer Höhe von {Height} und Breite von {Width}.";
        }
    }
}
