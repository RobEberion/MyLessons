package Modul_04_Der_Umgang_mit_Operatoren_in_Java;

import java.util.Scanner;

public class Aufgabe_Teilung_und_Restwert 
{

	public static void main(String[] args) 
	{
		Scanner sc = new Scanner(System.in);
	
		int number1, number2;
		
		System.out.print("Bitte gebe deine erste Ganzzahl als Dividend ein: ");
		number1 = sc.nextInt();
		
		System.out.print("Bitte gebe deine zweite Ganzzahl als Divisor ein: ");
		number2 = sc.nextInt();
		
		System.out.println(); //Nur für eine Leerzeile da
		
//------Option A------------------------------------------------------------------------
		
		System.out.println("Ergebnis: " + (number1 / number2));
		System.out.println("Divisionsrest: " + (number1 % number2));
		
//------Option B------------------------------------------------------------------------
		
		int result1 = number1 / number2;
		int result2 = number2 * result1;
		int result3 = number1 % number2;
	
		System.out.println("Die Rechnung ist: " + number1 + " : " + number2 + " = " + result1);
		System.out.println("Bei der Rechnung wurde die Zahl " + result2 + " genommen und mit " + number2 + " geteilt.");
		System.out.println("Deswegen ergibt sich ein Restwert von " + result3 + ".");
		
	}

}
