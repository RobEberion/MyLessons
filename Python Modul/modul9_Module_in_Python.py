#--Einführung - Was sind Module?

"""
Für eine bessere Übersicht, vor allem bei komplexem Code, kann man ein Programm auf mehrere Files aufteilen. 
Das eignet sich vor allem, wenn man ein großes Problem in mehrere Teilprobleme aufteilen kann, die man dann einzeln programmiert.  

Dadurch kann man zum einen Aufgaben innerhalb eines Teams besser aufteilen. 
Einzelne Module können so unabhängig voneinander entwickelt werden. 
Später können die Module dann ins Hauptprogramm geladen werden, um dort auf die ganzen Funktionalitäten zuzugreifen. 
Außerdem kann man dadurch einzelne Module sehr gut wiederverwenden, wenn man sie öfter verwenden muss. 
Zudem können Fehler einfacher gefunden werden und Abhängigkeiten werden verringert. 
Denn jedes Modul bildet eine abgeschlossene Einheit und kann separat getestet werden. 
"""



#--Module einbinden/laden

import m9_calc

res = m9_calc.addition(5, 10)
print (res)
#---------------------------------------
import m9_calc as calculation

res = calculation.addition(5, 10)
#---------------------------------------
from m9_calc import *
"""
die Sternzeichenschreibweise * sollte man vermeiden, 
da es mit zu vielen Funktionen zu Namenskonflikten entstehen könnte
"""
res2 = addition(2, 3)

res3 = faculty(5)
#---------------------------------------
from m9_calc import faculty, addition

res2 = addition(2, 3)

res3 = faculty(5)



#--Beispiel: Das built-in Modul math

import math

resx = math.factorial(5)
print (resx)



#--Beispiel: Das built-in Modul random

import random

random_value = random.uniform(1, 10)
random_value2 = random.randint(1, 10)
print(random_value)
print(random_value2)

lottery = ["Susi", "Hans", "Wolfgang", "Peter", "Dieter"]
winner = random.choice(lottery) #ein Wert wird ausgewählt
winner2 = random.choices(lottery, k=2) #2 Gewinner möglich, gleicher Wert kann öfter gezogen werden
winner3 = random.sample(lottery, k=3) #mehrere Gewinner 3 insgesamt, aber jeder kann nur einmal gezogen werden
print(winner)
print(winner2)
print(winner3)

winner2 = random.choices(lottery, weights=[1, 2, 3, 4, 5], k=2)
"""
weights gibt das gewicht der Teilnehmer an
z.B. wieviele Lose man hat und dementsprechend eine höhere Wahrscheinlichkeit zu gewinnen
"""

random.shuffle(lottery) #damit wird die liste gemischt
print(lottery)



#--Module sind selbst auch ausführbare Dateien
"""
Jedes Python File kann für ein anderes Python File als Modul funktionieren
"""

if __name__ == '__main__':
    print("Hier komplette Ablauflogik, falls dieses File als Hauptprogramm direkt ausgeführt wird")

    """
    __name__ == '__main__'
    Dies sagt wenn diese Datei als Hauptprogram ausgeführt wird, soll dies ausgeführt werden
    """

print(__file__) #Diese Referenz gibt einen Pfad an wo die Datei liegt










