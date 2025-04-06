using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektsammlung.Exercises.Ex_12_AbstrakteKlassen
{
    internal class Circle2 : Shape
    {
        public double Radius { get; set; }

        public Circle2(double radius)
        {
            Radius = radius;
        }
        public override void GetArea()
        {
            Console.WriteLine($"{Radius} * {Radius} = {Radius * Radius}");
        }
        public override string ToString()
        {
            return $"Kreis mit einem Radius von {Radius}.";
        }

    }
}
