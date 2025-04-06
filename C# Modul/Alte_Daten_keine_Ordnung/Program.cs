using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Liste.Exercises;
using Projektsammlung.Exercises.Ex_10_ObjProKlassen;
using Projektsammlung.Exercises.Ex_11_InterfacesKlassen;
using Projektsammlung.Exercises.Ex_12_AbstrakteKlassen;
using Projektsammlung.Exercises.EX_13_Polymorphie;
using System.IO;

namespace Liste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hund hund = new Hund();
            //hund.Geschlecht = "Männlich";
            //hund.Alter = 102;

            //Katze katze = new Katze();
            //katze.Geschlecht = "Weiblich";
            //katze.Alter = 88;

            //Maus maus = new Maus();
            //maus.Geschlecht = "Weiblich";
            //maus.Alter = 34;

            //ITier[] tiere = new ITier[3];
            //tiere[0] = hund; 
            //tiere[1] = katze;
            //tiere[2] = maus;

            //foreach(ITier tier in tiere) 
            //{
            //    Console.WriteLine(tier.Geschlecht);
            //    Console.WriteLine(tier.Alter);

            //    tier.Trinken();
            //    tier.Fressen();
            //}

            //Console.ReadKey();
            

        }    
    }

    internal class ProgramEx11_13
    {
        static void Main(string[] args)
        {
            //Person2 schmidt = new Person2();
            //schmidt.Name = "schmidti";

            //Console.WriteLine(schmidt.Name);


            //-------------------------------------------------

            //Rectangle2 rectangle1 = new Rectangle2(10, 7);
            //rectangle1.GetArea();
            //Console.WriteLine(rectangle1.ToString());

            //Circle2 circle2 = new Circle2(4);
            //circle2.GetArea();
            //Console.WriteLine(circle2.ToString());

            //Console.ReadKey();

            //-------------------------------------------------

            //double[] numbers = new double[] { 8, 10, 12, 61, 9};
            //Console.WriteLine(Sum(numbers));
            //Console.WriteLine(10, 5);
            //Console.ReadKey();

            //--------------------------------------------------

            //DogX dog1 = new DogX("Bello", 18, "Alberto Müller" );
            //DogX dog2 = new DogX("Loco", 15);
            //dog1.DogInfo(dog1.Name, dog1.Age, dog1.Owner);
            //dog2.DogInfo(dog2.Name, dog2.Age);
            //Console.ReadKey();
        }

        //static double Sum(double a, double b)
        //{
        //    return a + b;
        //}

        //static double Sum(double[] numbers)
        //{ 
        //    double sum = 0;

        //    foreach (double number in numbers) 
        //    { 
        //        sum += number;
        //    }

        //    return sum;
        //}
    }

    internal class ProgramEx14
    {
        static void Main(string[] args)
        {
            //Stopwatch sw = new Stopwatch();

            //Point[] points = new Point[10000000];

            //sw.Start();
            //for (int i = 0; i < points.Length; i++)
            //{
            //    points[i] = new Point(i, i);
            //}
            
            //for (int i = 0;i < points.Length; i++) 
            //{
            //    points[i].MovePosition(1, 1);
            //}
            //sw.Stop();

            //Console.WriteLine("Fertig!");
            //Console.WriteLine($"Verstrichene Zeit: {sw.ElapsedMilliseconds}");

            //Console.ReadKey();
            ////Point point;
            ////point.x = 10;
            ////point.y = 5;

            ////Point point = new Point(5, 10);
            ////point.MovePosition(2, 2);

            ////Console.WriteLine($"{point.x}, {point.y}");
            ////Console.ReadKey();
            
            //----------------------------------------------------------------------
            
            
            //Personx personx1 = new Personx("Dirk Maier", Geschlecht.Männlich);
            //Console.WriteLine(personx1.Geschlecht);
        }
        
    }

    internal class ProgramEx15
    {
        static void Main(string[] args)
        {
            //List<string> namensListe = new List<string>()
            //{
            //    "Heinz",
            //    "Sarah",
            //    "Gustav",
            //    "Kata"
            //};

            //namensListe.Remove("Gustav");

            //Console.WriteLine(namensListe[2]);

            //Console.ReadKey();

            //--------------------------------------------------------------

            //Stack<int> numberStack = new Stack<int>();

            //numberStack.Push(1);
            //numberStack.Push(2);
            //numberStack.Push(3);
            //numberStack.Push(4);

            //Console.WriteLine(numberStack.Pop());
            //Console.WriteLine(numberStack.Pop());

            //Console.WriteLine(numberStack.Peek());

            //Console.ReadKey();

            //-----------------------------------------------------------------

            //Queue<string> personQueue = new Queue<string>();

            //personQueue.Enqueue("Albert");
            //personQueue.Enqueue("Sandra");
            //personQueue.Enqueue("Olaf");
            //personQueue.Enqueue("Ina");

            //Console.WriteLine(personQueue.Dequeue());
            //Console.WriteLine(personQueue.Dequeue());
            //Console.WriteLine(personQueue.Dequeue());
            //Console.WriteLine(personQueue.Peek());
            //Console.WriteLine(personQueue.Peek());

            //Console.ReadKey();

            //-------------------------------------------------------------------

            //Dictionary<int, string> kunden = new Dictionary<int, string>();

            //kunden.Add(1000, "Ralf");
            //kunden.Add(1001, "Alina");
            //kunden.Add(1002, "Peter");
            //kunden.Add(1003, "Anja");
            //kunden.Add(1004, "Ralf");
            //kunden.Add(1005, "Alina");
            //kunden.Add(1006, "Peter");
            //kunden.Add(1007, "Anja");

            //kunden.Remove(1003);
            //if (kunden.ContainsKey(1003))
            //    Console.WriteLine(kunden[1003]);

            //foreach (KeyValuePair<int, string> kundenInfo in kunden)
            //{
            //    Console.WriteLine($"Der Schlüssel {kundenInfo.Key} gehört zum Kunden {kundenInfo.Value}");
            //}

            //Console.ReadKey();

            //------------------------------------------------------------------------------------------

            //List<string> list = new List<string>()
            //{
            //    "Peter",
            //    "Alina",
            //    "Sabine",
            //    "Florian"
            //};
            //Console.WriteLine("Unsortiert!");
            //Console.WriteLine("-----------------------------");
            //foreach (string item in list) 
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            //list.Sort();

            //Console.WriteLine("Sortiert!");
            //Console.WriteLine("-----------------------------");
            //foreach (string item in list)
            //{
            //    Console.WriteLine(item);
            //}
        }

        
       
    }
    internal class ProgramEx16
    {
        //static void Main(string[] args)
        //{
        //    WerteBehälter<int> behälter = new WerteBehälter<int>(801);
        //    behälter.WertAusgabe();

        //    Console.ReadKey();

        //    List<string> namensListe = new List<string>();
        //    AddMultiple<string>(namensListe, 5, "Sabine");

        //    foreach (string name in namensListe)
        //        Console.WriteLine(name);

        //    Console.ReadKey();
        //}

        //static void AddMultiple<T>(List<T> list, int amount, T value)
        //{
        //    for (int i = 0; i < amount; i++)
        //    {
        //        list.Add(value);
        //    }
        //}
    }

    class WerteBehälter<T>
    {
        //public T MeinWert { get; set; }

        //public WerteBehälter(T wert)
        //{
        //    MeinWert = wert;
        //}

        //public void WertAusgabe()
        //{
        //    Console.WriteLine(MeinWert.ToString);
        //}
    }

   
    internal class ProgramEx17
    {
        //public delegate bool FilterDelegate(string str);
        //public delegate void AusgabeDelegate(string str);
        //static void Main(string[] args)
        //{
        //    //List<string> namen = new List<string>()
        //    //{
        //    //    "Horst",
        //    //    "Alina",
        //    //    "Hendrik",
        //    //    "Kai",
        //    //    "Janek",
        //    //    "Peter"
        //    //};

        //    ////List<string> newlist = ReturnNewList(namen, StartsWithH);
        //    ////List<string> newlist = ReturnNewList(namen, delegate (string name) { return name[0] == 'H'; });
        //    //List<string> newlist = ReturnNewList(namen, (name) => { return name[0] == 'H'; });
        //    //foreach (string name in newlist)
        //    //    Console.WriteLine(name);

        //    AusgabeDelegate ausgabe = new AusgabeDelegate(SayHello);
        //    ausgabe += SayGoodbye;

        //    ausgabe("Peter");

        //    Console.ReadKey();
        //}
        
        //static void SayHello(string name)
        //{ 
        //    Console.WriteLine($"{name} sagt Hallo!"); 
        //}

        //static void SayGoodbye(string name)
        //{
        //    Console.WriteLine($"{name} sagt Tschüss!");
        //}

        //static 
        //static List<string> ReturnNewList(List<string> original, FilterDelegate filtermethod)
        //{
        //    List<string> newList = new List<string>();

        //    foreach (string str in original) 
        //    { 
        //        if (filtermethod(str) == true)
        //            newList.Add(str);
        //    }

        //    return newList;
        //}

        //static bool StartsWithH(string s)
        //{
        //    return (s[0] == 'H' || s[0] == 'h') ;
        //}

        //static bool LongerThanFive(string s) 
        //{
        //    return s.Length > 5;
        //}
    }

    internal class ProgramEx18
    {
        
        static void Main(string[] args)
        {
            BetterList<string> names = new BetterList<string>();
            names.Added += OnAdded;

            names.Add("Sabrina");
            names.Add("Alina");
            names.Add("Peter");
            names.Add("Uwe");

            Console.ReadKey();
        }

        //static void OnAdded() 
        //{
        //    Console.WriteLine("Ein Objekt wurde zur Liste hinzugefügt...");
        //}
        static void OnAdded(object sender, AddedEventArgs args)
        {
            Console.WriteLine($"Das Objekt {args.AddedItem.ToString()} wurde hinzugefügt.");
        }

        //delegate void AddedEventHandler();
        delegate void AddedEventHandler(object sender, AddedEventArgs args);
        class BetterList<T> : List<T> 
        { 
            public new void Add(T item)
            {
                base.Add(item);

                OnAdded(item);
            }

            //public new void Add()
            //{
            //    base.Add(item);

            //    OnAdded();
            //    //if (Added != null) 
            //    //{
            //    //    Added();
            //    //}
            //}

            public event AddedEventHandler Added;
            //private void OnAdded()
            //{
            //    if (Added != null)
            //        Added();
            //}

            private void OnAdded(T item)
            {
                if (Added != null)
                {
                    Added(this, new AddedEventArgs(item));
                }
            }
        }

        class AddedEventArgs : EventArgs
        {
            public object AddedItem { get; set; }
            public AddedEventArgs(object addedItem)
            {
                AddedItem = addedItem;
            }
        }
    }

    internal class ProgramEx19
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    byte alter = 0;
                
            //    try
            //    {
            //        //Gebe dein Alter ein
            //        Console.WriteLine("Gebe dein Alter ein: ");
            //        alter = Convert.ToByte(Console.ReadLine());
            //    }
            //    catch (FormatException ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //        Console.WriteLine("Du musst eine Zahl eingeben!");
            //        Console.ReadKey();
            //        Console.Clear();
            //        continue;
            //    }
            //    catch (OverflowException ex)
            //    { 
            //        Console.WriteLine(ex.Message);
            //        Console.WriteLine("Gebe ein normales Alter ein!");
            //        Console.ReadKey();
            //        Console.Clear();
            //        continue;
            //    }
            //    catch (Exception ex) 
            //    {
            //        Console.WriteLine(ex.Message);
            //        Console.ReadKey();
            //        Console.Clear();
            //        continue;
            //    }

            //    if (alter >= 18)
            //    {
            //            Console.WriteLine("Du bist volljährig!");
            //    }
            //    else if (alter > 125)
            //    {
            //            Console.WriteLine("Bist du wirklich so alt?!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Du bist nicht volljährig!");
            //    }
            //}
        }
    }

    internal class ProgramEx20und21
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Pow(5, 4));
            Console.ReadKey();

            //-----------------------------------------------------------

            //Erzeuge Random Objekt
            Random rnd = new Random();

            //Generiere zufällige Zahl zwischen 1 und 9
            int zahl = rnd.Next(1,10);

            //Gebe die Zahl aus
            Console.WriteLine(zahl);
            Console.WriteLine();
            Console.ReadKey();

            //Erstelle Städte-Array
            string[] städteliste = 
            { 
                "Berlin",
                "Ingolstadt",
                "Düsseldorf",
                "Hamburg",
                "Leimen",
                "Heidelberg"
            };

            for (int i = 0; i < 5; i++)
            {
                //Erzeuge zufälligen Index
                int index = rnd.Next(0, städteliste.Length);

                //Gebe Stadt aus
                Console.WriteLine(städteliste[index]);
            }
            Console.WriteLine();
            Console.ReadKey();
            //NextDouble-Methode------------------------------------------

            //Erstelle Zufallsdouble
            double zahl1 = rnd.NextDouble();

            //Gebe die Zahl in der Konsole aus
            Console.WriteLine(zahl1);
            Console.WriteLine();
            Console.ReadKey();

            //NextBytes-Methode-------------------------------------------
            
            //Erstelle einen Byte-Array
            byte[] zahlenReihe = new byte[20];

            //Fülle den Array mit Werten
            rnd.NextBytes(zahlenReihe);

            //Gebe jede Zahl aus
            foreach (byte b in zahlenReihe)
                Console.WriteLine(b);
            Console.WriteLine();
            Console.ReadKey();
            //Konstruktor und der Seed-------------------------------------
            Random rnd2 = new Random(2987348);

            Console.WriteLine(rnd2.Next(1, 10));
            Console.WriteLine(rnd2.Next(1, 10));
            Console.ReadKey();
        }
    }

    internal class ProgramEx22
    {
        static void Main(string[] args)
        {
            ////Erstelle DirectoryInfo-Objekt
            //string pfad = "C:\\Users\\Anwender\\Desktop\\Testordner";
            //DirectoryInfo verzeichnis = new DirectoryInfo(pfad);

            ////Console.WriteLine(verzeichnis.Name);
            ////Console.WriteLine(verzeichnis.FullName);
            ////Console.WriteLine(verzeichnis.Root);
            ////Console.WriteLine(verzeichnis.CreationTime);

            ////Console.ReadKey();

            //DirectoryInfo[] verzeichnisse = verzeichnis.GetDirectories();

            //foreach(DirectoryInfo dir  in verzeichnisse)
            //{
            //    Console.WriteLine(dir.Name);
            //}

            //FileInfo[] dateien = verzeichnis.GetFiles();

            //foreach(FileInfo datei in dateien)
            //{ 
            //    Console.WriteLine(datei.Name);
            //}

            //string pfad2 = "C:\\Users\\Anwender\\Desktop\\Testordner\\TestDatei.txt";
            //FileInfo file = new FileInfo(pfad2);

            //Console.WriteLine(file.Exists);

            //Console.WriteLine(file.Name);
            //Console.WriteLine(file.FullName);
            //Console.WriteLine(file.Directory);
            //Console.WriteLine(file.DirectoryName);
            //Console.WriteLine(file.Extension);


            //StreamReader sr = new StreamReader("C:\\Users\\Anwender\\Desktop\\Testordner\\TestDatei.txt");

            //Console.WriteLine(sr.ReadToEnd());
            //sr.Close();

            //StreamWriter sw = new StreamWriter($"C:\\Users\\Anwender\\Desktop\\Testordner\\TestDatei.txt", true);

            //sw.WriteLine("");
            //sw.WriteLine("Hallo mein Name ist nicht Janek");
            //sw.Close();

            //using (StreamWriter sw = new StreamWriter($"C:\\Users\\Anwender\\Desktop\\Testordner\\TestDatei.txt", true))
            //{
            //    sw.WriteLine("");
            //    sw.WriteLine("Hallo mein Name ist nicht Janek");
            //}

            //Console.ReadKey();
        }
    }
    struct Point
    {
    //    public int x;
    //    public int y;

    //    public Point(int _x, int _y)
    //    {
    //        x = _x;
    //        y = _y;
    //    }

    //    public void MovePosition(int x_movement, int y_movement)
    //    {
    //        x += x_movement;
    //        y += y_movement;
    //    }

    }

    //--------------------------------------------------------------------

    enum Geschlecht
    {
    //    Männlich = 0,
    //    Weiblich = 1,
    //    Divers = 2
    }

    //---------------------------------------------------------------------

    class Personx
    { 
    //    public string Name { get; set; }
    //    public Geschlecht Geschlecht { get; set; }

    //    public Personx(string name, Geschlecht geschlecht) 
    //    { 
    //        Name = name;
    //        Geschlecht = geschlecht;
    //    }
    }


}
