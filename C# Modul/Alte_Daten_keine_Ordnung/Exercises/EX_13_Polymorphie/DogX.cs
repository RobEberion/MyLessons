using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektsammlung.Exercises.EX_13_Polymorphie
{
    internal class DogX
    {
        //eigenschaften
        public string Name { get; set; }
        public int Age { get; set; }
        public string Owner { get; set; }

        public DogX(string name, int age, string owner)
        {
            Name = name;
            Age = age;
            Owner = owner;
        }

        public DogX(string name, int age)
        {
            Name = name;
            Age = age;
        }

        //Methoden
        public void DogInfo(string name, int age, string owner)
        {
            Console.WriteLine($"Der Name des Hundes ist {name}, er ist {age} Jahre alt und sein Besitzer ist {owner}.");
        }
        public void DogInfo(string name, int age)
        {
            Console.WriteLine($"Der Name des Hundes ist {name}, er ist {age} Jahre alt und ist ein Streuner.");
        }
    }
}
