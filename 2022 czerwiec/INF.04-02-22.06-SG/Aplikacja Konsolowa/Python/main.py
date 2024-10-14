class Osoba:
    count = 0
    
    def __init__(self, id = 1, name = ""):
        self.__id = id
        self.__name = name
        Osoba.count += 1
        
    def copy(self, otherPerson):
        self.__id = otherPerson.__id
        self.__name = otherPerson.__name
        return
        
    def showName(self, othername):
        if (self.__name != ""):
            print("Cześć ", othername, ", mam na imię ", self.__name, sep="")
        else:
            print("Brak danych!")
        
print("Liczba zarejestrowanych osób to: ", Osoba.count);        
        
osoba1 = Osoba()

id = input("Podaj id osoby: ")
name = input("Podaj imię osoby: ")

osoba2 = Osoba(id, name)
osoba3 = Osoba()
osoba3.copy(osoba2)

osoba1.showName("Jan")
osoba2.showName("Jan")
osoba3.showName("Jan")

print("Liczba zarejestrowanych osób to: ", Osoba.count);  
