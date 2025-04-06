using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Projektsammlung.Exercises.Ex_10_ObjProKlassen
{
    internal class Person
    {
        //Eigenschaften
        public string TheFirstName { get; set; }
        public string TheLastName { get; set; }
        public int Age { get; set; }

        //Konstruktor
        public Person(string firstname, string lastname, int age)
        {
            TheFirstName = firstname;
            TheLastName = lastname;
            Age = age;
        }

        //Methoden
        public void PrintInformation()
        {
            Console.WriteLine($"Name: {TheFirstName} {TheLastName}.");
            Console.WriteLine($"Alter: {Age}.");
        }
    }

    class Teacher : Person
    {
        public Teacher(string firstname, string lastname, int age) : base(firstname, lastname, age)
        {
        }

        //Methoden
        public void Teach()
        {
            Console.WriteLine($"Herr/Frau {TheLastName} unterrichtet die Klasse!");
        }
    }

    class Student : Person
    {
        public Student(string firstname, string lastname, int age) : base(firstname, lastname, age)
        {
        }

        //Methoden
        public void ListenToTeacher()
        {
            Console.WriteLine($"Der/Die Schüler/in {TheFirstName} {TheLastName} hört dem Lehrer zu!");
        }
    }
}
