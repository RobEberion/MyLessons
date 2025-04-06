using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projektsammlung.Exercises.Ex_10_ObjProKlassen;


namespace Projektsammlung.Exercises
{
    internal class Ex10_ObejtorientierteProgrammierung
    {
        public void Main()
        {
            //Bank----------------------------------------------------------------------------

            //BankKonto konto1 = new BankKonto();
            //BankKonto konto2 = new BankKonto();
            //konto1.Kontostand = 2500;
            //konto2.Kontostand = 10000000;
            //konto1.Besitzer = "Sandra Müller";
            //konto2.Besitzer = "Robert O.";

            //konto1.Einzahlen(250);
            //konto2.Auszahlen(1600);

            //Console.WriteLine($"Kontostand von {konto1.Besitzer}: {konto1.Kontostand} Euro.");
            //Console.WriteLine($"Kontostand von {konto2.Besitzer}: {konto2.Kontostand} Euro.");
            //Console.WriteLine();

            ////--------------------------------------------------------------------------------
            ////Auto----------------------------------------------------------------------------

            //Auto auto = new Auto();
            //auto.Hersteller = "SuperCar";
            //Console.WriteLine(auto.Hersteller);
            //auto.AnzahlTüren = 4;
            //Console.WriteLine(auto.AnzahlTüren);
            //Console.ReadKey();

            ////---------------------------------------------------------------------------------
            ////Hund-----------------------------------------------------------------------------

            //Hund hund1 = new Hund("Rex", 10, "deutscher Schäferhund", "männlich");
            //hund1.Name = "Rex";
            //hund1.Age = 10;
            //hund1.Breed = "deutscher Schäferhund";
            //hund1.Gender = "männlich";

            //Hund hund2 = new Hund("Laika", 8, "Mischhund Husky, Terrier", "weiblich");
            //Hund hund3 = new Hund("Barry", 16, "Bernhardiner", "männlich");
            //Hund hund4 = new Hund("Lassie", 17, "Langhaar-Collie", "weiblich");


            //hund2.Bellen();
            //hund3.Fressen("Pizza");

            //Console.ReadKey();

            ////---------------------------------------------------------------------------------
            ////AreaCalculator-------------------------------------------------------------------

            //double number1 = AreaCalculator.getTriangleArea(4, 5);
            //Console.WriteLine(number1);
            //double number2 = AreaCalculator.getRectangleArea(4, 5);
            //Console.WriteLine(number2);
            //double number3 = AreaCalculator.getSquareArea(4);
            //Console.WriteLine(number3);
            //double number4 = AreaCalculator.getCircleArea(4);
            //Console.WriteLine(number4);

            //-----------------------------------------------------------------------------------
            //Person and Teacher, Student--------------------------------------------------------
            //Person[] peopleInClassroom =
            //{
            //    new Person("Hans", "Günther", 39),
            //    new Person("Anne", "Marie", 50),
            //    new Teacher("Tim", "Burton", 46),
            //    new Student("Lara", "Lu", 36),
            //    new Student("Olaf", "Burton", 16),
            //    new Student("Lara", "Lu", 17)
            //};

            //foreach (Person p in peopleInClassroom)
            //{
            //    p.PrintInformation();

            //    if (p is Teacher)
            //    {
            //        (p as Teacher).Teach();
            //    }
            //    else if (p is Student)
            //    {
            //        (p as Student).ListenToTeacher();
            //    }
            //}

            //Console.ReadKey();
        }
    }
    //internal class Auto
    //{
    //    //Auto---------------------------------------------------------------------------------
    //    //Eigenschaften
    //    public string Hersteller { get; set; }

    //    private int anzahlTüren;
    //    public int AnzahlTüren
    //    {
    //        get
    //        {
    //            return anzahlTüren;
    //        }
    //        set
    //        {
    //            if (value < 1)
    //            {
    //                anzahlTüren = 1;
    //            }
    //            else
    //            {
    //                anzahlTüren = value;
    //            }
    //        }
    //    }
    //    //_______________________________________________________________________________________
    //}
}

