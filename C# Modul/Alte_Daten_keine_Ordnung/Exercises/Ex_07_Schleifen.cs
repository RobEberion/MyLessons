using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Liste.Exercises
{
    internal class Ex_07_Schleifen
    {
        public void Main()
        {

            ////--Exercises 7 Schleifen--------------------------------------------------------------------------
            ////-------------------------------------------------------------------------------------------------

            //static void FromEvenNumber(int minnumber, int maxnumber)
            //{
            //    while (minnumber <= maxnumber)
            //    {
            //        if (minnumber % 2 == 0)
            //        {
            //            Console.WriteLine(minnumber);
            //        }
            //        minnumber++;
            //    }
            //}
            //FromEvenNumber(1, 10);

            ////-------------------------------------------------------------------------------------------------

            //static void Calculator()
            //{

            //    while (true)
            //    {
            //        Console.Write("Gebe die erste Zahl ein: ");
            //        decimal number1 = Convert.ToDecimal(Console.ReadLine());

            //        Console.Write("Gebe die zweite Zahl ein: ");
            //        decimal number2 = Convert.ToDecimal(Console.ReadLine());

            //        Console.WriteLine("Gebe einen der folgenden Rechenoperator ein: + - * / ");
            //        string operation = Console.ReadLine();

            //        switch (operation)
            //        {
            //            case "+":

            //                Console.WriteLine($"\n{number1} {operation} {number2} = {number1 + number2}\n");
            //                Console.WriteLine();
            //                break;

            //            case "-":

            //                Console.WriteLine($"\n{number1} {operation} {number2} = {number1 - number2}\n");
            //                Console.WriteLine();
            //                break;

            //            case "*":

            //                Console.WriteLine($"\n{number1} {operation} {number2} = {number1 * number2}\n");
            //                Console.WriteLine();
            //                break;

            //            case "/":

            //                if (number2 == 0) { Console.WriteLine($"\n{number1} {operation} {number2} = 0\n"); }

            //                Console.WriteLine($"\n{number1} {operation} {number2} = {number1 / number2}\n");
            //                Console.WriteLine();
            //                break;

            //            default:
            //                Console.WriteLine("Ungültige Operation");
            //                break;
            //        }
            //        Console.ReadKey();
            //        Console.Clear();
            //    }
            //}
            //Calculator();

            ////-------------------------------------------------------------------------------------------------

            //static void MultiplicationList(int number)
            //{
            //    for (int listNumber = 1; listNumber <= 10; listNumber++)
            //    {
            //        Console.WriteLine($"{number} * {listNumber} = {number * listNumber}");
            //    }
            //    Console.ReadKey();
            //}
            //MultiplicationList(6);

            ////-------------------------------------------------------------------------------------------------

            //static void DrawRectangle(int width, int height)
            //{
            //    char symbol = '#';

            //    for (int y = 0; y < height; y++)
            //    {
            //        for (int x = 0; x < width; x++)
            //        {
            //            Console.Write(symbol);

            //        }
            //        Console.WriteLine();
            //    }
            //    Console.ReadKey();
            //}
            //DrawRectangle(10, 5);

            ////-------------------------------------------------------------------------------------------------

            //static void Multiplikationtableeasy()
            //{
            //    for (int y = 1; y <= 10; y++)
            //    {
            //        for (int x = 1; x <= 10; x++)
            //        {
            //            Console.Write($"{x}*{y}={x * y}");

            //            int spaces = (x * 10) - Console.CursorLeft;
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.ReadKey();
            //}
            //Multiplikationtableeasy();

            ////-------------------------------------------------------------------------------------------------

            //static void Multiplikationtablehard()
            //{
            //    for (int y = 1; y <= 10; y++)
            //    {
            //        for (int x = 1; x <= 10; x++)
            //        {
            //            Console.Write($"{x}*{y}={x * y}");

            //            int spaces = (x * 10) - Console.CursorLeft;

            //            for (int i = 0; i < spaces; i++)
            //            {
            //                Console.Write(" ");
            //            }
            //        }
            //        Console.WriteLine();
            //    }

            //    Console.ReadKey();
            //}
            //Multiplikationtablehard();

            ////-------------------------------------------------------------------------------------------------

            //static void SplitText()
            //{
            //    string text = "Hallo Welt";

            //    for (int i = 0; i < text.Length; i++)
            //    {
            //        if (i == 0)
            //        {
            //            Console.WriteLine(text);
            //        }
            //        else
            //        {
            //            Console.WriteLine(text[i]);
            //        }
            //    }
            //    Console.ReadKey();
            //}
            //SplitText();

            ////-------------------------------------------------------------------------------------------------

            //static void IsPalindrom()
            //{
            //    while (true)
            //    {
            //        Console.Write("Gebe ein Wort ein: ");
            //        string words = Console.ReadLine();

            //        if (ReverseWord(words))
            //        {
            //            Console.WriteLine($"{words} ist ein Palindrom. :)");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{words} ist KEIN Palindrom! :(");
            //        }
            //        Console.ReadKey();
            //        Console.Clear();
            //    }
            //}
            //static bool ReverseWord(string words)
            //{
            //    string reversed = "";

            //    for (int i = words.Length - 1; i >= 0; i--)
            //    {
            //        reversed += words[i];
            //    }

            //    return reversed.ToLower() == words.ToLower();
            //}
            //IsPalindrom();

            ////-------------------------------------------------------------------------------------------------

            //static void OnlyLetter()
            //{
            //    while (true)
            //    {
            //        Console.Write("Bitte schreibe irgendwas: ");
            //        string text = Console.ReadLine();
            //        string newText = "";

            //        foreach (char word in text)
            //        {
            //            if (char.IsLetter(word))
            //            {
            //                newText += word;
            //            }

            //        }
            //        Console.WriteLine(newText);
            //        Console.ReadKey();
            //        Console.Clear();
            //    }
            //}
            //OnlyLetter();

            //-------------------------------------------------------------------------------------------------
        }
   }
}
