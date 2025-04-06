using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektsammlung.Exercises.Ex_11_Interfaces
{
    internal class Motorrad : IKraftfahrzeug
    {
        public string Hersteller { get; set; }
        public int MaxGeschwindigkeit { get; set; }

        public void Bremsen()
        {
            Console.WriteLine("Das Motorrad fährt!");
        }
        public void Fahren()
        {
            Console.WriteLine("Das Motorrad bremst!");
        }
    }
}
