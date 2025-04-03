package Modul_08_Objektorientierte_Programmierung;

public class Modul_08_Objektorientierte_Programmierung {

	public static void main(String[] args) {
	//Konzept der Objektorientierung-----------------------------------------------------------------------------------------------------------------------------------------------------------
	    
		//Definition von Objekten in der reallen Welt versucht man in der Programmierung nachzubauen
		
		String car1Brand = "Audi";
		int horsePower = 250;
		int yearOfConstruction = 2010;
		String color = "blau";
		
		String car2Brand = "Benz";
		int horsePower2 = 2230;
		int yearOfConstruction2 = 2012;
		String color2 = "rot";
		
		//So wie oben, ist es viel zu aufwendig jedesmal ein Objekt mit mehreren Variablen neu zu beschreiben.
		//Deswegen gibt es die Klassen, die wie ein Bauplan funktionieren zur Definition der relevanten Attribute für das Konzept Auto z.B.
		//Man kann sagen die Klassen sind ein bestimmter Datentyp mit Attribute für Objekte
		
	//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	//Klassen und Objekte-----------------------------------------------------------------------------------------------------------------------------------------------------------
	
		//Man erstellt eine neue Class Datei, hier z.B. Car.java
		//Das wird ohne die  public-static-main-Methode erstellt, da dies nicht als Programm durchlaufen soll
		//In Car.java werden die Attribute als Bauplan deklariert
		
		//Deklaration Variable
		int variable;
		
		//Objekt von der Klasse Car instanzieren
		Car car1 = new Car();
		
		//"Car" von "Car car1" ist ein komplexer Datentyp, da es sich um mehrere Variablen in der Klasse Car handelt
		//"new" in "new Car();" ist ein new-Operator und sorgt dafür, dass genügend Speicherplatz für alle Attribute innerhalb des Objekts reserviert wird
		
		car1.carBrand = "Audi";
		//"." in "car1.carBrand" ist ein Punkt Operator, damit kann man auf die einzelnen Attribute einer Klasse zugreifen 
		car1.horsePower = 230;
		car1.yearOfConstruction = 1999;
		car1.color = "blue";
		
		//So kann man das Attribut einer Klasse ausgeben.
		System.out.println(car1.carBrand);
		
		//Beispiel mit car2
		
		Car car2 = new Car();
		
		car2.carBrand = "BMW";
		car2.horsePower = 200;
		car2.yearOfConstruction = 1980;
		car2.color = "green";
		
	//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	//Methoden in Klassen-----------------------------------------------------------------------------------------------------------------------------------------------------------
	
		
		
	//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------	
	//Der Konstruktor-----------------------------------------------------------------------------------------------------------------------------------------------------------
	
	
		
	//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------	
	//Einschub: Was bedeutet "null"?-----------------------------------------------------------------------------------------------------------------------------------------------------------
	
		
		
	//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	//Der Konstruktor eröffnet weitere Möglichkeiten-----------------------------------------------------------------------------------------------------------------------------------------------------------
	
		
		
	//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	//Die Sichtbarkeitsmodifizierer private und public-----------------------------------------------------------------------------------------------------------------------------------------------------------
	
		
		
	//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	//Getter/Setter-----------------------------------------------------------------------------------------------------------------------------------------------------------
	
		
		
	//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------			
	}

}
