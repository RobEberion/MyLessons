package Modul_04_Der_Umgang_mit_Operatoren_in_Java;

import java.util.Scanner;

public class Aufgabe_BMI_Rechner 
{

	public static void main(String[] args) 
	{
		//BMI-Rechner
		
		Scanner scan = new Scanner(System.in);
		
		float bodyweight = 0f;
		float bodyheight = 0f;
		
		System.out.print("Wieviel wiegst du? (in kg) = ");
		bodyweight = scan.nextFloat();
		
		System.out.print("Wie groß bist du? (in m) = ");
		bodyheight = scan.nextFloat();
		
		float bmi = bodyweight/(bodyheight*bodyheight);
		
		System.out.println();
		
		bmi = (100*bmi); 
		bmi = Math.round(bmi);	//Runden mit 2 Kommastellen (Ergebnis*100 / Ergebnis runden / Ergebnis durch 100 teilen)
		bmi = bmi/100;
		
		/*	Math.round
		 * 	Float wird in eine int Ganzzahl gerundet
		 * 	Double wird in eine long Ganzzahl gerundet
		 * 
		 * 	Math.floor
		 *  Rundet die Zahl mit eine Kommastelle auf
		 */
		
		System.out.println("Mit deiner Größe von " + bodyheight + " m und einem Gewicht von " + bodyweight + " kg, hast du ein BMI von " + bmi);
		
		if (bmi < 18.5)
		{
			System.out.println("Du hast Untergewicht.");
		}
		else if (bmi < 25.0)
		{
			System.out.println("Du hast Normalgewicht.");
		}
		else if (bmi < 30.0)
		{
			System.out.println("Du hast Übergewicht.");
		}
		else if (bmi < 35.0)
		{
			System.out.println("Du hast Adipositas Grad I.");
		}
		else if (bmi < 40.0)
		{
			System.out.println("Du hast Adipositas Grad II.");
		}
		else if (bmi >= 40.0)
		{
			System.out.println("Du hast Adipositas Grad III.");
		}
		else
		{
			System.out.println("Die Eingabe ist ungültig.");
		}
	}

}
