using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projektsammlung.Exercises;

namespace Projektsammlung.Exercises.Ex10_ObjProKlassen
{
    internal class BankKonto
    {
        //Eigenschaften
        public decimal Kontostand { get; set; }
        public string Besitzer { get; set; }

        //Methoden
        public void Einzahlen(decimal betrag)
        {
            Kontostand += betrag;
            Console.WriteLine($"Es wurden {betrag} Euro auf das Konto eingezahlt!");
            Console.WriteLine($"Der neue Kontostand beträgt {Kontostand} Euro!");
        }

        public void Auszahlen(decimal betrag)
        {
            Kontostand -= betrag;
            Console.WriteLine($"Es wurden {betrag} Euro vom Konto abgehoben!");
            Console.WriteLine($"Der neue Kontostand beträgt {Kontostand} Euro!");
        }
    }
}
