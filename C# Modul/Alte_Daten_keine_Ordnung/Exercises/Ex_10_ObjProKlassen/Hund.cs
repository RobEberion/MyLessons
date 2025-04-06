using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektsammlung.Exercises.Ex10_ObjProKlassen
{
    internal class Hund
    {
        //Eigenschaften
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        public string Gender { get; set; }

        //Bsp.1
        //private string herrchen;

        //Konstruktor
        public Hund(string name, int age, string breed, string gender/*, string herrchen*/)
        {
            //Bsp. 1
            //this.herrchen = herrchen;
            Name = name;
            Age = age;
            Breed = breed;
            Gender = gender;
        }



        //Methoden
        public void Bellen()
        {
            Console.WriteLine($"{Name} bellt!");
        }

        public void Fressen(string Essen)
        {
            Console.WriteLine($"{Name} frisst {Essen}!");
        }
    }
}
