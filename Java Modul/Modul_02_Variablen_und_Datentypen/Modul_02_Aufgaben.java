package Modul_02_Variablen_und_Datentypen;

public class Aufgaben {

	public static void main(String[] args) 
	{
		//Programmieraufgabe 2
		
		//a) Initialisiere	eine	Variable	mit	der	Ganzzahl	70
		
		int ganzzahl = 70;
		
		/*b) Deklariere	eine	Variable,	in	der	wir	irgendwann	später	im	Programm	eine	Kommazahl	abspeichern	werden.	
		 * (Die	Kommazahl,	die	darin	abgespeichert	wird,	repräsentiert	das	Gewicht	einer	Person,	z.B.	70,2). 
		 */
		
		float gewicht;
		gewicht = 70.2f;
		
		//c) Deklariere	eine Variable mit dem Bezeichner	„age"	und	weise	dieser	in	einer	separaten	Zeile	Code	Dein	Alter	zu.	
		
		int age;
		age = 40;
		
		//------------------------------------------------------------------------------------------------------------------------------------------------------
		//Programmieraufgabe3
		
		//a) Initialisiere	die	Variable	"letter"	mit	dem	Buchstaben	„t“
		
		char letter = 't';
		
		//b) Deklariere	eine	Variable	und	weise	dieser	in	einer	separaten	Zeile	den	Anfangsbuchstaben	Deines	Namens	zu.	
		
		char letterName;
		letterName = 'R';
		
		//------------------------------------------------------------------------------------------------------------------------------------------------------
		//Programmieraufgabe4
		
		//a) Deklariere	eine	Variable	vom	Typ	String	mit	dem	Bezeichner	„sentence1“.
		
		String sentence1;
				
		//b) Deklariere	eine	zweite	Variable	und	initialisiere	diese	mit	dem	Satz	„Heute	scheint	die	Sonne!“
		
		String sentence2 = "Heute scheint die Sonne!";
		
		/* c)	Weise	der	Variable	„sentence1“	den	gleichen	Inhalt	zu,	den	die	Variable	aus	Teilaufgabe	b)	auch	besitzt.
		 * 		Für	diese	Teilaufgabe	existieren	2	unterschiedliche	Lösungswege.	
		 * 		Versuche	auf	beide	Lösungswege	zu	kommen	und	probiere	diese	aus.
		 */
		
		sentence1 = sentence2;
		sentence1 = "Heute scheint die Sonne!";
	}

}
