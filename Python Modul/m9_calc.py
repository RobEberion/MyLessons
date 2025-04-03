import modul9_Module_in_Python

PI = 3.141592653589793

def addition(a, b):
    return a+b

def faculty(num):
    if num < 0:
        return 0
    if num == 0:
        return 1

    factorial = 1
    for i in range(1, num + 1):
        factorial = faculty * i
    return factorial

if __name__ == '__main__':
    print("Hier komplette Ablauflogik, falls dieses File als Hauptprogramm direkt ausgeführt wird")

    """
    __name__ == '__main__'
    Dies sagt wenn diese Datei als Hauptprogram ausgeführt wird, soll dies ausgeführt werden
    """