using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projektsammlung.Exercises;

namespace Projektsammlung.Exercises.Ex_11_InterfacesKlassen
{
    internal class Hund : ITier
    {
        //eigenschaften
        public string Geschlecht { get; set; }
        public int Alter {  get; set; }
        
        
        //Methoden
        public void Trinken()
        {
            Console.WriteLine("Der Hund trinkt!");
        }
        public void Fressen()
        {
            Console.WriteLine("Der Hund frisst!");
        }
    }
}
