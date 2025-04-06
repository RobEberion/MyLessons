using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektsammlung.Exercises.Ex_11_InterfacesKlassen
{
    internal interface ITier
    {
        //Eigenschaften
        string Geschlecht { get; set; }
        int Alter { get; set; }

        //Methoden
        void Fressen();
        void Trinken();
    }
}
