using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektsammlung.Exercises.Ex_11_InterfacesKlassen
{
    internal class Katze : ITier
    {
        //eigenschaften
        public string Geschlecht { get; set; }
        public int Alter { get; set; }


        //Methoden
        public void Trinken()
        {
            Console.WriteLine("Die Katze trinkt!");
        }
        public void Fressen()
        {
            Console.WriteLine("Die Katze frisst!");
        }
    }
}
