package Modul_03_Ein_und_Ausgabe_in_Java;

import java.util.Scanner;

public class Aufgaben {

	public static void main(String[] args) {
		//Programmieraufgabe 5----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		
		/* Benutzer	zur	Eingabe	von	Vornamen	auffordern	und	diesen	dann	über	die	Konsole	einlesen	
		 * Benutzer	zur	Eingabe	von	Nachnamen	auffordern	und	diesen	dann	über	die	Konsole	einlesen
		 * am Ende den vollständigen Namen (Vorname	und	Nachname) auf der Konsole ausgeben lassen
		 */

		Scanner sc = new Scanner(System.in);
		
		String vorname;
		String nachname;
		
		System.out.print("Wer bist du? Hier kommst du nicht rein. Wie ist dein Vorname? ");
		vorname = sc.next();
		
		System.out.print("und dein Nachname? ");
		nachname = sc.next();
		
		System.out.println("Hm... " + vorname + " " + nachname + " also..., schön für dich...");
		
		/*Zusatzaufgabe:	Sobald	Dein	Programm	läuft,	kannst	Du	dieses	noch	erweitern.
		 * Ergänze	Dein	Programm	so,	dass	zusätzlich	zum	Namen	auch	noch	das	Alter	des	Nutzers	abgefragt	wird.
		 * Am	Ende	soll	dann	zum	einen	der	Name	und	zum	anderen	das	Alter	des	Nutzers	ausgegeben	werden.
		 */
		
		int age;
		System.out.print("Wie alt bist du? ");
		age = sc.nextInt();
		
		System.out.println("Also nochmal, du heißt " + vorname + " " + nachname + " und lebst verdammte " + age + " Jahre auf dieser Welt! Na dann komm rein!");
	}

}
